using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kros.Struktura
{
    class Odelenie
    {
        int oddelenie_id, projekt_id;
        string oddelenie_nazov, oddelenie_veduci;

        public int Oddelenie_id { get => oddelenie_id; set => oddelenie_id = value; }
        public int Projekt_id { get => projekt_id; set => projekt_id = value; }
        public string Oddelenie_nazov { get => oddelenie_nazov; set => oddelenie_nazov = value; }
        public string Oddelenie_veduci { get => oddelenie_veduci; set => oddelenie_veduci = value; }
        public string parametre() { return "odelenie_id,project_id,odelenie_nazov,odelenie_veduci"; }

    }
}
