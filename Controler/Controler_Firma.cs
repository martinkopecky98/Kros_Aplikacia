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
    class Controler_Firma : Controler
    {
        Firma firma = new Firma();

        public override void obnova_dat()
        {
            if (select_text != "")
            {
                sql_cmd.CommandText = select_text;
                select_text = "";
            }
            else { sql_cmd.CommandText = "Select * From Firma"; }
            listBox.Items.Add(sql_cmd.CommandText);
            List<Firma> firmy = new List<Firma>();
            try
            {
                using (DbDataReader dataReader = sql_cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        Firma firma = new Firma();
                        firma.Firma_id = int.Parse($"{dataReader["firma_id"]}");
                        firma.Firma_nazov = $"{dataReader["firma_nazov"]}";
                        firma.Riaditel = $"{dataReader["riaditel"]}";
                        firmy.Add(firma);
                    }
                }
            }

            catch { MessageBox.Show("Zadal si zle udaje"); }


            dataGrid.DataSource = firmy;
        }
        public override string parametre()
        {
            return firma.parametre();
        }
        public override string ToString()
        {
            return "Firma";
        }
    }
}
