using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kros.Struktura
{
    class Firma
    {
        int firma_id;
        string firma_nazov, riaditel;

        public int Firma_id { get => firma_id; set => firma_id = value; }
        public string Firma_nazov { get => firma_nazov; set => firma_nazov = value; }
        public string Riaditel { get => riaditel; set => riaditel = value; }

        public string parametre() { return "firma_id,firma_nazov,riaditel"; }

    }
}
