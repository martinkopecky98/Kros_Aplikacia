using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kros.Struktura
{
    class Zaradenie
    {
        private int zamestnanec_id, odelenie_id;
        private string zamestnanec_meno, zamestnanec_priezvisko, odelenie_nazov, zaradenie_cas;

        public int Zamestnanec_id { get => zamestnanec_id; set => zamestnanec_id = value; }
        public string Zamestnanec_meno { get => zamestnanec_meno; set => zamestnanec_meno = value; }
        public string Zamestnanec_priezvisko { get => zamestnanec_priezvisko; set => zamestnanec_priezvisko = value; }
        public int Odelenie_id { get => odelenie_id; set => odelenie_id = value; }
        public string Odelenie_nazov { get => odelenie_nazov; set => odelenie_nazov = value; }
        public string Zaradenie_cas { get => zaradenie_cas; set => zaradenie_cas = value; }

        public string parametre() { return "zamestnanec_id,zamestnanec_meno,zamestnanec_priezvisko,odelenie_id,odelenie_nazov,zaradenie_cas"; }

        public string parametre_tab() { return "zaradenie_cas,zamestnanec_id,odelenie_id"; }
    }
}
