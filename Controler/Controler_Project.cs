using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;


using System.Configuration;
using System.Linq.Expressions;
using Kros.Struktura;
using Kros.Forms;


namespace Kros.Controler
{
    class Controler_Project : Controler
    {
        Project projekt = new Project();

        public override void obnova_dat()
        {
            if (select_text != "")
            {
                sql_cmd.CommandText = select_text;
                select_text = "";
            }
            else { sql_cmd.CommandText = "Select * From Project"; }
            listBox.Items.Add(sql_cmd.CommandText);
            List<Project> projekty = new List<Project>();
            try
            {
                using (DbDataReader dataReader = sql_cmd.ExecuteReader())
                {

                    while (dataReader.Read())
                    {
                        Project projekt = new Project();
                        projekt.Projekt_id = int.Parse($"{dataReader["project_id"]}");
                        projekt.Divizia_id = int.Parse($"{dataReader["divizia_id"]}");
                        projekt.Projekt_nazov = $"{dataReader["project_nazov"]}";
                        projekt.Projekt_veduci = $"{dataReader["project_veduci"]}";
                        projekty.Add(projekt);
                    }
                }
            }
            catch { MessageBox.Show("Zadal si zle udaje"); }


            dataGrid.DataSource = projekty;
        }
        public override string parametre()
        {
            return projekt.parametre();
        }

        public override string ToString()
        {
            return "Project";
        }
    }
}
