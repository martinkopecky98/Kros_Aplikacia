using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Common;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Kros.Forms;

namespace Kros
{
    public partial class HomePage : Form
    {
        Prihlasenie prihlasenie;
        private DbCommand sql_cmd;
        bool admin = false;
        Zamestnanec prihlas_zamest;
        public HomePage(DbCommand command, Prihlasenie prih)
        {
            InitializeComponent();
            customizeDesing();
            sql_cmd = command;
            prihlasenie = prih;
        }

        private void customizeDesing()
        {
            panelPrikazySubMenu.Visible = false;
            panelDatabazaSubMenu.Visible = false;
            panelMoznostiSubMenu.Visible = false;
            string coment = "Vytvárame a dodávame našim zákazníkom výnimočne dobré programy, ktoré im pomáhajú v tom, aby boli úspešní.";
            listBoxHomePage.Items.Add(coment);
        }

        private void hide_subMenu()
        {
            if (panelPrikazySubMenu.Visible == true) { panelPrikazySubMenu.Visible = false; }
            if (panelDatabazaSubMenu.Visible == true) { panelDatabazaSubMenu.Visible = false; }
            if (panelMoznostiSubMenu.Visible == true) { panelMoznostiSubMenu.Visible = false; }
        }

        private void show_subMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hide_subMenu();
                subMenu.Visible = true;
            }
            else { subMenu.Visible = false; }
        }
        
        private void buttonPrikazy_Click(object sender, System.EventArgs e)
        {
            show_subMenu(panelPrikazySubMenu);
        }

        #region EvidencieSubMenu
        private void buttonSelect_Click(object sender, System.EventArgs e)
        {
            Controler.Controler_Zamestnanec controler = new Controler.Controler_Zamestnanec();
            controler.Prihlas_zamest = prihlas_zamest;
            openChildForm(new Evidencia(sql_cmd, controler));
            hide_subMenu();
        }
        private void buttonOddelenia_Click(object sender, EventArgs e)
        {
            Controler.Controler_Odelenie controler = new Controler.Controler_Odelenie();
            controler.Prihlas_zamest = prihlas_zamest;
            openChildForm(new Evidencia(sql_cmd, controler));
            hide_subMenu();

        }
        private void buttonProjekty_Click(object sender, EventArgs e)
        {
            Controler.Controler_Project controler = new Controler.Controler_Project();
            controler.Prihlas_zamest = prihlas_zamest;
            openChildForm(new Evidencia(sql_cmd, controler));
            hide_subMenu();
        }

        private void buttonFirma_Click(object sender, EventArgs e)
        {
            Controler.Controler_Firma controler = new Controler.Controler_Firma();
            controler.Prihlas_zamest = prihlas_zamest;
            openChildForm(new Evidencia(sql_cmd, controler));
            hide_subMenu();
        }

        private void buttonDivizia_Click(object sender, EventArgs e)
        {
            Controler.Controler_Divizia controler = new Controler.Controler_Divizia();
            controler.Prihlas_zamest = prihlas_zamest;
            openChildForm(new Evidencia(sql_cmd, controler));
            hide_subMenu();
        }

        private void buttonZaradenie_Click(object sender, EventArgs e)
        {
            if (!admin) { zamietnute_massage(); }
            else
            {
                Controler.Controler_Zaradenie controler = new Controler.Controler_Zaradenie();
                controler.Prihlas_zamest = prihlas_zamest;
                openChildForm(new Evidencia(sql_cmd, controler));
                hide_subMenu();
            }

        }

        #endregion


        private void buttonDatabaza_Click(object sender, System.EventArgs e)
        {
            show_subMenu(panelDatabazaSubMenu);
        }

        #region DatabazaSubMenu
        private void buttonSaveBackup_Click(object sender, EventArgs e)
        {
            List<Controler.Controler> controlers = new List<Controler.Controler>();
            controlers.Add(new Controler.Controler_Divizia());
            controlers.Add(new Controler.Controler_Firma());
            controlers.Add(new Controler.Controler_Odelenie());
            controlers.Add(new Controler.Controler_Project());
            controlers.Add(new Controler.Controler_Zamestnanec());
            controlers.Add(new Controler.Controler_Zaradenie());
            controlers.Add(new Controler.Controler_Log());

            foreach (var con in controlers)
            {
                backup_zapisanie(con);
            }

            hide_subMenu();
        }
        private void vymazanie_dat_zTabuliek()
        {
            sql_cmd.CommandText = "Delete From Zaradenie";
            sql_cmd.ExecuteNonQuery();
            sql_cmd.CommandText = "Delete From Log";
            sql_cmd.ExecuteNonQuery();
            sql_cmd.CommandText = "Delete From Zamestnanec";
            sql_cmd.ExecuteNonQuery();
            sql_cmd.CommandText = "Delete From Odelenie";
            sql_cmd.ExecuteNonQuery();
            sql_cmd.CommandText = "Delete From Project";
            sql_cmd.ExecuteNonQuery();
            sql_cmd.CommandText = "Delete From Divizia";
            sql_cmd.ExecuteNonQuery();
            sql_cmd.CommandText = "Delete From Firma";
            sql_cmd.ExecuteNonQuery();

        }
        private void buttonDeleteData_Click(object sender, System.EventArgs e)
        {
            if (admin)
            {
                if (MessageBox.Show("Naozaj chcete vymazat vsetky data?", "DELETE", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    vymazanie_dat_zTabuliek();
                    MessageBox.Show("Data boli uspesne vymazane");
                }
            }
            else { zamietnute_massage(); }
            hide_subMenu();

        }

        private void backup_zapisanie(Controler.Controler controler)
        {
            List<string> lines = new List<string>();
            string[] param;
            param = controler.parametre_tabulka().Split(',');
            
            sql_cmd.CommandText = $"Select * From {controler.ToString()}";

            using (DbDataReader dataReader = sql_cmd.ExecuteReader())
            {
                while (dataReader.Read())
                {
                    string line = " ";
                    for (int i = 0; i < param.Length; i++)
                    {
                        line += dataReader[param[i]].ToString();
                        if (i + 1 != param.Length) { line += ";"; }
                    }
                    lines.Add(line);
                }
                using (System.IO.StreamWriter file = new System.IO.StreamWriter($"../../Backup/Backup_{controler.ToString()}.csv"))
                {
                    foreach (string line in lines) { file.WriteLine(line); }
                }
                lines.Clear();
            }
        }


        private void buttonBackup_Click(object sender, System.EventArgs e)
        {
            vymazanie_dat_zTabuliek();
            List<Controler.Controler> controlers = new List<Controler.Controler>();
            controlers.Add(new Controler.Controler_Firma());
            controlers.Add(new Controler.Controler_Divizia());
            controlers.Add(new Controler.Controler_Project());
            controlers.Add(new Controler.Controler_Odelenie());
            controlers.Add(new Controler.Controler_Zamestnanec());
            controlers.Add(new Controler.Controler_Zaradenie());
            controlers.Add(new Controler.Controler_Log());
            foreach (var con in controlers)
            {
                backup_citanie(con);
            }
            hide_subMenu();
        }

        private void backup_citanie(Controler.Controler controler)
        {
            List<string> riadky = File.ReadAllLines($"../../Backup/Backup_{controler.ToString()}.csv").ToList();
            int index = 1;
            string text = "";
            foreach (var line in riadky)
            {
                string[] riadok = line.Split(';');
                text = $"INSERT INTO {controler.ToString()} VALUES ( "; //'{index}',
                
                for (int i = 0; i < riadok.Length; i++)
                {
                    text += $"'{riadok[i]}'"; 
                    if (i + 1 != riadok.Length) { text += ","; }
                    else { text += ")"; }
                }
                sql_cmd.CommandText = text;
                sql_cmd.ExecuteNonQuery();

                index++;
            }
        }

        #endregion
        private void buttonOptions_Click(object sender, System.EventArgs e)
        {
            show_subMenu(panelMoznostiSubMenu);
        }

        #region MoznostiSubMenu


        private void buttonClose_Click(object sender, System.EventArgs e)
        {
            hide_subMenu();
            if (MessageBox.Show("Naozaj chcete ukoncit program?", "END", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
                prihlasenie.Close();
            }
        }

        private void buttonLogOff_Click(object sender, EventArgs e)
        {
            prihlasenie.Show();
            foreach (Control item in prihlasenie.Controls)
            {
                if (item is TextBox) { item.Text = ""; }
            }
            this.Close();
        }

        private void buttonRozsirene_Click(object sender, EventArgs e)
        {
            if (!admin) { zamietnute_massage(); }
            else
            {
                RozsireneMoznosti rozsireneMoznosti = new RozsireneMoznosti();
                rozsireneMoznosti.Show();
                rozsireneMoznosti.Sql_cmd = sql_cmd;
                hide_subMenu();
            }
        }
        #endregion

        private Form activeForm = null;

        public bool Admin { get => admin; set => admin = value; }
        internal Zamestnanec Prihlas_zamest { get => prihlas_zamest; set => prihlas_zamest = value; }

        private void openChildForm(Evidencia childForm)
        {
            if(activeForm != null) { activeForm.Close(); }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            listBoxHomePage.Visible = false;
            panelHome_Page.Visible = false;
            childForm.Prihlas_zamestnanec = prihlas_zamest;
            childForm.BringToFront();
            childForm.Show();
        }




        private void zamietnute_massage()
        { MessageBox.Show("Na tuto akciu nemate opravnenie"); }

        private void buttonLog_Click(object sender, EventArgs e)
        {
            if (admin) 
            {
                Controler.Controler_Log controler = new Controler.Controler_Log();
                controler.Prihlas_zamest = prihlas_zamest;
                openChildForm(new Evidencia(sql_cmd, controler));
                hide_subMenu();
            }
            else { zamietnute_massage(); }
        }

    }
}
