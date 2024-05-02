namespace Admin
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbDateTime = new System.Windows.Forms.Label();
            this.bntExit = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tpSekcije = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvPregledSekcija = new System.Windows.Forms.DataGridView();
            this.idSekcije = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojClanova = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbBrojClanova = new System.Windows.Forms.TextBox();
            this.lbBrojClanova = new System.Windows.Forms.Label();
            this.tbNazivSekcije = new System.Windows.Forms.TextBox();
            this.lbNazivSekcije = new System.Windows.Forms.Label();
            this.tbPretraga = new System.Windows.Forms.TextBox();
            this.lbPretraga = new System.Windows.Forms.Label();
            this.btnDeleteSection = new System.Windows.Forms.Button();
            this.btnEditSection = new System.Windows.Forms.Button();
            this.btnAddSection = new System.Windows.Forms.Button();
            this.tpPregledClanova = new System.Windows.Forms.TabPage();
            this.dgvPregledClanova = new System.Windows.Forms.DataGridView();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.btnPrikazOruzja = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKalendarLova = new System.Windows.Forms.Button();
            this.btnAddMembershipCard = new System.Windows.Forms.Button();
            this.btnShowRecords = new System.Windows.Forms.Button();
            this.btnRecord = new System.Windows.Forms.Button();
            this.btnAddArmedSheet = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnDeleteMember = new System.Windows.Forms.Button();
            this.btnEditMember = new System.Windows.Forms.Button();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpObavjestenja = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnSaveNotification = new System.Windows.Forms.Button();
            this.rtbShowNotification = new System.Windows.Forms.RichTextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnDeleteNotification = new System.Windows.Forms.Button();
            this.btnEditNotification = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.jmb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojLK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sekcija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.tpSekcije.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregledSekcija)).BeginInit();
            this.panel2.SuspendLayout();
            this.tpPregledClanova.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregledClanova)).BeginInit();
            this.pnlContainer.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpObavjestenja.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.lbDateTime);
            this.panel1.Controls.Add(this.bntExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 477);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1172, 50);
            this.panel1.TabIndex = 0;
            // 
            // lbDateTime
            // 
            this.lbDateTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateTime.Location = new System.Drawing.Point(12, 12);
            this.lbDateTime.Name = "lbDateTime";
            this.lbDateTime.Size = new System.Drawing.Size(178, 30);
            this.lbDateTime.TabIndex = 1;
            this.lbDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bntExit
            // 
            this.bntExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bntExit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bntExit.FlatAppearance.BorderSize = 2;
            this.bntExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.bntExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntExit.Location = new System.Drawing.Point(987, 3);
            this.bntExit.Name = "bntExit";
            this.bntExit.Size = new System.Drawing.Size(181, 41);
            this.bntExit.TabIndex = 0;
            this.bntExit.Text = "Izađi";
            this.bntExit.UseVisualStyleBackColor = true;
            this.bntExit.Click += new System.EventHandler(this.bntExit_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tpSekcije
            // 
            this.tpSekcije.Controls.Add(this.panel3);
            this.tpSekcije.Controls.Add(this.panel2);
            this.tpSekcije.Location = new System.Drawing.Point(4, 22);
            this.tpSekcije.Name = "tpSekcije";
            this.tpSekcije.Padding = new System.Windows.Forms.Padding(3);
            this.tpSekcije.Size = new System.Drawing.Size(1164, 451);
            this.tpSekcije.TabIndex = 1;
            this.tpSekcije.Text = "Sekcije";
            this.tpSekcije.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvPregledSekcija);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(815, 445);
            this.panel3.TabIndex = 2;
            // 
            // dgvPregledSekcija
            // 
            this.dgvPregledSekcija.AllowUserToAddRows = false;
            this.dgvPregledSekcija.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPregledSekcija.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPregledSekcija.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idSekcije,
            this.naziv,
            this.brojClanova});
            this.dgvPregledSekcija.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPregledSekcija.Location = new System.Drawing.Point(0, 0);
            this.dgvPregledSekcija.MultiSelect = false;
            this.dgvPregledSekcija.Name = "dgvPregledSekcija";
            this.dgvPregledSekcija.Size = new System.Drawing.Size(815, 445);
            this.dgvPregledSekcija.TabIndex = 8;
            // 
            // idSekcije
            // 
            this.idSekcije.HeaderText = "Id sekcije";
            this.idSekcije.Name = "idSekcije";
            // 
            // naziv
            // 
            this.naziv.HeaderText = "Naziv";
            this.naziv.Name = "naziv";
            // 
            // brojClanova
            // 
            this.brojClanova.HeaderText = "Broj članova";
            this.brojClanova.Name = "brojClanova";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.tbBrojClanova);
            this.panel2.Controls.Add(this.lbBrojClanova);
            this.panel2.Controls.Add(this.tbNazivSekcije);
            this.panel2.Controls.Add(this.lbNazivSekcije);
            this.panel2.Controls.Add(this.tbPretraga);
            this.panel2.Controls.Add(this.lbPretraga);
            this.panel2.Controls.Add(this.btnDeleteSection);
            this.panel2.Controls.Add(this.btnEditSection);
            this.panel2.Controls.Add(this.btnAddSection);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(818, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(343, 445);
            this.panel2.TabIndex = 1;
            // 
            // tbBrojClanova
            // 
            this.tbBrojClanova.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBrojClanova.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBrojClanova.Location = new System.Drawing.Point(113, 146);
            this.tbBrojClanova.MaxLength = 13;
            this.tbBrojClanova.Name = "tbBrojClanova";
            this.tbBrojClanova.Size = new System.Drawing.Size(227, 26);
            this.tbBrojClanova.TabIndex = 12;
            // 
            // lbBrojClanova
            // 
            this.lbBrojClanova.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbBrojClanova.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBrojClanova.Location = new System.Drawing.Point(1, 146);
            this.lbBrojClanova.Name = "lbBrojClanova";
            this.lbBrojClanova.Size = new System.Drawing.Size(106, 23);
            this.lbBrojClanova.TabIndex = 13;
            this.lbBrojClanova.Text = "Broj članova";
            this.lbBrojClanova.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbNazivSekcije
            // 
            this.tbNazivSekcije.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNazivSekcije.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNazivSekcije.Location = new System.Drawing.Point(113, 105);
            this.tbNazivSekcije.MaxLength = 50;
            this.tbNazivSekcije.Name = "tbNazivSekcije";
            this.tbNazivSekcije.Size = new System.Drawing.Size(227, 26);
            this.tbNazivSekcije.TabIndex = 10;
            // 
            // lbNazivSekcije
            // 
            this.lbNazivSekcije.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNazivSekcije.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNazivSekcije.Location = new System.Drawing.Point(1, 107);
            this.lbNazivSekcije.Name = "lbNazivSekcije";
            this.lbNazivSekcije.Size = new System.Drawing.Size(106, 23);
            this.lbNazivSekcije.TabIndex = 11;
            this.lbNazivSekcije.Text = "Naziv";
            this.lbNazivSekcije.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbPretraga
            // 
            this.tbPretraga.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPretraga.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPretraga.Location = new System.Drawing.Point(113, 42);
            this.tbPretraga.MaxLength = 13;
            this.tbPretraga.Name = "tbPretraga";
            this.tbPretraga.Size = new System.Drawing.Size(225, 23);
            this.tbPretraga.TabIndex = 0;
            this.tbPretraga.TextChanged += new System.EventHandler(this.tbPretraga_TextChanged);
            // 
            // lbPretraga
            // 
            this.lbPretraga.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPretraga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPretraga.Location = new System.Drawing.Point(6, 42);
            this.lbPretraga.Name = "lbPretraga";
            this.lbPretraga.Size = new System.Drawing.Size(90, 23);
            this.lbPretraga.TabIndex = 9;
            this.lbPretraga.Text = "Pretraga";
            this.lbPretraga.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDeleteSection
            // 
            this.btnDeleteSection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteSection.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnDeleteSection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSection.Location = new System.Drawing.Point(127, 272);
            this.btnDeleteSection.Name = "btnDeleteSection";
            this.btnDeleteSection.Size = new System.Drawing.Size(176, 32);
            this.btnDeleteSection.TabIndex = 6;
            this.btnDeleteSection.Text = "Obriši";
            this.btnDeleteSection.UseVisualStyleBackColor = true;
            this.btnDeleteSection.Click += new System.EventHandler(this.btnDeleteSection_Click);
            // 
            // btnEditSection
            // 
            this.btnEditSection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditSection.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnEditSection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditSection.Location = new System.Drawing.Point(127, 234);
            this.btnEditSection.Name = "btnEditSection";
            this.btnEditSection.Size = new System.Drawing.Size(176, 32);
            this.btnEditSection.TabIndex = 5;
            this.btnEditSection.Text = "Izmjeni";
            this.btnEditSection.UseVisualStyleBackColor = true;
            this.btnEditSection.Click += new System.EventHandler(this.btnEditSection_Click);
            // 
            // btnAddSection
            // 
            this.btnAddSection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddSection.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnAddSection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSection.Location = new System.Drawing.Point(127, 196);
            this.btnAddSection.Name = "btnAddSection";
            this.btnAddSection.Size = new System.Drawing.Size(176, 32);
            this.btnAddSection.TabIndex = 4;
            this.btnAddSection.Text = "Dodaj";
            this.btnAddSection.UseVisualStyleBackColor = true;
            this.btnAddSection.Click += new System.EventHandler(this.btnAddSection_Click);
            // 
            // tpPregledClanova
            // 
            this.tpPregledClanova.Controls.Add(this.dgvPregledClanova);
            this.tpPregledClanova.Controls.Add(this.pnlContainer);
            this.tpPregledClanova.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpPregledClanova.Location = new System.Drawing.Point(4, 22);
            this.tpPregledClanova.Name = "tpPregledClanova";
            this.tpPregledClanova.Padding = new System.Windows.Forms.Padding(3);
            this.tpPregledClanova.Size = new System.Drawing.Size(1164, 451);
            this.tpPregledClanova.TabIndex = 0;
            this.tpPregledClanova.Text = "Pregled članova";
            this.tpPregledClanova.UseVisualStyleBackColor = true;
            // 
            // dgvPregledClanova
            // 
            this.dgvPregledClanova.AllowUserToAddRows = false;
            this.dgvPregledClanova.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPregledClanova.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPregledClanova.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.jmb,
            this.brojLK,
            this.prezime,
            this.ime,
            this.adresa,
            this.telefon,
            this.sekcija});
            this.dgvPregledClanova.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPregledClanova.Location = new System.Drawing.Point(3, 3);
            this.dgvPregledClanova.MultiSelect = false;
            this.dgvPregledClanova.Name = "dgvPregledClanova";
            this.dgvPregledClanova.Size = new System.Drawing.Size(1158, 369);
            this.dgvPregledClanova.TabIndex = 5;
            // 
            // pnlContainer
            // 
            this.pnlContainer.Controls.Add(this.btnPrikazOruzja);
            this.pnlContainer.Controls.Add(this.label1);
            this.pnlContainer.Controls.Add(this.btnKalendarLova);
            this.pnlContainer.Controls.Add(this.btnAddMembershipCard);
            this.pnlContainer.Controls.Add(this.btnShowRecords);
            this.pnlContainer.Controls.Add(this.btnRecord);
            this.pnlContainer.Controls.Add(this.btnAddArmedSheet);
            this.pnlContainer.Controls.Add(this.tbSearch);
            this.pnlContainer.Controls.Add(this.btnDeleteMember);
            this.pnlContainer.Controls.Add(this.btnEditMember);
            this.pnlContainer.Controls.Add(this.btnAddMember);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlContainer.Location = new System.Drawing.Point(3, 372);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1158, 76);
            this.pnlContainer.TabIndex = 0;
            // 
            // btnPrikazOruzja
            // 
            this.btnPrikazOruzja.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrikazOruzja.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnPrikazOruzja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrikazOruzja.Location = new System.Drawing.Point(589, 9);
            this.btnPrikazOruzja.Name = "btnPrikazOruzja";
            this.btnPrikazOruzja.Size = new System.Drawing.Size(141, 29);
            this.btnPrikazOruzja.TabIndex = 11;
            this.btnPrikazOruzja.Text = "Prikaz oružja";
            this.btnPrikazOruzja.UseVisualStyleBackColor = true;
            this.btnPrikazOruzja.Click += new System.EventHandler(this.btnPrikazOruzja_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(840, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Pretraga";
            // 
            // btnKalendarLova
            // 
            this.btnKalendarLova.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnKalendarLova.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnKalendarLova.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKalendarLova.Location = new System.Drawing.Point(442, 44);
            this.btnKalendarLova.Name = "btnKalendarLova";
            this.btnKalendarLova.Size = new System.Drawing.Size(141, 29);
            this.btnKalendarLova.TabIndex = 9;
            this.btnKalendarLova.Text = "Kalendar lova";
            this.btnKalendarLova.UseVisualStyleBackColor = true;
            this.btnKalendarLova.Click += new System.EventHandler(this.btnKalendarLova_Click);
            // 
            // btnAddMembershipCard
            // 
            this.btnAddMembershipCard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddMembershipCard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAddMembershipCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMembershipCard.Location = new System.Drawing.Point(295, 44);
            this.btnAddMembershipCard.Name = "btnAddMembershipCard";
            this.btnAddMembershipCard.Size = new System.Drawing.Size(141, 29);
            this.btnAddMembershipCard.TabIndex = 8;
            this.btnAddMembershipCard.Text = "Članska karta";
            this.btnAddMembershipCard.UseVisualStyleBackColor = true;
            this.btnAddMembershipCard.Click += new System.EventHandler(this.btnAddMembershipCard_Click);
            // 
            // btnShowRecords
            // 
            this.btnShowRecords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnShowRecords.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnShowRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowRecords.Location = new System.Drawing.Point(148, 44);
            this.btnShowRecords.Name = "btnShowRecords";
            this.btnShowRecords.Size = new System.Drawing.Size(141, 29);
            this.btnShowRecords.TabIndex = 7;
            this.btnShowRecords.Text = "Prikaz odstrela";
            this.btnShowRecords.UseVisualStyleBackColor = true;
            this.btnShowRecords.Click += new System.EventHandler(this.btnShowRecords_Click);
            // 
            // btnRecord
            // 
            this.btnRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRecord.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecord.Location = new System.Drawing.Point(3, 44);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(141, 29);
            this.btnRecord.TabIndex = 6;
            this.btnRecord.Text = "Evidencija odstrela";
            this.btnRecord.UseVisualStyleBackColor = true;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // btnAddArmedSheet
            // 
            this.btnAddArmedSheet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddArmedSheet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAddArmedSheet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddArmedSheet.Location = new System.Drawing.Point(442, 9);
            this.btnAddArmedSheet.Name = "btnAddArmedSheet";
            this.btnAddArmedSheet.Size = new System.Drawing.Size(141, 29);
            this.btnAddArmedSheet.TabIndex = 5;
            this.btnAddArmedSheet.Text = "Oružani list";
            this.btnAddArmedSheet.UseVisualStyleBackColor = true;
            this.btnAddArmedSheet.Click += new System.EventHandler(this.btnAddArmedSheet_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(844, 41);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(309, 29);
            this.tbSearch.TabIndex = 3;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // btnDeleteMember
            // 
            this.btnDeleteMember.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeleteMember.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnDeleteMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteMember.Location = new System.Drawing.Point(295, 9);
            this.btnDeleteMember.Name = "btnDeleteMember";
            this.btnDeleteMember.Size = new System.Drawing.Size(141, 29);
            this.btnDeleteMember.TabIndex = 2;
            this.btnDeleteMember.Text = "Obriši člana";
            this.btnDeleteMember.UseVisualStyleBackColor = true;
            this.btnDeleteMember.Click += new System.EventHandler(this.btnDeleteMember_Click);
            // 
            // btnEditMember
            // 
            this.btnEditMember.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditMember.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnEditMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditMember.Location = new System.Drawing.Point(148, 9);
            this.btnEditMember.Name = "btnEditMember";
            this.btnEditMember.Size = new System.Drawing.Size(141, 29);
            this.btnEditMember.TabIndex = 1;
            this.btnEditMember.Text = "Izmjeni  člana";
            this.btnEditMember.UseVisualStyleBackColor = true;
            this.btnEditMember.Click += new System.EventHandler(this.btnEditMember_Click);
            // 
            // btnAddMember
            // 
            this.btnAddMember.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddMember.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAddMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMember.Location = new System.Drawing.Point(3, 9);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(141, 29);
            this.btnAddMember.TabIndex = 0;
            this.btnAddMember.Text = "Dodaj člana";
            this.btnAddMember.UseVisualStyleBackColor = true;
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpPregledClanova);
            this.tabControl1.Controls.Add(this.tpSekcije);
            this.tabControl1.Controls.Add(this.tpObavjestenja);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1172, 477);
            this.tabControl1.TabIndex = 1;
            // 
            // tpObavjestenja
            // 
            this.tpObavjestenja.Controls.Add(this.panel5);
            this.tpObavjestenja.Controls.Add(this.rtbShowNotification);
            this.tpObavjestenja.Controls.Add(this.panel4);
            this.tpObavjestenja.Location = new System.Drawing.Point(4, 22);
            this.tpObavjestenja.Name = "tpObavjestenja";
            this.tpObavjestenja.Size = new System.Drawing.Size(1164, 451);
            this.tpObavjestenja.TabIndex = 2;
            this.tpObavjestenja.Text = "Obavještenja";
            this.tpObavjestenja.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gainsboro;
            this.panel5.Controls.Add(this.btnSaveNotification);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(271, 395);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(893, 56);
            this.panel5.TabIndex = 2;
            // 
            // btnSaveNotification
            // 
            this.btnSaveNotification.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSaveNotification.FlatAppearance.BorderSize = 2;
            this.btnSaveNotification.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnSaveNotification.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveNotification.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveNotification.Location = new System.Drawing.Point(352, 5);
            this.btnSaveNotification.Name = "btnSaveNotification";
            this.btnSaveNotification.Size = new System.Drawing.Size(188, 47);
            this.btnSaveNotification.TabIndex = 2;
            this.btnSaveNotification.Text = "Sačuvaj";
            this.btnSaveNotification.UseVisualStyleBackColor = true;
            this.btnSaveNotification.Click += new System.EventHandler(this.btnSaveNotification_Click);
            // 
            // rtbShowNotification
            // 
            this.rtbShowNotification.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbShowNotification.Location = new System.Drawing.Point(271, 0);
            this.rtbShowNotification.Name = "rtbShowNotification";
            this.rtbShowNotification.Size = new System.Drawing.Size(893, 451);
            this.rtbShowNotification.TabIndex = 1;
            this.rtbShowNotification.Text = "";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gainsboro;
            this.panel4.Controls.Add(this.btnDeleteNotification);
            this.panel4.Controls.Add(this.btnEditNotification);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(271, 451);
            this.panel4.TabIndex = 0;
            // 
            // btnDeleteNotification
            // 
            this.btnDeleteNotification.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnDeleteNotification.FlatAppearance.BorderSize = 2;
            this.btnDeleteNotification.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDeleteNotification.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteNotification.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteNotification.Location = new System.Drawing.Point(42, 307);
            this.btnDeleteNotification.Name = "btnDeleteNotification";
            this.btnDeleteNotification.Size = new System.Drawing.Size(188, 47);
            this.btnDeleteNotification.TabIndex = 3;
            this.btnDeleteNotification.Text = "Obriši";
            this.btnDeleteNotification.UseVisualStyleBackColor = true;
            this.btnDeleteNotification.Click += new System.EventHandler(this.btnDeleteNotification_Click);
            // 
            // btnEditNotification
            // 
            this.btnEditNotification.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnEditNotification.FlatAppearance.BorderSize = 2;
            this.btnEditNotification.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEditNotification.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditNotification.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditNotification.Location = new System.Drawing.Point(42, 254);
            this.btnEditNotification.Name = "btnEditNotification";
            this.btnEditNotification.Size = new System.Drawing.Size(188, 47);
            this.btnEditNotification.TabIndex = 2;
            this.btnEditNotification.Text = "Izmjeni";
            this.btnEditNotification.UseVisualStyleBackColor = true;
            this.btnEditNotification.Click += new System.EventHandler(this.btnEditNotification_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(42, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // jmb
            // 
            this.jmb.HeaderText = "JMB";
            this.jmb.Name = "jmb";
            // 
            // brojLK
            // 
            this.brojLK.HeaderText = "Broj lične karte";
            this.brojLK.Name = "brojLK";
            // 
            // prezime
            // 
            this.prezime.HeaderText = "Prezime";
            this.prezime.Name = "prezime";
            // 
            // ime
            // 
            this.ime.HeaderText = "Ime";
            this.ime.Name = "ime";
            // 
            // adresa
            // 
            this.adresa.HeaderText = "Adresa";
            this.adresa.Name = "adresa";
            // 
            // telefon
            // 
            this.telefon.HeaderText = "Telefon";
            this.telefon.Name = "telefon";
            // 
            // sekcija
            // 
            this.sekcija.HeaderText = "Status";
            this.sekcija.Name = "sekcija";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 527);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "POČETNA";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.tpSekcije.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregledSekcija)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tpPregledClanova.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregledClanova)).EndInit();
            this.pnlContainer.ResumeLayout(false);
            this.pnlContainer.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tpObavjestenja.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bntExit;
        private System.Windows.Forms.Label lbDateTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabPage tpSekcije;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvPregledSekcija;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSekcije;
        private System.Windows.Forms.DataGridViewTextBoxColumn naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojClanova;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbPretraga;
        private System.Windows.Forms.Label lbPretraga;
        private System.Windows.Forms.Button btnDeleteSection;
        private System.Windows.Forms.Button btnEditSection;
        private System.Windows.Forms.Button btnAddSection;
        private System.Windows.Forms.TabPage tpPregledClanova;
        private System.Windows.Forms.DataGridView dgvPregledClanova;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Button btnAddArmedSheet;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btnDeleteMember;
        private System.Windows.Forms.Button btnEditMember;
        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.Button btnShowRecords;
        private System.Windows.Forms.TabPage tpObavjestenja;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnSaveNotification;
        private System.Windows.Forms.RichTextBox rtbShowNotification;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnDeleteNotification;
        private System.Windows.Forms.Button btnEditNotification;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAddMembershipCard;
        private System.Windows.Forms.Button btnKalendarLova;
        private System.Windows.Forms.TextBox tbBrojClanova;
        private System.Windows.Forms.Label lbBrojClanova;
        private System.Windows.Forms.TextBox tbNazivSekcije;
        private System.Windows.Forms.Label lbNazivSekcije;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrikazOruzja;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn jmb;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojLK;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn sekcija;
    }
}