namespace Kros.Forms
{
    partial class ZmenaWindow
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
            this.buttonPotvrdit = new System.Windows.Forms.Button();
            this.buttonZatvorit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonPotvrdit
            // 
            this.buttonPotvrdit.Location = new System.Drawing.Point(350, 54);
            this.buttonPotvrdit.Name = "buttonPotvrdit";
            this.buttonPotvrdit.Size = new System.Drawing.Size(75, 23);
            this.buttonPotvrdit.TabIndex = 0;
            this.buttonPotvrdit.Text = "Potvrdit";
            this.buttonPotvrdit.UseVisualStyleBackColor = true;
            this.buttonPotvrdit.Click += new System.EventHandler(this.buttonPotvrdit_Click);
            // 
            // buttonZatvorit
            // 
            this.buttonZatvorit.Location = new System.Drawing.Point(350, 121);
            this.buttonZatvorit.Name = "buttonZatvorit";
            this.buttonZatvorit.Size = new System.Drawing.Size(75, 23);
            this.buttonZatvorit.TabIndex = 1;
            this.buttonZatvorit.Text = "Zatvorit";
            this.buttonZatvorit.UseVisualStyleBackColor = true;
            this.buttonZatvorit.Click += new System.EventHandler(this.buttonZatvorit_Click);
            // 
            // ZmenaWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(465, 282);
            this.Controls.Add(this.buttonZatvorit);
            this.Controls.Add(this.buttonPotvrdit);
            this.Name = "ZmenaWindow";
            this.Text = "ZmenaWindov";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPotvrdit;
        private System.Windows.Forms.Button buttonZatvorit;
    }
}