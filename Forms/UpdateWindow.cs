using System;
using System.Collections;
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
    public partial class UpdateWindow : Form
    {
        List<int> indexy;
        List<string> atributy;
        int poc_podm = 1; 
        DbCommand sql_cmd;
        //bool condition = false;     // insert or update

        public DbCommand Sql_cmd { get => sql_cmd; set => sql_cmd = value; }
        public List<int> Indexy { get => indexy; set => indexy = value; }
        //public bool Condition { get => condition; set => condition = value; }

        public UpdateWindow()
        {
            InitializeComponent();
            List<string> new_atributy = new List<string>();
            new_atributy.Add("Titul");
            new_atributy.Add("Meno");
            new_atributy.Add("Priezvisko");
            new_atributy.Add("Vek");
            new_atributy.Add("Telefon");
            new_atributy.Add("Email");
            new_atributy.Add("Zaradenie");
            new_atributy.Add("None");
            comboBox1.DataSource = new_atributy;
            textBox1.Text = "Zadajte udaj";
        }


        private void buttonAdd_cond_Click(object sender, EventArgs e)
        {
            if (poc_podm <= 5)
            {
                List<string> new_atributy = new List<string>();
                new_atributy.Add("Titul");
                new_atributy.Add("Meno");
                new_atributy.Add("Priezvisko");
                new_atributy.Add("Vek");
                new_atributy.Add("Telefon");
                new_atributy.Add("Email");
                new_atributy.Add("Zaradenie");
                new_atributy.Add("None");
                poc_podm ++;
                ComboBox comboBox = new ComboBox();
                comboBox.DataSource = new_atributy;
                comboBox.Name = $"comboBox{poc_podm}";
                TextBox textBox = new TextBox();
                textBox.Name = $"textBox{poc_podm}";
                textBox.Top = poc_podm * 40;
                textBox.Left = 230;
                textBox.Text = "Zadajte udaj";

                comboBox.Top = poc_podm * 40;
                comboBox.Left = 50;
                comboBox.Width = textBox.Width = 130;
                //comboBox.SelectedIndexChanged += new EventHandler(comboBox_SelectedIndexChanged);
                this.Controls.Add(comboBox);
                this.Controls.Add(textBox);
            }
        }

        private void buttonZatvorit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonPotvrdit_Click(object sender, EventArgs e)
        {
            List<string> stlpce = new List<string>();
            List<string> udaje = new List<string>();
            foreach (Control ctrl in this.Controls)                             // nacitanie si dat ktore chcem zmenit alebo pridat
            {
                if (ctrl is ComboBox && ctrl != sender && ctrl.Enabled)
                {
                    stlpce.Add(ctrl.Text);
                }
                if (ctrl is TextBox && ctrl != sender && ctrl.Enabled)
                {
                    udaje.Add(ctrl.Text);
                }
            }                                       
            for (int i = 0; i < indexy.Count; i++)
            {
                string text = $"Update Zamestnanec Set ";
                for (int j = 0; j < stlpce.Count; j++)
                {
                    text += $" {stlpce[j]} = '{udaje[j]}' ";
                    if (j != stlpce.Count - 1) { text += " , "; }
                }
                text += $" Where Id = {indexy[i]} ";
                sql_cmd.CommandText = text;
                sql_cmd.ExecuteNonQuery();
            }
            

            this.Close();
        }
           
        
    }
       
        //private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    foreach (Control ctrl in this.Controls)
        //    {
        //        if (ctrl is ComboBox && ctrl != sender && ctrl.Enabled)
        //        {
        //            ((BindingSource)((ComboBox)ctrl).DataSource).RemoveAt(((ComboBox)sender).SelectedIndex);
        //        }
        //    }
        //    ((ComboBox)sender).Enabled = false;
        //}

        //private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    foreach (Control ctrl in this.Controls)
        //    {
        //        if (ctrl is ComboBox && ctrl != sender && ctrl.Enabled)
        //        {
        //            ((BindingSource)((ComboBox)ctrl).DataSource).RemoveAt(((ComboBox)sender).SelectedIndex);
        //        }
        //    }
        //    ((ComboBox)sender).Enabled = false;
        //}
    
}
