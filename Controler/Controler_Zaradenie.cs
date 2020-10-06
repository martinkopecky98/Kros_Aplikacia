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
using System.Security.Cryptography;

namespace Kros.Controler
{
    class Controler_Zaradenie : Controler
    {
        Zaradenie zaradenie = new Zaradenie();

        public override void insert()
        {
            base.insert();
        }
        public override void obnova_dat()
        {
            if (select_text != "")
            {
                sql_cmd.CommandText = select_text;
                select_text = "";
            }
            else 
            { 

                string[] parametre = zaradenie.parametre().Split(',');
                string text = "Select ";
                for (int i = 0; i < parametre.Length; i++)
                {
                    text += parametre[i];
                    if (i + 1 != parametre.Length) { text += ','; }
                }
                text = " Select * from Zamestnanec zm join Zaradenie zd on zm.zamestnanec_id = zd.zamestnanec_id " +
                    " join Odelenie od on zd.odelenie_id = od.odelenie_id ";
                sql_cmd.CommandText = text;
            }

            listBox.Items.Add(sql_cmd.CommandText);
            List<Zaradenie> zaradenia = new List<Zaradenie>();
            try
            {
                using (DbDataReader dataReader = sql_cmd.ExecuteReader())
                {

                    while (dataReader.Read())
                    {
                        Zaradenie zaradenie = new Zaradenie();
                        zaradenie.Zamestnanec_id = int.Parse($"{dataReader["zamestnanec_id"]}");
                        zaradenie.Zamestnanec_meno = $"{dataReader["zamestnanec_meno"]}";
                        zaradenie.Zamestnanec_priezvisko = $"{dataReader["zamestnanec_priezvisko"]}";
                        zaradenie.Odelenie_id = int.Parse($"{dataReader["odelenie_id"]}");
                        zaradenie.Odelenie_nazov = $"{dataReader["odelenie_nazov"]}";
                        zaradenie.Zaradenie_cas = $"{dataReader["zaradenie_cas"]}";

                        zaradenia.Add(zaradenie);
                    }
                }
            }
            catch { MessageBox.Show("Zadal si zle udaje"); }


            dataGrid.DataSource = zaradenia;
        }
        public override string parametre()
        {
            return zaradenie.parametre();
        }

        public override string parametre_tabulka()
        {
            return zaradenie.parametre_tab();
        }

        public override string ToString()
        {
            return "Zaradenie";
        }
    }
}
