namespace Kros
{
    partial class Evidencia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSelect_Potvrdit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelSelect_VGiew = new System.Windows.Forms.Panel();
            this.listBoxSelect_View = new System.Windows.Forms.ListBox();
            this.buttonZmen = new System.Windows.Forms.Button();
            this.buttonVymaz = new System.Windows.Forms.Button();
            this.buttonPridaj = new System.Windows.Forms.Button();
            this.buttonZatvorit = new System.Windows.Forms.Button();
            this.buttonNajdi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelSelect_VGiew.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSelect_Potvrdit
            // 
            this.buttonSelect_Potvrdit.BackColor = System.Drawing.Color.CadetBlue;
            this.buttonSelect_Potvrdit.Location = new System.Drawing.Point(44, 299);
            this.buttonSelect_Potvrdit.Name = "buttonSelect_Potvrdit";
            this.buttonSelect_Potvrdit.Size = new System.Drawing.Size(98, 28);
            this.buttonSelect_Potvrdit.TabIndex = 14;
            this.buttonSelect_Potvrdit.Text = "Nacitat Data";
            this.buttonSelect_Potvrdit.UseVisualStyleBackColor = false;
            this.buttonSelect_Potvrdit.Click += new System.EventHandler(this.buttonSelect_Potvrdit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(44, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(596, 220);
            this.dataGridView1.TabIndex = 18;
            //this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            //this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            //this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // panelSelect_VGiew
            // 
            this.panelSelect_VGiew.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panelSelect_VGiew.Controls.Add(this.listBoxSelect_View);
            this.panelSelect_VGiew.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelSelect_VGiew.Location = new System.Drawing.Point(0, 350);
            this.panelSelect_VGiew.Name = "panelSelect_VGiew";
            this.panelSelect_VGiew.Size = new System.Drawing.Size(800, 100);
            this.panelSelect_VGiew.TabIndex = 19;
            // 
            // listBoxSelect_View
            // 
            this.listBoxSelect_View.FormattingEnabled = true;
            this.listBoxSelect_View.Location = new System.Drawing.Point(36, 18);
            this.listBoxSelect_View.Name = "listBoxSelect_View";
            this.listBoxSelect_View.Size = new System.Drawing.Size(600, 43);
            this.listBoxSelect_View.TabIndex = 0;
            // 
            // buttonZmen
            // 
            this.buttonZmen.Location = new System.Drawing.Point(257, 299);
            this.buttonZmen.Name = "buttonZmen";
            this.buttonZmen.Size = new System.Drawing.Size(75, 23);
            this.buttonZmen.TabIndex = 20;
            this.buttonZmen.Text = "Zmen";
            this.buttonZmen.UseVisualStyleBackColor = true;
            this.buttonZmen.Click += new System.EventHandler(this.buttonZmen_Click);
            // 
            // buttonVymaz
            // 
            this.buttonVymaz.Location = new System.Drawing.Point(359, 299);
            this.buttonVymaz.Name = "buttonVymaz";
            this.buttonVymaz.Size = new System.Drawing.Size(75, 23);
            this.buttonVymaz.TabIndex = 21;
            this.buttonVymaz.Text = "Vymaz";
            this.buttonVymaz.UseVisualStyleBackColor = true;
            this.buttonVymaz.Click += new System.EventHandler(this.buttonVymaz_Click);
            // 
            // buttonPridaj
            // 
            this.buttonPridaj.Location = new System.Drawing.Point(461, 298);
            this.buttonPridaj.Name = "buttonPridaj";
            this.buttonPridaj.Size = new System.Drawing.Size(75, 23);
            this.buttonPridaj.TabIndex = 22;
            this.buttonPridaj.Text = "Pridaj";
            this.buttonPridaj.UseVisualStyleBackColor = true;
            this.buttonPridaj.Click += new System.EventHandler(this.buttonPridaj_Click);
            // 
            // buttonZatvorit
            // 
            this.buttonZatvorit.Location = new System.Drawing.Point(565, 299);
            this.buttonZatvorit.Name = "buttonZatvorit";
            this.buttonZatvorit.Size = new System.Drawing.Size(75, 23);
            this.buttonZatvorit.TabIndex = 23;
            this.buttonZatvorit.Text = "Zatvorit";
            this.buttonZatvorit.UseVisualStyleBackColor = true;
            this.buttonZatvorit.Click += new System.EventHandler(this.buttonZatvorit_Click);
            // 
            // buttonNajdi
            // 
            this.buttonNajdi.Location = new System.Drawing.Point(160, 299);
            this.buttonNajdi.Name = "buttonNajdi";
            this.buttonNajdi.Size = new System.Drawing.Size(75, 23);
            this.buttonNajdi.TabIndex = 24;
            this.buttonNajdi.Text = "Najdi";
            this.buttonNajdi.UseVisualStyleBackColor = true;
            this.buttonNajdi.Click += new System.EventHandler(this.buttonNajdi_Click);
            // 
            // Evidencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonNajdi);
            this.Controls.Add(this.buttonZatvorit);
            this.Controls.Add(this.buttonPridaj);
            this.Controls.Add(this.buttonVymaz);
            this.Controls.Add(this.buttonZmen);
            this.Controls.Add(this.panelSelect_VGiew);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonSelect_Potvrdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Evidencia";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelSelect_VGiew.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonSelect_Potvrdit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panelSelect_VGiew;
        private System.Windows.Forms.ListBox listBoxSelect_View;
        private System.Windows.Forms.Button buttonZmen;
        private System.Windows.Forms.Button buttonVymaz;
        private System.Windows.Forms.Button buttonPridaj;
        private System.Windows.Forms.Button buttonZatvorit;
        private System.Windows.Forms.Button buttonNajdi;
    }
}