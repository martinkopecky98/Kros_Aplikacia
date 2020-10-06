using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kros.Forms
{
    public partial class ZmenaWindow : Form
    {
        Controler.Controler controler;
        List<string> udaje = new List<string>();
        List<string> new_udaje = new List<string>();        // udaje ziskane z textboxov
        bool zmena = false;
        DbCommand dbCommand;

        public DbCommand DbCommand { get => dbCommand; set => dbCommand = value; }
        public bool Zmena { get => zmena; set => zmena = value; }

        public ZmenaWindow(Controler.Controler con, DbCommand command, bool change)
        {
            zmena = change;
            dbCommand = command;
            controler = con;
            string riadok = controler.parametre();
            string[] udaj = riadok.Split(',');
            if (controler is Controler.Controler_Zaradenie)
            {
                udaje.Add("zaradenie_cas");
                udaje.Add("zamestnanec_id");
                udaje.Add("odelenie_id");
                new_udaje.Add(DateTime.Now.ToString());
                
            }
            else
            {
                foreach (string item in udaj)
                {
                    udaje.Add(item);
                }
            }

            pridajNazvy();
            if (change) { vypln_udaje(); }
            
            InitializeComponent();
        }

        private void pridajNazvy() 
        {
            int xL = 50 , xT = 200, y = 50;

            for (int i = 1; i < udaje.Count; i++)
            {
                Label label = new Label();
                label.Text = udaje[i];
                label.Location = new Point(xL, y);


                TextBox textBox = new TextBox();
                textBox.Text = "None";
                textBox.Location = new Point(xT, y);
                textBox.Width = 110;
                y += 50;

                this.Controls.Add(label);
                this.Controls.Add(textBox);
            }

        }

        private void buttonPotvrdit_Click(object sender, EventArgs e)
        {

            foreach (Control con in Controls)
            {
                if (con is TextBox)
                {
                    /*if (con.Text != "" ) */{ new_udaje.Add(con.Text); }
                }
            }
            if (zmena) 
            {
                update(new_udaje);
            }
            else 
            {
                 insert(new_udaje); 
            }
            controler.obnova_dat();
            this.Close();
        }

        private void update(List<string>new_udaje) 
        {
            string cmd = "", text = "";
            List<int> indexy = new List<int>();
            string nazov = controler.ToString();

            foreach (DataGridViewRow row in controler.DataGrid.SelectedRows)
            {
                int index = int.Parse($" {row.Cells[0].Value}");
                indexy.Add(index);
            }
            List<int> hodnoty = new List<int>();
            for (int i = 0; i < new_udaje.Count; i++)
            {
                if (new_udaje[i] != "None" ) { hodnoty.Add(i); }
            }

            text = cmd = $"Update {nazov} set ";
            for (int i = 0; i < hodnoty.Count; i++)
            {
                cmd += $" {udaje[hodnoty[i] + 1]} = '{new_udaje[hodnoty[i]]}' ";
                text += $"{udaje[hodnoty[i] + 1]} = {new_udaje[hodnoty[i]]} ";
                
                if (i + 1 != hodnoty.Count) { cmd += ","; }
            }

            for (int i = 0; i < indexy.Count; i++)
            {
                text += $"Where {nazov}_id = {indexy[i]}";
                controler.zapis_log(text);
                dbCommand.CommandText = $" {cmd} Where {nazov}_id = {indexy[i]}";
                try { dbCommand.ExecuteNonQuery(); }
                catch
                {
                    MessageBox.Show("Zadali ste nespravne udaje");
                }
            }
        }
        private void update_zaradenie(List<string> new_udaje) 
        {
            string cmd = "", text = "";
            cmd = text = "Update Zaradenie Values (";
            for (int i = 0; i < new_udaje.Count; i++)
            {
                cmd += $" '{new_udaje[i]}' ";
                text += $" {new_udaje[i]} ";

                if (i + 1 != new_udaje.Count) { cmd += ","; }
                else { cmd += ")"; }
            }
            controler.zapis_log(text);
            dbCommand.CommandText = cmd;
        }
        private void insert_zaradenie(List<string> new_udaje)
        {
            string cmd = "", text = "", update = "";
            text = $"Select odelenie_nazov from Odelenie where odelenie_id = {new_udaje[2]}";
            dbCommand.CommandText = text;
            update = dbCommand.ExecuteScalar().ToString();
            text = $"Update Zamestnanec set zamestnanec_zaradenie = '{update}' where zamestnanec_id = {new_udaje[1]}";
            //"Update Zamestnanec set zamestnanec_zaradenie = 'Zapad' where zamestnanec_id = 9"
            dbCommand.CommandText = text;
            dbCommand.ExecuteScalar();
            cmd = text = $"Insert into Zaradenie Values (";
            for (int i = 0; i < new_udaje.Count; i++)
            {
                cmd += $" '{new_udaje[i]}' ";
                text += $" {new_udaje[i]} ";

                if (i + 1 != new_udaje.Count) { cmd += ","; }
                else { cmd += ")"; }
            }
            controler.zapis_log(text);
            dbCommand.CommandText = cmd;
        }

        private void insert(List<string> new_udaje) 
        {
            string cmd = "", text = "";
            List<int> indexy = new List<int>();
            string nazov = controler.ToString();

            if (controler is Controler.Controler_Zaradenie)
            { insert_zaradenie(new_udaje); }
            else
            {
                dbCommand.CommandText = $"Select Max ({nazov}_ID) From {nazov}";
                int id;
                try { id = (Int32)dbCommand.ExecuteScalar(); } catch { id = 0; }

                text = cmd = $"Insert into {nazov} ";
                /*(";
                for (int i = 0; i < udaje.Count; i++)
                {
                    cmd += $" {udaje[i]} ";
                    if (i + 1 != udaje.Count) { cmd += ","; }
                }
                cmd += $") */
                cmd += $" Values ( '{++id}',";
                text += $" Values ( {++id} ,";
                for (int i = 0; i < new_udaje.Count; i++)
                {
                    cmd += $" '{new_udaje[i]}' ";
                    text += $" {new_udaje[i]} ";

                    if (i + 1 != new_udaje.Count) { cmd += ","; }
                    else { cmd += ")"; }
                }
                controler.zapis_log(text);
                dbCommand.CommandText = cmd;
                //dbCommand.ExecuteNonQuery();
            }

                try { dbCommand.ExecuteNonQuery(); }
            catch
            {
                MessageBox.Show("Zadali ste nespravne udaje");
            }
        }

        private void buttonZatvorit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void vypln_udaje()
        {
            if (controler.DataGrid.SelectedRows.Count == 1)
            {
                string par = controler.parametre();
                string[] parametre = par.Split(',');
                string nazov = controler.ToString();
                var row = controler.DataGrid.SelectedRows[0];
                string tx = $"select * from {nazov} where {nazov}_id = '{row.Cells[0].Value}'";
                dbCommand.CommandText = tx;
                using (DbDataReader reader = dbCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = 1;
                        for (int i = 0; i < Controls.Count; i++)
                        {
                            if (Controls[i] is TextBox)
                            {
                                //var item = reader.GetValue(id);
                                //Controls[i].Text = item.ToString();
                                Controls[i].Text = reader[parametre[id]].ToString();
                                id++;
                            }

                        }
                    }
                }
            }
        }
    }
}
