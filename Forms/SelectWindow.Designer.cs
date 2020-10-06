namespace Kros
{
    partial class SelectWindow
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
            this.comboBox_Condition0 = new System.Windows.Forms.ComboBox();
            this.labelPodmienky = new System.Windows.Forms.Label();
            this.labelOrderBy = new System.Windows.Forms.Label();
            this.comboBox_OrderBy = new System.Windows.Forms.ComboBox();
            this.buttonPotvrdit = new System.Windows.Forms.Button();
            this.buttonZatvorit = new System.Windows.Forms.Button();
            this.labelSposobVyhlad = new System.Windows.Forms.Label();
            this.comboBox_SelectView = new System.Windows.Forms.ComboBox();
            this.buttonAdd_cond = new System.Windows.Forms.Button();
            this.textBox_Condition0 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBox_Condition0
            // 
            this.comboBox_Condition0.FormattingEnabled = true;
            this.comboBox_Condition0.Location = new System.Drawing.Point(305, 80);
            this.comboBox_Condition0.Name = "comboBox_Condition0";
            this.comboBox_Condition0.Size = new System.Drawing.Size(120, 21);
            this.comboBox_Condition0.TabIndex = 1;
            // 
            // labelPodmienky
            // 
            this.labelPodmienky.AutoSize = true;
            this.labelPodmienky.Location = new System.Drawing.Point(305, 50);
            this.labelPodmienky.Name = "labelPodmienky";
            this.labelPodmienky.Size = new System.Drawing.Size(59, 13);
            this.labelPodmienky.TabIndex = 3;
            this.labelPodmienky.Text = "Podmienky";
            // 
            // labelOrderBy
            // 
            this.labelOrderBy.AutoSize = true;
            this.labelOrderBy.Location = new System.Drawing.Point(29, 80);
            this.labelOrderBy.Name = "labelOrderBy";
            this.labelOrderBy.Size = new System.Drawing.Size(70, 13);
            this.labelOrderBy.TabIndex = 6;
            this.labelOrderBy.Text = "Zoradit Podla";
            // 
            // comboBox_OrderBy
            // 
            this.comboBox_OrderBy.FormattingEnabled = true;
            this.comboBox_OrderBy.Location = new System.Drawing.Point(160, 80);
            this.comboBox_OrderBy.Name = "comboBox_OrderBy";
            this.comboBox_OrderBy.Size = new System.Drawing.Size(121, 21);
            this.comboBox_OrderBy.TabIndex = 7;
            // 
            // buttonPotvrdit
            // 
            this.buttonPotvrdit.Location = new System.Drawing.Point(44, 272);
            this.buttonPotvrdit.Name = "buttonPotvrdit";
            this.buttonPotvrdit.Size = new System.Drawing.Size(75, 23);
            this.buttonPotvrdit.TabIndex = 8;
            this.buttonPotvrdit.Text = "Potvrdit";
            this.buttonPotvrdit.UseVisualStyleBackColor = true;
            this.buttonPotvrdit.Click += new System.EventHandler(this.buttonPotvrdit_Click);
            // 
            // buttonZatvorit
            // 
            this.buttonZatvorit.Location = new System.Drawing.Point(185, 272);
            this.buttonZatvorit.Name = "buttonZatvorit";
            this.buttonZatvorit.Size = new System.Drawing.Size(75, 23);
            this.buttonZatvorit.TabIndex = 9;
            this.buttonZatvorit.Text = "Zatvorit";
            this.buttonZatvorit.UseVisualStyleBackColor = true;
            this.buttonZatvorit.Click += new System.EventHandler(this.buttonZatvorit_Click);
            // 
            // labelSposobVyhlad
            // 
            this.labelSposobVyhlad.AutoSize = true;
            this.labelSposobVyhlad.Location = new System.Drawing.Point(29, 125);
            this.labelSposobVyhlad.Name = "labelSposobVyhlad";
            this.labelSposobVyhlad.Size = new System.Drawing.Size(110, 13);
            this.labelSposobVyhlad.TabIndex = 10;
            this.labelSposobVyhlad.Text = "Sposob Vyhladavania";
            // 
            // comboBox_SelectView
            // 
            this.comboBox_SelectView.FormattingEnabled = true;
            this.comboBox_SelectView.Location = new System.Drawing.Point(160, 122);
            this.comboBox_SelectView.Name = "comboBox_SelectView";
            this.comboBox_SelectView.Size = new System.Drawing.Size(121, 21);
            this.comboBox_SelectView.TabIndex = 11;
            // 
            // buttonAdd_cond
            // 
            this.buttonAdd_cond.Location = new System.Drawing.Point(307, 272);
            this.buttonAdd_cond.Name = "buttonAdd_cond";
            this.buttonAdd_cond.Size = new System.Drawing.Size(97, 23);
            this.buttonAdd_cond.TabIndex = 15;
            this.buttonAdd_cond.Text = "Pridaj Podmienku";
            this.buttonAdd_cond.UseVisualStyleBackColor = true;
            this.buttonAdd_cond.Click += new System.EventHandler(this.buttonAdd_cond_Click);
            // 
            // textBox_Condition0
            // 
            this.textBox_Condition0.Location = new System.Drawing.Point(445, 80);
            this.textBox_Condition0.Name = "textBox_Condition0";
            this.textBox_Condition0.Size = new System.Drawing.Size(120, 20);
            this.textBox_Condition0.TabIndex = 16;
            // 
            // SelectWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(663, 435);
            this.Controls.Add(this.textBox_Condition0);
            this.Controls.Add(this.buttonAdd_cond);
            this.Controls.Add(this.comboBox_SelectView);
            this.Controls.Add(this.labelSposobVyhlad);
            this.Controls.Add(this.buttonZatvorit);
            this.Controls.Add(this.buttonPotvrdit);
            this.Controls.Add(this.comboBox_OrderBy);
            this.Controls.Add(this.labelOrderBy);
            this.Controls.Add(this.labelPodmienky);
            this.Controls.Add(this.comboBox_Condition0);
            this.Name = "SelectWindow";
            this.Text = "SelectWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox_Condition0;
        private System.Windows.Forms.Label labelPodmienky;
        private System.Windows.Forms.Label labelOrderBy;
        private System.Windows.Forms.ComboBox comboBox_OrderBy;
        private System.Windows.Forms.Button buttonPotvrdit;
        private System.Windows.Forms.Button buttonZatvorit;
        private System.Windows.Forms.Label labelSposobVyhlad;
        private System.Windows.Forms.ComboBox comboBox_SelectView;
        private System.Windows.Forms.Button buttonAdd_cond;
        private System.Windows.Forms.TextBox textBox_Condition0;
    }
}