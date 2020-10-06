using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kros
{
    public partial class RozsireneMoznosti : Form
    {
        DbCommand sql_cmd;
        public RozsireneMoznosti()
        {
            InitializeComponent();
        }

        public DbCommand Sql_cmd { get => sql_cmd; set => sql_cmd = value; }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonPotvrdit_Click(object sender, EventArgs e)
        {
            sql_cmd.CommandText = richTextBox1.Text;
            List<string> data = new List<string>();
            List<Zamestnanec> ludia = new List<Zamestnanec>();

            using (DbDataReader dataReader = sql_cmd.ExecuteReader())
            {
                try
                {
                    while (dataReader.Read())
                    {
                        //Console.WriteLine($"{dataReader["Id"]} " + $"{dataReader["FirstName"]}" + $"{dataReader["LastName"]}");

                        //Zamestnanec Zamestnanec = new Zamestnanec({int.Parse(dataReader["Id"]}), $"{dataReader["FirstName"]}" , $"{dataReader["LastName"]}");
                        Zamestnanec zamestnanec = new Zamestnanec();
                        zamestnanec.Id = int.Parse($"{dataReader["zamestnanec_Id"]}");
                        zamestnanec.Titul = $"{dataReader["zamestnanec_Titul"]}";
                        zamestnanec.Meno = $"{dataReader["zamestnanec_Meno"]}";
                        zamestnanec.Priezvisko = $"{dataReader["zamestnanec_Priezvisko"]}";
                        zamestnanec.Vek = int.Parse($"{dataReader["zamestnanec_Vek"]}");
                        zamestnanec.Telefon = $"{dataReader["zamestnanec_Telefon"]}";
                        zamestnanec.Email = $"{dataReader["zamestnanec_Email"]}";
                        zamestnanec.Zaradenie = $"{dataReader["zamestnanec_Zaradenie"]}";
                        ludia.Add(zamestnanec);
                        //listBoxSelect.Items.Add(Zamestnanec.ToString());
                    }
                }
                catch { }
            }
            dataGridView1.DataSource = ludia;
        }
    }
}
