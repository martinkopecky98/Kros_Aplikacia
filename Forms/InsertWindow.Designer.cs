namespace Kros
{
    partial class InsertWindow
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
            this.labelImport = new System.Windows.Forms.Label();
            this.labelImport_FName = new System.Windows.Forms.Label();
            this.labelImport_LNaame = new System.Windows.Forms.Label();
            this.labelImport_Age = new System.Windows.Forms.Label();
            this.textBoxMeno = new System.Windows.Forms.TextBox();
            this.textBoxPriezvisko = new System.Windows.Forms.TextBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.buttonPotvrdit = new System.Windows.Forms.Button();
            this.buttonZatvorit = new System.Windows.Forms.Button();
            this.labelZaradenie = new System.Windows.Forms.Label();
            this.textBoxZaradenie = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelImport
            // 
            this.labelImport.AutoSize = true;
            this.labelImport.Location = new System.Drawing.Point(264, 13);
            this.labelImport.Name = "labelImport";
            this.labelImport.Size = new System.Drawing.Size(92, 13);
            this.labelImport.TabIndex = 0;
            this.labelImport.Text = "Pridavanie (Insert)";
            this.labelImport.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelImport_FName
            // 
            this.labelImport_FName.AutoSize = true;
            this.labelImport_FName.Location = new System.Drawing.Point(48, 73);
            this.labelImport_FName.Name = "labelImport_FName";
            this.labelImport_FName.Size = new System.Drawing.Size(34, 13);
            this.labelImport_FName.TabIndex = 1;
            this.labelImport_FName.Text = "Meno";
            // 
            // labelImport_LNaame
            // 
            this.labelImport_LNaame.AutoSize = true;
            this.labelImport_LNaame.Location = new System.Drawing.Point(48, 102);
            this.labelImport_LNaame.Name = "labelImport_LNaame";
            this.labelImport_LNaame.Size = new System.Drawing.Size(55, 13);
            this.labelImport_LNaame.TabIndex = 2;
            this.labelImport_LNaame.Text = "Priezvisko";
            // 
            // labelImport_Age
            // 
            this.labelImport_Age.AutoSize = true;
            this.labelImport_Age.Location = new System.Drawing.Point(48, 135);
            this.labelImport_Age.Name = "labelImport_Age";
            this.labelImport_Age.Size = new System.Drawing.Size(26, 13);
            this.labelImport_Age.TabIndex = 3;
            this.labelImport_Age.Text = "Vek";
            // 
            // textBoxMeno
            // 
            this.textBoxMeno.Location = new System.Drawing.Point(190, 65);
            this.textBoxMeno.Name = "textBoxMeno";
            this.textBoxMeno.Size = new System.Drawing.Size(100, 20);
            this.textBoxMeno.TabIndex = 4;
            // 
            // textBoxPriezvisko
            // 
            this.textBoxPriezvisko.Location = new System.Drawing.Point(190, 94);
            this.textBoxPriezvisko.Name = "textBoxPriezvisko";
            this.textBoxPriezvisko.Size = new System.Drawing.Size(100, 20);
            this.textBoxPriezvisko.TabIndex = 5;
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(190, 128);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(100, 20);
            this.textBoxAge.TabIndex = 6;
            // 
            // buttonPotvrdit
            // 
            this.buttonPotvrdit.Location = new System.Drawing.Point(51, 265);
            this.buttonPotvrdit.Name = "buttonPotvrdit";
            this.buttonPotvrdit.Size = new System.Drawing.Size(75, 23);
            this.buttonPotvrdit.TabIndex = 7;
            this.buttonPotvrdit.Text = "Potvrdit";
            this.buttonPotvrdit.UseVisualStyleBackColor = true;
            this.buttonPotvrdit.Click += new System.EventHandler(this.buttonPotvrdit_Click);
            // 
            // buttonZatvorit
            // 
            this.buttonZatvorit.Location = new System.Drawing.Point(190, 265);
            this.buttonZatvorit.Name = "buttonZatvorit";
            this.buttonZatvorit.Size = new System.Drawing.Size(75, 23);
            this.buttonZatvorit.TabIndex = 8;
            this.buttonZatvorit.Text = "Zatvorit";
            this.buttonZatvorit.UseVisualStyleBackColor = true;
            this.buttonZatvorit.Click += new System.EventHandler(this.buttonZatvorit_Click);
            // 
            // labelZaradenie
            // 
            this.labelZaradenie.AutoSize = true;
            this.labelZaradenie.Location = new System.Drawing.Point(51, 163);
            this.labelZaradenie.Name = "labelZaradenie";
            this.labelZaradenie.Size = new System.Drawing.Size(55, 13);
            this.labelZaradenie.TabIndex = 9;
            this.labelZaradenie.Text = "Zaradenie";
            // 
            // textBoxZaradenie
            // 
            this.textBoxZaradenie.Location = new System.Drawing.Point(190, 163);
            this.textBoxZaradenie.Name = "textBoxZaradenie";
            this.textBoxZaradenie.Size = new System.Drawing.Size(100, 20);
            this.textBoxZaradenie.TabIndex = 10;
            // 
            // InsertWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(465, 354);
            this.Controls.Add(this.textBoxZaradenie);
            this.Controls.Add(this.labelZaradenie);
            this.Controls.Add(this.buttonZatvorit);
            this.Controls.Add(this.buttonPotvrdit);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.textBoxPriezvisko);
            this.Controls.Add(this.textBoxMeno);
            this.Controls.Add(this.labelImport_Age);
            this.Controls.Add(this.labelImport_LNaame);
            this.Controls.Add(this.labelImport_FName);
            this.Controls.Add(this.labelImport);
            this.Name = "InsertWindow";
            this.Text = "InsertWindow";
            //this.Load += new System.EventHandler(this.InsertWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelImport;
        private System.Windows.Forms.Label labelImport_FName;
        private System.Windows.Forms.Label labelImport_LNaame;
        private System.Windows.Forms.Label labelImport_Age;
        private System.Windows.Forms.TextBox textBoxMeno;
        private System.Windows.Forms.TextBox textBoxPriezvisko;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.Button buttonPotvrdit;
        private System.Windows.Forms.Button buttonZatvorit;
        private System.Windows.Forms.Label labelZaradenie;
        private System.Windows.Forms.TextBox textBoxZaradenie;
    }
}