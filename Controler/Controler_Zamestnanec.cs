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
using Kros.Forms;

namespace Kros.Controler
{
    class Controler_Zamestnanec : Controler
    {
        Zamestnanec zamestnanec = new Zamestnanec();
        public override void obnova_dat() 
        {
            
            if (select_text != "") 
            { 
                sql_cmd.CommandText = select_text;
                select_text = "";
            }
            else { sql_cmd.CommandText = "Select * From Zamestnanec"; }
            listBox.Items.Add(sql_cmd.CommandText);
            List<Zamestnanec> ludia = new List<Zamestnanec>();
            try
            {
                using (DbDataReader dataReader = sql_cmd.ExecuteReader())
                {
                
                    while (dataReader.Read())
                    {
                        Zamestnanec zamestnanec = new Zamestnanec();
                        zamestnanec.Id = int.Parse($"{dataReader["zamestnanec_Id"]}");
                        zamestnanec.Titul = $"{dataReader["zamestnanec_Titul"]}";
                        zamestnanec.Meno = $"{dataReader["zamestnanec_Meno"]}";
                        zamestnanec.Priezvisko = $"{dataReader["zamestnanec_Priezvisko"]}";
                        zamestnanec.Vek = int.Parse($"{dataReader["zamestnanec_Vek"]}");
                        zamestnanec.Telefon = $"{dataReader["zamestnanec_Telefon"]}";
                        zamestnanec.Email = $"{dataReader["zamestnanec_Email"]}";
                        zamestnanec.Zaradenie = $"{dataReader["zamestnanec_Zaradenie"]}";
                        ludia.Add(zamestnanec);
                    }
                }
            }
            catch { MessageBox.Show("Zadal si zle udaje"); }

            dataGrid.DataSource = ludia;
        }

        public override string parametre()
        {
            return zamestnanec.parametre();
        }

        public override string ToString()
        {
            return "Zamestnanec";
        }
    }
}
