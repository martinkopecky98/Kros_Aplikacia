namespace Kros.Forms
{
    partial class Prihlasenie
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
            this.labelMeno = new System.Windows.Forms.Label();
            this.labelHeslo = new System.Windows.Forms.Label();
            this.textBoxMeno = new System.Windows.Forms.TextBox();
            this.textBoxHeslo = new System.Windows.Forms.TextBox();
            this.buttonPotvrdit = new System.Windows.Forms.Button();
            this.buttonZatvorit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelMeno
            // 
            this.labelMeno.AutoSize = true;
            this.labelMeno.Location = new System.Drawing.Point(59, 79);
            this.labelMeno.Name = "labelMeno";
            this.labelMeno.Size = new System.Drawing.Size(34, 13);
            this.labelMeno.TabIndex = 0;
            this.labelMeno.Text = "Meno";
            // 
            // labelHeslo
            // 
            this.labelHeslo.AutoSize = true;
            this.labelHeslo.Location = new System.Drawing.Point(62, 125);
            this.labelHeslo.Name = "labelHeslo";
            this.labelHeslo.Size = new System.Drawing.Size(34, 13);
            this.labelHeslo.TabIndex = 1;
            this.labelHeslo.Text = "Heslo";
            // 
            // textBoxMeno
            // 
            this.textBoxMeno.Location = new System.Drawing.Point(156, 71);
            this.textBoxMeno.Name = "textBoxMeno";
            this.textBoxMeno.Size = new System.Drawing.Size(100, 20);
            this.textBoxMeno.TabIndex = 4;
            // 
            // textBoxHeslo
            // 
            this.textBoxHeslo.Location = new System.Drawing.Point(156, 117);
            this.textBoxHeslo.Name = "textBoxHeslo";
            this.textBoxHeslo.Size = new System.Drawing.Size(100, 20);
            this.textBoxHeslo.TabIndex = 5;
            // 
            // buttonPotvrdit
            // 
            this.buttonPotvrdit.Location = new System.Drawing.Point(62, 181);
            this.buttonPotvrdit.Name = "buttonPotvrdit";
            this.buttonPotvrdit.Size = new System.Drawing.Size(75, 23);
            this.buttonPotvrdit.TabIndex = 6;
            this.buttonPotvrdit.Text = "Potvrdit";
            this.buttonPotvrdit.UseVisualStyleBackColor = true;
            this.buttonPotvrdit.Click += new System.EventHandler(this.buttonPotvrdit_Click);
            // 
            // buttonZatvorit
            // 
            this.buttonZatvorit.Location = new System.Drawing.Point(194, 181);
            this.buttonZatvorit.Name = "buttonZatvorit";
            this.buttonZatvorit.Size = new System.Drawing.Size(75, 23);
            this.buttonZatvorit.TabIndex = 7;
            this.buttonZatvorit.Text = "Zatvorit";
            this.buttonZatvorit.UseVisualStyleBackColor = true;
            this.buttonZatvorit.Click += new System.EventHandler(this.buttonZatvorit_Click);
            // 
            // Prihlasenie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(350, 346);
            this.Controls.Add(this.buttonZatvorit);
            this.Controls.Add(this.buttonPotvrdit);
            this.Controls.Add(this.textBoxHeslo);
            this.Controls.Add(this.textBoxMeno);
            this.Controls.Add(this.labelHeslo);
            this.Controls.Add(this.labelMeno);
            this.Name = "Prihlasenie";
            this.Text = "Prihlasenie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMeno;
        private System.Windows.Forms.Label labelHeslo;
        private System.Windows.Forms.TextBox textBoxMeno;
        private System.Windows.Forms.TextBox textBoxHeslo;
        private System.Windows.Forms.Button buttonPotvrdit;
        private System.Windows.Forms.Button buttonZatvorit;
    }
}