using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kros.Struktura
{
    class Divizia
    {
        int divizia_id, firma_id;
        string divizia_nazov, divizia_veduci;

        public int Divizia_id { get => divizia_id; set => divizia_id = value; }
        public int Firma_id { get => firma_id; set => firma_id = value; }
        public string Divizia_nazov { get => divizia_nazov; set => divizia_nazov = value; }
        public string Divizia_veduci { get => divizia_veduci; set => divizia_veduci = value; }

        public string parametre() { return "divizia_id,firma_id,divizia_nazov,divizia_veduci"; }
    }
}
