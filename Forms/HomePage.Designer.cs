namespace Kros
{
    partial class HomePage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelMoznostiSubMenu = new System.Windows.Forms.Panel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonLogOff = new System.Windows.Forms.Button();
            this.buttonOptions = new System.Windows.Forms.Button();
            this.panelDatabazaSubMenu = new System.Windows.Forms.Panel();
            this.buttonSaveBackup = new System.Windows.Forms.Button();
            this.buttonLog = new System.Windows.Forms.Button();
            this.h = new System.Windows.Forms.Button();
            this.buttonDeleteData = new System.Windows.Forms.Button();
            this.buttonDatabaza = new System.Windows.Forms.Button();
            this.panelPrikazySubMenu = new System.Windows.Forms.Panel();
            this.buttonFirma = new System.Windows.Forms.Button();
            this.buttonDivizia = new System.Windows.Forms.Button();
            this.buttonProjekty = new System.Windows.Forms.Button();
            this.buttonOddelenia = new System.Windows.Forms.Button();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.buttonPrikazy = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panelHome_Page = new System.Windows.Forms.Panel();
            this.listBoxHomePage = new System.Windows.Forms.ListBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.buttonRozsirene = new System.Windows.Forms.Button();
            this.buttonZaradenie = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelMoznostiSubMenu.SuspendLayout();
            this.panelDatabazaSubMenu.SuspendLayout();
            this.panelPrikazySubMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelChildForm.SuspendLayout();
            this.panelHome_Page.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.panelMoznostiSubMenu);
            this.panel1.Controls.Add(this.buttonOptions);
            this.panel1.Controls.Add(this.panelDatabazaSubMenu);
            this.panel1.Controls.Add(this.buttonDatabaza);
            this.panel1.Controls.Add(this.panelPrikazySubMenu);
            this.panel1.Controls.Add(this.buttonPrikazy);
            this.panel1.Controls.Add(this.panelLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(155, 488);
            this.panel1.TabIndex = 0;
            // 
            // panelMoznostiSubMenu
            // 
            this.panelMoznostiSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelMoznostiSubMenu.Controls.Add(this.buttonRozsirene);
            this.panelMoznostiSubMenu.Controls.Add(this.buttonClose);
            this.panelMoznostiSubMenu.Controls.Add(this.buttonLogOff);
            this.panelMoznostiSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMoznostiSubMenu.Location = new System.Drawing.Point(0, 727);
            this.panelMoznostiSubMenu.Name = "panelMoznostiSubMenu";
            this.panelMoznostiSubMenu.Size = new System.Drawing.Size(138, 135);
            this.panelMoznostiSubMenu.TabIndex = 6;
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonClose.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Location = new System.Drawing.Point(0, 45);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonClose.Size = new System.Drawing.Size(138, 45);
            this.buttonClose.TabIndex = 2;
            this.buttonClose.Text = "Ukoncit";
            this.buttonClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonLogOff
            // 
            this.buttonLogOff.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonLogOff.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonLogOff.FlatAppearance.BorderSize = 0;
            this.buttonLogOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogOff.Location = new System.Drawing.Point(0, 0);
            this.buttonLogOff.Name = "buttonLogOff";
            this.buttonLogOff.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonLogOff.Size = new System.Drawing.Size(138, 45);
            this.buttonLogOff.TabIndex = 0;
            this.buttonLogOff.Text = "Odhlasit sa";
            this.buttonLogOff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLogOff.UseVisualStyleBackColor = false;
            this.buttonLogOff.Click += new System.EventHandler(this.buttonLogOff_Click);
            // 
            // buttonOptions
            // 
            this.buttonOptions.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonOptions.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonOptions.FlatAppearance.BorderSize = 0;
            this.buttonOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOptions.Location = new System.Drawing.Point(0, 682);
            this.buttonOptions.Name = "buttonOptions";
            this.buttonOptions.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.buttonOptions.Size = new System.Drawing.Size(138, 45);
            this.buttonOptions.TabIndex = 5;
            this.buttonOptions.Text = "Moznosti";
            this.buttonOptions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOptions.UseVisualStyleBackColor = false;
            this.buttonOptions.Click += new System.EventHandler(this.buttonOptions_Click);
            // 
            // panelDatabazaSubMenu
            // 
            this.panelDatabazaSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelDatabazaSubMenu.Controls.Add(this.buttonSaveBackup);
            this.panelDatabazaSubMenu.Controls.Add(this.buttonLog);
            this.panelDatabazaSubMenu.Controls.Add(this.h);
            this.panelDatabazaSubMenu.Controls.Add(this.buttonDeleteData);
            this.panelDatabazaSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDatabazaSubMenu.Location = new System.Drawing.Point(0, 502);
            this.panelDatabazaSubMenu.Name = "panelDatabazaSubMenu";
            this.panelDatabazaSubMenu.Size = new System.Drawing.Size(138, 180);
            this.panelDatabazaSubMenu.TabIndex = 4;
            // 
            // buttonSaveBackup
            // 
            this.buttonSaveBackup.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonSaveBackup.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSaveBackup.FlatAppearance.BorderSize = 0;
            this.buttonSaveBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveBackup.Location = new System.Drawing.Point(0, 135);
            this.buttonSaveBackup.Name = "buttonSaveBackup";
            this.buttonSaveBackup.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonSaveBackup.Size = new System.Drawing.Size(138, 45);
            this.buttonSaveBackup.TabIndex = 4;
            this.buttonSaveBackup.Text = "Uloz Zalohu";
            this.buttonSaveBackup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSaveBackup.UseVisualStyleBackColor = false;
            this.buttonSaveBackup.Click += new System.EventHandler(this.buttonSaveBackup_Click);
            // 
            // buttonLog
            // 
            this.buttonLog.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonLog.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonLog.FlatAppearance.BorderSize = 0;
            this.buttonLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLog.Location = new System.Drawing.Point(0, 90);
            this.buttonLog.Name = "buttonLog";
            this.buttonLog.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonLog.Size = new System.Drawing.Size(138, 45);
            this.buttonLog.TabIndex = 3;
            this.buttonLog.Text = "Evidencia Prihlaseni";
            this.buttonLog.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLog.UseVisualStyleBackColor = false;
            this.buttonLog.Click += new System.EventHandler(this.buttonLog_Click);
            // 
            // h
            // 
            this.h.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.h.Dock = System.Windows.Forms.DockStyle.Top;
            this.h.FlatAppearance.BorderSize = 0;
            this.h.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.h.Location = new System.Drawing.Point(0, 45);
            this.h.Name = "h";
            this.h.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.h.Size = new System.Drawing.Size(138, 45);
            this.h.TabIndex = 2;
            this.h.Text = "Nacitaj Backup";
            this.h.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.h.UseVisualStyleBackColor = false;
            this.h.Click += new System.EventHandler(this.buttonBackup_Click);
            // 
            // buttonDeleteData
            // 
            this.buttonDeleteData.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonDeleteData.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDeleteData.FlatAppearance.BorderSize = 0;
            this.buttonDeleteData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteData.Location = new System.Drawing.Point(0, 0);
            this.buttonDeleteData.Name = "buttonDeleteData";
            this.buttonDeleteData.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonDeleteData.Size = new System.Drawing.Size(138, 45);
            this.buttonDeleteData.TabIndex = 0;
            this.buttonDeleteData.Text = "Vymaz Databazu";
            this.buttonDeleteData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDeleteData.UseVisualStyleBackColor = false;
            this.buttonDeleteData.Click += new System.EventHandler(this.buttonDeleteData_Click);
            // 
            // buttonDatabaza
            // 
            this.buttonDatabaza.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonDatabaza.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonDatabaza.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDatabaza.FlatAppearance.BorderSize = 0;
            this.buttonDatabaza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDatabaza.Location = new System.Drawing.Point(0, 457);
            this.buttonDatabaza.Name = "buttonDatabaza";
            this.buttonDatabaza.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.buttonDatabaza.Size = new System.Drawing.Size(138, 45);
            this.buttonDatabaza.TabIndex = 3;
            this.buttonDatabaza.Text = "Databaza";
            this.buttonDatabaza.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDatabaza.UseVisualStyleBackColor = false;
            this.buttonDatabaza.Click += new System.EventHandler(this.buttonDatabaza_Click);
            // 
            // panelPrikazySubMenu
            // 
            this.panelPrikazySubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelPrikazySubMenu.Controls.Add(this.buttonZaradenie);
            this.panelPrikazySubMenu.Controls.Add(this.buttonFirma);
            this.panelPrikazySubMenu.Controls.Add(this.buttonDivizia);
            this.panelPrikazySubMenu.Controls.Add(this.buttonProjekty);
            this.panelPrikazySubMenu.Controls.Add(this.buttonOddelenia);
            this.panelPrikazySubMenu.Controls.Add(this.buttonSelect);
            this.panelPrikazySubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPrikazySubMenu.Location = new System.Drawing.Point(0, 178);
            this.panelPrikazySubMenu.Name = "panelPrikazySubMenu";
            this.panelPrikazySubMenu.Size = new System.Drawing.Size(138, 279);
            this.panelPrikazySubMenu.TabIndex = 2;
            // 
            // buttonFirma
            // 
            this.buttonFirma.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonFirma.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonFirma.FlatAppearance.BorderSize = 0;
            this.buttonFirma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFirma.Location = new System.Drawing.Point(0, 180);
            this.buttonFirma.Name = "buttonFirma";
            this.buttonFirma.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonFirma.Size = new System.Drawing.Size(138, 45);
            this.buttonFirma.TabIndex = 5;
            this.buttonFirma.Text = "Evidencia Firiem";
            this.buttonFirma.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFirma.UseVisualStyleBackColor = false;
            this.buttonFirma.Click += new System.EventHandler(this.buttonFirma_Click);
            // 
            // buttonDivizia
            // 
            this.buttonDivizia.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonDivizia.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDivizia.FlatAppearance.BorderSize = 0;
            this.buttonDivizia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDivizia.Location = new System.Drawing.Point(0, 135);
            this.buttonDivizia.Name = "buttonDivizia";
            this.buttonDivizia.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonDivizia.Size = new System.Drawing.Size(138, 45);
            this.buttonDivizia.TabIndex = 4;
            this.buttonDivizia.Text = "Evidencia Diviz";
            this.buttonDivizia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDivizia.UseVisualStyleBackColor = false;
            this.buttonDivizia.Click += new System.EventHandler(this.buttonDivizia_Click);
            // 
            // buttonProjekty
            // 
            this.buttonProjekty.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonProjekty.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonProjekty.FlatAppearance.BorderSize = 0;
            this.buttonProjekty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProjekty.Location = new System.Drawing.Point(0, 90);
            this.buttonProjekty.Name = "buttonProjekty";
            this.buttonProjekty.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonProjekty.Size = new System.Drawing.Size(138, 45);
            this.buttonProjekty.TabIndex = 2;
            this.buttonProjekty.Text = "Evidencia Projektov";
            this.buttonProjekty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonProjekty.UseVisualStyleBackColor = false;
            this.buttonProjekty.Click += new System.EventHandler(this.buttonProjekty_Click);
            // 
            // buttonOddelenia
            // 
            this.buttonOddelenia.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonOddelenia.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonOddelenia.FlatAppearance.BorderSize = 0;
            this.buttonOddelenia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOddelenia.Location = new System.Drawing.Point(0, 45);
            this.buttonOddelenia.Name = "buttonOddelenia";
            this.buttonOddelenia.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonOddelenia.Size = new System.Drawing.Size(138, 45);
            this.buttonOddelenia.TabIndex = 1;
            this.buttonOddelenia.Text = "Evidencia Oddeleni";
            this.buttonOddelenia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOddelenia.UseVisualStyleBackColor = false;
            this.buttonOddelenia.Click += new System.EventHandler(this.buttonOddelenia_Click);
            // 
            // buttonSelect
            // 
            this.buttonSelect.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonSelect.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSelect.FlatAppearance.BorderSize = 0;
            this.buttonSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelect.Location = new System.Drawing.Point(0, 0);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonSelect.Size = new System.Drawing.Size(138, 45);
            this.buttonSelect.TabIndex = 0;
            this.buttonSelect.Text = "Evidencia Zamestnancov";
            this.buttonSelect.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSelect.UseVisualStyleBackColor = false;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // buttonPrikazy
            // 
            this.buttonPrikazy.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonPrikazy.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonPrikazy.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPrikazy.FlatAppearance.BorderSize = 0;
            this.buttonPrikazy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrikazy.Location = new System.Drawing.Point(0, 133);
            this.buttonPrikazy.Name = "buttonPrikazy";
            this.buttonPrikazy.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.buttonPrikazy.Size = new System.Drawing.Size(138, 45);
            this.buttonPrikazy.TabIndex = 1;
            this.buttonPrikazy.Text = "Evidencie";
            this.buttonPrikazy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPrikazy.UseVisualStyleBackColor = false;
            this.buttonPrikazy.Click += new System.EventHandler(this.buttonPrikazy_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(138, 133);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 133);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.SkyBlue;
            this.panelChildForm.Controls.Add(this.panelHome_Page);
            this.panelChildForm.Controls.Add(this.flowLayoutPanel1);
            this.panelChildForm.Controls.Add(this.pictureBox2);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(155, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(779, 488);
            this.panelChildForm.TabIndex = 2;
            // 
            // panelHome_Page
            // 
            this.panelHome_Page.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panelHome_Page.Controls.Add(this.listBoxHomePage);
            this.panelHome_Page.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelHome_Page.Location = new System.Drawing.Point(0, 392);
            this.panelHome_Page.Name = "panelHome_Page";
            this.panelHome_Page.Size = new System.Drawing.Size(779, 96);
            this.panelHome_Page.TabIndex = 2;
            // 
            // listBoxHomePage
            // 
            this.listBoxHomePage.FormattingEnabled = true;
            this.listBoxHomePage.Location = new System.Drawing.Point(91, 18);
            this.listBoxHomePage.Name = "listBoxHomePage";
            this.listBoxHomePage.Size = new System.Drawing.Size(600, 43);
            this.listBoxHomePage.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(778, 79);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(156, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(370, 355);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // buttonRozsirene
            // 
            this.buttonRozsirene.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonRozsirene.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonRozsirene.FlatAppearance.BorderSize = 0;
            this.buttonRozsirene.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRozsirene.Location = new System.Drawing.Point(0, 90);
            this.buttonRozsirene.Name = "buttonRozsirene";
            this.buttonRozsirene.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonRozsirene.Size = new System.Drawing.Size(138, 45);
            this.buttonRozsirene.TabIndex = 7;
            this.buttonRozsirene.Text = "Rozsirene Moznosti";
            this.buttonRozsirene.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRozsirene.UseVisualStyleBackColor = false;
            this.buttonRozsirene.Click += new System.EventHandler(this.buttonRozsirene_Click);
            // 
            // buttonZaradenie
            // 
            this.buttonZaradenie.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonZaradenie.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonZaradenie.FlatAppearance.BorderSize = 0;
            this.buttonZaradenie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZaradenie.Location = new System.Drawing.Point(0, 225);
            this.buttonZaradenie.Name = "buttonZaradenie";
            this.buttonZaradenie.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonZaradenie.Size = new System.Drawing.Size(138, 54);
            this.buttonZaradenie.TabIndex = 6;
            this.buttonZaradenie.Text = "Evidencia Zaradeni Zamestnancov";
            this.buttonZaradenie.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonZaradenie.UseVisualStyleBackColor = false;
            this.buttonZaradenie.Click += new System.EventHandler(this.buttonZaradenie_Click);
            // 
            // HomePage
            // 
            this.ClientSize = new System.Drawing.Size(934, 488);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(700, 350);
            this.Name = "HomePage";
            this.panel1.ResumeLayout(false);
            this.panelMoznostiSubMenu.ResumeLayout(false);
            this.panelDatabazaSubMenu.ResumeLayout(false);
            this.panelPrikazySubMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelChildForm.ResumeLayout(false);
            this.panelHome_Page.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelPrikazySubMenu;
        private System.Windows.Forms.Button buttonPrikazy;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelMoznostiSubMenu;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonLogOff;
        private System.Windows.Forms.Button buttonOptions;
        private System.Windows.Forms.Panel panelDatabazaSubMenu;
        private System.Windows.Forms.Button h;
        private System.Windows.Forms.Button buttonDeleteData;
        private System.Windows.Forms.Button buttonDatabaza;
        private System.Windows.Forms.Button buttonProjekty;
        private System.Windows.Forms.Button buttonOddelenia;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Panel panelHome_Page;
        private System.Windows.Forms.ListBox listBoxHomePage;
        private System.Windows.Forms.Button buttonLog;
        private System.Windows.Forms.Button buttonSaveBackup;
        private System.Windows.Forms.Button buttonFirma;
        private System.Windows.Forms.Button buttonDivizia;
        private System.Windows.Forms.Button buttonRozsirene;
        private System.Windows.Forms.Button buttonZaradenie;
    }
}

