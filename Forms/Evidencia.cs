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

namespace Kros
{
    public partial class Evidencia : Form
    {
        DbCommand sql_cmd;
        Controler.Controler controler;
        Zamestnanec prihlas_zamestnanec;

        public Zamestnanec Prihlas_zamestnanec { get => prihlas_zamestnanec; set => prihlas_zamestnanec = value; }

        public Evidencia(DbCommand command, Controler.Controler con)
        {
            InitializeComponent();
            sql_cmd = command;

            controler = con;

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            controler.DataGrid = dataGridView1;
            controler.ListBox = listBoxSelect_View;
            controler.DbCommand = sql_cmd;
            controler.obnova_dat();
            if (controler is Controler.Controler_Zaradenie || controler is Controler.Controler_Log)
            { buttonZmen.Hide(); }
        }

        private void buttonSelect_Potvrdit_Click(object sender, EventArgs e)
        {
            //if (sql_cmd.CommandText == "") { obnova_dat(); }
            controler.obnova_dat();
        }

    private void buttonZmen_Click(object sender, EventArgs e)
        {
            controler.update();
        }

        private void buttonVymaz_Click(object sender, EventArgs e)
        {
            controler.delete();
        }

        private void buttonNajdi_Click(object sender, EventArgs e)
        {
            controler.select();
        }

        private void buttonPridaj_Click(object sender, EventArgs e)
        {
            controler.insert();
        }

        private void obnova_dat()
        {
            controler.obnova_dat();
        }

        private void buttonZatvorit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }   

}
