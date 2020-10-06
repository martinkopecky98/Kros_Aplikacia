using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kros.Struktura
{
    class Log
    {
        int log_id;
        string log_cas_datum;
        int log_zam_id;
        string log_zam_meno, log_zam_priezvisko, log_zam_prikaz;

        public int Log_id { get => log_id; set => log_id = value; }
        public string Log_cas_datum { get => log_cas_datum; set => log_cas_datum = value; }
        public int Log_zam_id { get => log_zam_id; set => log_zam_id = value; }
        public string Log_zam_meno { get => log_zam_meno; set => log_zam_meno = value; }
        public string Log_zam_priezvisko { get => log_zam_priezvisko; set => log_zam_priezvisko = value; }
        public string Log_zam_prikaz { get => log_zam_prikaz; set => log_zam_prikaz = value; }
        public string parametre() { return "log_id,log_cas_datum,log_zam_id,log_zam_meno,log_zam_priezvisko,log_zam_prikaz"; }
    }
}
