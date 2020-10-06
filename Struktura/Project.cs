using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kros.Struktura
{
    class Project
    {
        int projekt_id, divizia_id;
        string projekt_nazov, projekt_veduci;

        public int Projekt_id { get => projekt_id; set => projekt_id = value; }
        public int Divizia_id { get => divizia_id; set => divizia_id = value; }
        public string Projekt_nazov { get => projekt_nazov; set => projekt_nazov = value; }
        public string Projekt_veduci { get => projekt_veduci; set => projekt_veduci = value; }
        public string parametre() { return "project_id,divizia_id,project_nazov,project_veduci"; }

    }
}
