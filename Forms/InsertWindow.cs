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
    public partial class InsertWindow : Form
    {
        DbCommand sql_cmd;

        public DbCommand Sql_cmd { get => sql_cmd; set => sql_cmd = value; }

        public InsertWindow()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonZatvorit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonPotvrdit_Click(object sender, EventArgs e)
        {
            string meno = textBoxMeno.Text;
            string priezvisko = textBoxPriezvisko.Text;
            int vek = int.Parse(textBoxAge.Text);
            sql_cmd.CommandText = "Select MAX (Id) From Zamestnanec";
            int id = (Int32)sql_cmd.ExecuteScalar();
            id++;    
        
            sql_cmd.CommandText = $"Insert Into Zamestnanec Values ('{id}', null, '{meno}', '{priezvisko}', '{vek}', null, null, null)";
            sql_cmd.ExecuteNonQuery();
            this.Close();
        }

    }
}
