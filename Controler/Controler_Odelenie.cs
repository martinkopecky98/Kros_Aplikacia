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
    class Controler_Odelenie : Controler
    {
        Odelenie oddelenie = new Odelenie();

        public override void obnova_dat()
        {
            if (select_text != "")
            {
                sql_cmd.CommandText = select_text;
                select_text = "";
            }
            else { sql_cmd.CommandText = "Select * From Odelenie"; }
            listBox.Items.Add(sql_cmd.CommandText);
            List<Odelenie> oddelenia = new List<Odelenie>();
            try
            {
                using (DbDataReader dataReader = sql_cmd.ExecuteReader())
                {

                    while (dataReader.Read())
                    {
                        Odelenie oddel = new Odelenie();
                        oddel.Oddelenie_id = int.Parse($"{dataReader["odelenie_id"]}");
                        oddel.Projekt_id = int.Parse($"{dataReader["project_id"]}");
                        oddel.Oddelenie_nazov = $"{dataReader["odelenie_nazov"]}";
                        oddel.Oddelenie_veduci = $"{dataReader["odelenie_veduci"]}";
                        oddelenia.Add(oddel);
                    }
                }
            }
            catch { MessageBox.Show("Zadal si zle udaje"); }


            dataGrid.DataSource = oddelenia;
        }

        public override string parametre()
        {
            return oddelenie.parametre();
        }

        public override string ToString()
        {
            return "Odelenie";
        }
    }
}
