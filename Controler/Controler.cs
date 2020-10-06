using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

using Kros.Forms;

using System.Configuration;
using System.Linq.Expressions;
using System.Runtime.Remoting.Messaging;

namespace Kros.Controler
{
    public class Controler
    {
        protected DbCommand sql_cmd;
        protected DataGridView dataGrid;
        protected ListBox listBox;
        protected string select_text = "";
        protected Zamestnanec prihlas_zamest;
        
        public DbCommand DbCommand { get => sql_cmd; set => sql_cmd = value; }
        public DataGridView DataGrid { get => dataGrid; set => dataGrid = value; }
        public ListBox ListBox { get => listBox; set => listBox = value; }
        public string Select_text { get => select_text; set => select_text = value; }
        public Zamestnanec Prihlas_zamest { get => prihlas_zamest; set => prihlas_zamest = value; }

        public virtual void select() 
        {
            SelectWindow selectWindow = new SelectWindow(this);
            selectWindow.Show();
        }
        public virtual void insert()
        {

            ZmenaWindow window = new ZmenaWindow(this, sql_cmd, false);
            window.DbCommand = sql_cmd;
            window.Zmena = false;
            window.Show();
        }
        public virtual void update()
        {

            ZmenaWindow window = new ZmenaWindow(this, sql_cmd, true);
            window.DbCommand = sql_cmd;
            window.Zmena = true;
            window.Show();
        }

        public virtual void delete() 
        {
            try
            {
                if (MessageBox.Show("Naozaj chcete vymazat zvolene data?", "DELETE", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    foreach (DataGridViewRow row in dataGrid.SelectedRows)
                    {
                        //dataGridView1.Rows.RemoveAt(row.Index);
                        var index = row.Cells[0].Value;
                        string text = $"Delete From {ToString()} Where {ToString()}_id = {index}";
                        zapis_log(text);
                        sql_cmd.CommandText = text;
                        sql_cmd.ExecuteNonQuery();
                    }
                    if (sql_cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Data boli uspesne vymazane");
                    }
                }
                obnova_dat();
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
        }
        public virtual void obnova_dat() { }
        public virtual string parametre() { return ""; }
        public void zapis_log(string cmd) 
        {
            int id;
            DateTime dateTimeVariable = DateTime.Now;
            DbCommand.CommandText = "Select Max(log_id) From Log";
            try { id = (Int32)DbCommand.ExecuteScalar(); } catch { id = 0; }
            id++;
            DbCommand.CommandText = $"Insert into Log Values ('{id}', '{dateTimeVariable}', '{Prihlas_zamest.Id}', '{Prihlas_zamest.Meno}'" +
                $", '{Prihlas_zamest.Priezvisko}', '{cmd}' )";
            DbCommand.ExecuteNonQuery();
        }
        public virtual string parametre_tabulka() { return parametre(); }
    }

}
