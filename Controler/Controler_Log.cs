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
    class Controler_Log : Controler
    {
        Log log= new Log();
        public override void obnova_dat()
        {
            if (select_text != "")
            {
                sql_cmd.CommandText = select_text;
                select_text = "";
            }
            else { sql_cmd.CommandText = "Select * From Log"; }
            listBox.Items.Add(sql_cmd.CommandText);
            List<Log> logy = new List<Log>();
            try
            {
                using (DbDataReader dataReader = sql_cmd.ExecuteReader())
                {

                    while (dataReader.Read())
                    {
                        Log log = new Log();
                        log.Log_id = int.Parse($"{dataReader["log_id"]}");
                        log.Log_cas_datum = ($"{dataReader["log_cas_datum"]}");
                        log.Log_zam_id = int.Parse($"{dataReader["log_zam_id"]}");
                        log.Log_zam_meno = $"{dataReader["log_zam_meno"]}";
                        log.Log_zam_priezvisko = $"{dataReader["log_zam_priezvisko"]}";
                        log.Log_zam_prikaz = $"{dataReader["log_zam_prikaz"]}";
                        logy.Add(log);
                    }
                }
            }
            catch { MessageBox.Show("Zadal si zle udaje"); }


            dataGrid.DataSource = logy;
        }

        public override string parametre()
        {
            return log.parametre();
        }

        public override string ToString()
        {
            return "Log";
        }
    }
}
