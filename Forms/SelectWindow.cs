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
    public partial class SelectWindow : Form
    {
        bool vsetky_udaje = true;
        int poc_data = 1, poc_podm = 1;
        DbCommand sql_cmd;
        Controler.Controler controler;
        public DbCommand Sql_cmd { get => sql_cmd; set => sql_cmd = value; }

        public SelectWindow(Controler.Controler con)
        {
            InitializeComponent();
            controler = con;
            List<string> rozsir_podm = new List<string>();
            rozsir_podm.Add("None");
            rozsir_podm.Add("MIN");
            rozsir_podm.Add("MAX");
            rozsir_podm.Add("AVG");
            rozsir_podm.Add("COUNT");
            rozsir_podm.Add("SUM");
            List<string> sposob_hladania = new List<string>();
            sposob_hladania.Add("Minimalne jeden zo zvolenych");
            sposob_hladania.Add("Vsetky zvolene");
            //prirad_data(comboBox_Data0);
            prirad_data(comboBox_Condition0);
            prirad_data(comboBox_OrderBy);
            //comboBox_MulCondition.DataSource = rozsir_podm;
            comboBox_SelectView.DataSource = sposob_hladania;
            //radioButtonAllData.Checked = true;
        }
        void prirad_data(ComboBox comboBox)
        {
            List<string> new_atributy = new List<string>();
            string[] param = controler.parametre().Split(',');
            new_atributy.Add("None");
            foreach (string item in param)
            {
                new_atributy.Add(item);
            }
            comboBox.DataSource = new_atributy;

        }

        private void radioButtonAllData_CheckedChanged(object sender, EventArgs e)
        {
            vsetky_udaje = true;
        }

        private void radioButtonSelectedData_CheckedChanged(object sender, EventArgs e)
        {
            vsetky_udaje = false;
        }

        private void buttonAdd_cond_Click(object sender, EventArgs e)
        {
            if (poc_podm < 5)
            {

                ComboBox comboBox = new ComboBox();
                prirad_data(comboBox);
                comboBox.Name = $"comboBox_Condition{poc_podm}";
                TextBox textBox = new TextBox();
                int sirka = comboBox.Width = textBox.Width = 120;
                textBox.Name = $"textBox_Condition{poc_podm}";
                textBox.Left = 445; 
                textBox.Text = "None";

                textBox.Top = comboBox.Top = 85 + (40 * poc_podm);
                comboBox.Left = 305;
                //comboBox.SelectedIndexChanged += new EventHandler(comboBox_SelectedIndexChanged);
                this.Controls.Add(comboBox);
                this.Controls.Add(textBox);
                poc_podm++;
            }
        }

        private void buttonPotvrdit_Click(object sender, EventArgs e)
        {
            List<string> data = new List<string>();
            List<string> podm = new List<string>();
            List<string> podm_data = new List<string>();
            string mulCond = "None", orderBy = "None";
            foreach (Control ctrl in this.Controls)         /* ziskavanie dat z boxov*/
            {
                if (ctrl is ComboBox && ctrl != sender && ctrl.Enabled)
                {
                    for (int i = 0; i < poc_data; i++)
                    {
                        if (ctrl.Name == $"comboBox_Data{i}" && ctrl.Text != "None") { data.Add(ctrl.Text); }
                    }
                    for (int i = 0; i < poc_podm; i++)
                    {
                        if (ctrl.Name == $"comboBox_Condition{i}" && ctrl.Text != "None") { podm.Add(ctrl.Text); }
                    }
                    if (ctrl.Name == "comboBox_MulCondition" && ctrl.Text != "None") { 
                        mulCond = ctrl.Text; }
                    if (ctrl.Name == "comboBox_OrderBy" && ctrl.Text != "None") { 
                        orderBy = ctrl.Text; }
                }
                if (ctrl is TextBox && ctrl != sender && ctrl.Enabled) { podm_data.Add(ctrl.Text); }
            }
            string text = "Select * ";
            
            text += $" From {controler.ToString()}  Where ";
            string view = comboBox_SelectView.Text;
 
            for (int j = 0; j < podm.Count; j++)
            {
                text += $"{podm[j]} = '{podm_data[j]}' ";
                if (j != podm.Count - 1)
                {
                    if (view == "Vsetky zvolene") { text += " AND "; }
                    else { text += " OR "; }
                }
            }
            if(comboBox_OrderBy.Text != "None") { text += $" Order By {comboBox_OrderBy.Text} "; }
            //controler.zapis_log(text);
            controler.Select_text = text;
            this.Close();
        }

        private void buttonZatvorit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
