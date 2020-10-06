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
    class Controler_Divizia : Controler
    {

        Divizia divizia = new Divizia();

        public override void obnova_dat()
        {
            if (select_text != "")
            {
                sql_cmd.CommandText = select_text;
                select_text = "";
            }
            else { sql_cmd.CommandText = "Select * From Divizia"; }
            listBox.Items.Add(sql_cmd.CommandText);
            List<Divizia> diviz = new List<Divizia>();
            try
            {

                using (DbDataReader dataReader = sql_cmd.ExecuteReader())
                {

                    while (dataReader.Read())
                    {
                        Divizia divizia = new Divizia();
                        divizia.Divizia_id = int.Parse($"{dataReader["divizia_id"]}");
                        divizia.Firma_id = int.Parse($"{dataReader["firma_id"]}");
                        divizia.Divizia_nazov = $"{dataReader["divizia_nazov"]}";
                        divizia.Divizia_veduci = $"{dataReader["divizia_veduci"]}";
                        diviz.Add(divizia);
                    }
                }
            }
            catch { MessageBox.Show("Zadal si zle udaje"); }

            dataGrid.DataSource = diviz;
        }

        public override string parametre()
        {
            return divizia.parametre();
        }

        public override string ToString()
        {
            return "Divizia";
        }
    }
}
