using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.Data.Common;
using System.Configuration;
using System.Linq.Expressions;
using Kros.Controler;

namespace Kros.Forms
{
    public partial class Prihlasenie : Form
    {
        List<Zamestnanec> zamestnanci = new List<Zamestnanec>();
        DbCommand sql_cmd;
        Zamestnanec prihlas_zamenst;
        public Prihlasenie(DbCommand cmd)
        {
            sql_cmd = cmd;
            InitializeComponent();
        }

        private void buttonPotvrdit_Click(object sender, EventArgs e)
        {
            bool open = false, admin = false; ;


            if (textBoxMeno.Text == "admin" && textBoxHeslo.Text == "admin") 
            {
                admin = true;
                open = true;
                prihlas_zamenst = new Zamestnanec();
                prihlas_zamenst.Id = 0;
                prihlas_zamenst.Meno = "admin";
                prihlas_zamenst.Priezvisko = "admin";
            }
            else
            {
                sql_cmd.CommandText = "Select * from Zamestnanec";
                using (DbDataReader dataReader = sql_cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        Zamestnanec zamestnanec = new Zamestnanec();
                        zamestnanec.Id = int.Parse($"{dataReader["zamestnanec_Id"]}");
                        zamestnanec.Meno = $"{dataReader["zamestnanec_Meno"]}";
                        zamestnanec.Priezvisko = $"{dataReader["zamestnanec_Priezvisko"]}";
                        zamestnanci.Add(zamestnanec);
                    }
                }
                foreach (var zam in zamestnanci)
                {
                    if (textBoxMeno.Text == $"{zam.Meno}.{zam.Priezvisko}")
                    {
                        if(textBoxHeslo.Text == $"{zam.Priezvisko}{zam.Id}")
                        {
                            prihlas_zamenst = new Zamestnanec();
                            prihlas_zamenst.Id = zam.Id;
                            prihlas_zamenst.Meno = zam.Meno;
                            prihlas_zamenst.Priezvisko = zam.Priezvisko;
                            open = true;
                            break;
                        }
                    }
                }
            }
            if (open)
            { 
                HomePage homePage = new HomePage(sql_cmd, this);
                homePage.Prihlas_zamest = prihlas_zamenst;
                homePage.Admin = admin;
                homePage.Show();
                this.Visible = false;
            }
            else
            { MessageBox.Show("Zadali ste zle prihlasovacie udaje"); }
        }

        private void buttonZatvorit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void zatvorit()
        { this.Close(); }
    }
}
