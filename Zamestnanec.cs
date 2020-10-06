using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kros
{
    public class Zamestnanec
    {
        private int id, vek;
        private string titul, meno, priezvisko, telefon, email, zaradenie;

        public Zamestnanec() { }
        public int Id { get => id; set => id = value; }
        public string Titul { get => titul; set => titul = value; }
        public string Meno { get => meno; set => meno = value; }
        public string Priezvisko { get => priezvisko; set => priezvisko = value; }
        public int Vek { get => vek; set => vek = value; }
        public string Telefon { get => telefon; set => telefon = value; }
        public string Email { get => email; set => email = value; }
        public string Zaradenie { get => zaradenie; set => zaradenie = value; }

        public string parametre() { return "zamestnanec_id,zamestnanec_titul,zamestnanec_meno,zamestnanec_priezvisko,zamestnanec_vek,zamestnanec_telefon,zamestnanec_email,zamestnanec_zaradenie"; }


        //public int Id
        //{
        //    get { return id; }
        //    set { id = value; }
        //}
        //public string Meno
        //{
        //    get { return meno; }
        //    set { meno = value; }
        //}
        //public string Priezvisko
        //{
        //    get { return priezvisko; }
        //    set { priezvisko = value; }
        //}
        //public int Vek
        //{
        //    get { return vek; }
        //    set { vek = value; }
        //}
        }
}
