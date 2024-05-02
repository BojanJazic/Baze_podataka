namespace Admin
{
    partial class AddArmedSheet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddArmedSheet));
            this.btnDodajOruzaniList = new System.Windows.Forms.Button();
            this.lbIdOsobeOL = new System.Windows.Forms.Label();
            this.lbFarbickiBrojOruzjaOL = new System.Windows.Forms.Label();
            this.tbRokVazenja = new System.Windows.Forms.TextBox();
            this.lbRokVazenjaOL = new System.Windows.Forms.Label();
            this.lbDatumIzdavanjaOL = new System.Windows.Forms.Label();
            this.tbSerijskiBrojOL = new System.Windows.Forms.TextBox();
            this.lbSerijskiBrojOL = new System.Windows.Forms.Label();
            this.lbPodaciOOruzju = new System.Windows.Forms.Label();
            this.lbVrstaOruzja = new System.Windows.Forms.Label();
            this.lbMarkaOruzja = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbVrstaOruzja = new System.Windows.Forms.ComboBox();
            this.cbKalibarOruzja = new System.Windows.Forms.ComboBox();
            this.tbFabrickiBrojOruzja = new System.Windows.Forms.TextBox();
            this.dtpDatumIzdavanjaOL = new System.Windows.Forms.DateTimePicker();
            this.cbOsobaOL = new System.Windows.Forms.ComboBox();
            this.cbMarkaOruzja = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnDodajOruzaniList
            // 
            this.btnDodajOruzaniList.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDodajOruzaniList.FlatAppearance.BorderSize = 2;
            this.btnDodajOruzaniList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnDodajOruzaniList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajOruzaniList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajOruzaniList.Location = new System.Drawing.Point(316, 422);
            this.btnDodajOruzaniList.Name = "btnDodajOruzaniList";
            this.btnDodajOruzaniList.Size = new System.Drawing.Size(161, 43);
            this.btnDodajOruzaniList.TabIndex = 23;
            this.btnDodajOruzaniList.Text = "Dodaj";
            this.btnDodajOruzaniList.UseVisualStyleBackColor = true;
            this.btnDodajOruzaniList.Click += new System.EventHandler(this.btnDodajOruzaniList_Click);
            // 
            // lbIdOsobeOL
            // 
            this.lbIdOsobeOL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbIdOsobeOL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdOsobeOL.Location = new System.Drawing.Point(156, 127);
            this.lbIdOsobeOL.Name = "lbIdOsobeOL";
            this.lbIdOsobeOL.Size = new System.Drawing.Size(100, 23);
            this.lbIdOsobeOL.TabIndex = 22;
            this.lbIdOsobeOL.Text = "Osoba";
            this.lbIdOsobeOL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbFarbickiBrojOruzjaOL
            // 
            this.lbFarbickiBrojOruzjaOL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbFarbickiBrojOruzjaOL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFarbickiBrojOruzjaOL.Location = new System.Drawing.Point(156, 247);
            this.lbFarbickiBrojOruzjaOL.Name = "lbFarbickiBrojOruzjaOL";
            this.lbFarbickiBrojOruzjaOL.Size = new System.Drawing.Size(100, 23);
            this.lbFarbickiBrojOruzjaOL.TabIndex = 21;
            this.lbFarbickiBrojOruzjaOL.Text = "Fabrički broj";
            this.lbFarbickiBrojOruzjaOL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbRokVazenja
            // 
            this.tbRokVazenja.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbRokVazenja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRokVazenja.Location = new System.Drawing.Point(285, 91);
            this.tbRokVazenja.MaxLength = 25;
            this.tbRokVazenja.Name = "tbRokVazenja";
            this.tbRokVazenja.Size = new System.Drawing.Size(300, 26);
            this.tbRokVazenja.TabIndex = 20;
            // 
            // lbRokVazenjaOL
            // 
            this.lbRokVazenjaOL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbRokVazenjaOL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRokVazenjaOL.Location = new System.Drawing.Point(156, 96);
            this.lbRokVazenjaOL.Name = "lbRokVazenjaOL";
            this.lbRokVazenjaOL.Size = new System.Drawing.Size(100, 23);
            this.lbRokVazenjaOL.TabIndex = 19;
            this.lbRokVazenjaOL.Text = "Rok važenja";
            this.lbRokVazenjaOL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDatumIzdavanjaOL
            // 
            this.lbDatumIzdavanjaOL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbDatumIzdavanjaOL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDatumIzdavanjaOL.Location = new System.Drawing.Point(125, 63);
            this.lbDatumIzdavanjaOL.Name = "lbDatumIzdavanjaOL";
            this.lbDatumIzdavanjaOL.Size = new System.Drawing.Size(131, 23);
            this.lbDatumIzdavanjaOL.TabIndex = 17;
            this.lbDatumIzdavanjaOL.Text = "Datum izdavanja";
            this.lbDatumIzdavanjaOL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbSerijskiBrojOL
            // 
            this.tbSerijskiBrojOL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbSerijskiBrojOL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSerijskiBrojOL.Location = new System.Drawing.Point(285, 27);
            this.tbSerijskiBrojOL.MaxLength = 6;
            this.tbSerijskiBrojOL.Name = "tbSerijskiBrojOL";
            this.tbSerijskiBrojOL.Size = new System.Drawing.Size(300, 26);
            this.tbSerijskiBrojOL.TabIndex = 16;
            // 
            // lbSerijskiBrojOL
            // 
            this.lbSerijskiBrojOL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbSerijskiBrojOL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSerijskiBrojOL.Location = new System.Drawing.Point(156, 30);
            this.lbSerijskiBrojOL.Name = "lbSerijskiBrojOL";
            this.lbSerijskiBrojOL.Size = new System.Drawing.Size(100, 23);
            this.lbSerijskiBrojOL.TabIndex = 15;
            this.lbSerijskiBrojOL.Text = "Serijski broj";
            this.lbSerijskiBrojOL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbPodaciOOruzju
            // 
            this.lbPodaciOOruzju.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbPodaciOOruzju.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbPodaciOOruzju.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPodaciOOruzju.Location = new System.Drawing.Point(34, 208);
            this.lbPodaciOOruzju.Name = "lbPodaciOOruzju";
            this.lbPodaciOOruzju.Size = new System.Drawing.Size(153, 23);
            this.lbPodaciOOruzju.TabIndex = 26;
            this.lbPodaciOOruzju.Text = "Podaci o oružju:";
            this.lbPodaciOOruzju.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbVrstaOruzja
            // 
            this.lbVrstaOruzja.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbVrstaOruzja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVrstaOruzja.Location = new System.Drawing.Point(156, 283);
            this.lbVrstaOruzja.Name = "lbVrstaOruzja";
            this.lbVrstaOruzja.Size = new System.Drawing.Size(100, 23);
            this.lbVrstaOruzja.TabIndex = 27;
            this.lbVrstaOruzja.Text = "Vrsta";
            this.lbVrstaOruzja.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbMarkaOruzja
            // 
            this.lbMarkaOruzja.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbMarkaOruzja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMarkaOruzja.Location = new System.Drawing.Point(156, 317);
            this.lbMarkaOruzja.Name = "lbMarkaOruzja";
            this.lbMarkaOruzja.Size = new System.Drawing.Size(100, 23);
            this.lbMarkaOruzja.TabIndex = 29;
            this.lbMarkaOruzja.Text = "Marka";
            this.lbMarkaOruzja.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(156, 351);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 31;
            this.label3.Text = "Kalibar";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbVrstaOruzja
            // 
            this.cbVrstaOruzja.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbVrstaOruzja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVrstaOruzja.FormattingEnabled = true;
            this.cbVrstaOruzja.Location = new System.Drawing.Point(285, 279);
            this.cbVrstaOruzja.Name = "cbVrstaOruzja";
            this.cbVrstaOruzja.Size = new System.Drawing.Size(300, 28);
            this.cbVrstaOruzja.TabIndex = 33;
            // 
            // cbKalibarOruzja
            // 
            this.cbKalibarOruzja.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbKalibarOruzja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKalibarOruzja.FormattingEnabled = true;
            this.cbKalibarOruzja.Location = new System.Drawing.Point(285, 346);
            this.cbKalibarOruzja.Name = "cbKalibarOruzja";
            this.cbKalibarOruzja.Size = new System.Drawing.Size(300, 28);
            this.cbKalibarOruzja.TabIndex = 35;
            // 
            // tbFabrickiBrojOruzja
            // 
            this.tbFabrickiBrojOruzja.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbFabrickiBrojOruzja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFabrickiBrojOruzja.Location = new System.Drawing.Point(285, 244);
            this.tbFabrickiBrojOruzja.MaxLength = 5;
            this.tbFabrickiBrojOruzja.Name = "tbFabrickiBrojOruzja";
            this.tbFabrickiBrojOruzja.Size = new System.Drawing.Size(300, 26);
            this.tbFabrickiBrojOruzja.TabIndex = 36;
            // 
            // dtpDatumIzdavanjaOL
            // 
            this.dtpDatumIzdavanjaOL.CustomFormat = "dd.M.yyyy";
            this.dtpDatumIzdavanjaOL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDatumIzdavanjaOL.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatumIzdavanjaOL.Location = new System.Drawing.Point(285, 59);
            this.dtpDatumIzdavanjaOL.Name = "dtpDatumIzdavanjaOL";
            this.dtpDatumIzdavanjaOL.Size = new System.Drawing.Size(300, 26);
            this.dtpDatumIzdavanjaOL.TabIndex = 38;
            // 
            // cbOsobaOL
            // 
            this.cbOsobaOL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbOsobaOL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOsobaOL.FormattingEnabled = true;
            this.cbOsobaOL.Location = new System.Drawing.Point(285, 123);
            this.cbOsobaOL.Name = "cbOsobaOL";
            this.cbOsobaOL.Size = new System.Drawing.Size(300, 28);
            this.cbOsobaOL.TabIndex = 39;
            // 
            // cbMarkaOruzja
            // 
            this.cbMarkaOruzja.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbMarkaOruzja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMarkaOruzja.FormattingEnabled = true;
            this.cbMarkaOruzja.Location = new System.Drawing.Point(285, 313);
            this.cbMarkaOruzja.Name = "cbMarkaOruzja";
            this.cbMarkaOruzja.Size = new System.Drawing.Size(300, 28);
            this.cbMarkaOruzja.TabIndex = 40;
            // 
            // AddArmedSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(738, 481);
            this.Controls.Add(this.cbMarkaOruzja);
            this.Controls.Add(this.cbOsobaOL);
            this.Controls.Add(this.dtpDatumIzdavanjaOL);
            this.Controls.Add(this.tbFabrickiBrojOruzja);
            this.Controls.Add(this.cbKalibarOruzja);
            this.Controls.Add(this.cbVrstaOruzja);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbMarkaOruzja);
            this.Controls.Add(this.lbVrstaOruzja);
            this.Controls.Add(this.lbPodaciOOruzju);
            this.Controls.Add(this.btnDodajOruzaniList);
            this.Controls.Add(this.lbIdOsobeOL);
            this.Controls.Add(this.lbFarbickiBrojOruzjaOL);
            this.Controls.Add(this.tbRokVazenja);
            this.Controls.Add(this.lbRokVazenjaOL);
            this.Controls.Add(this.lbDatumIzdavanjaOL);
            this.Controls.Add(this.tbSerijskiBrojOL);
            this.Controls.Add(this.lbSerijskiBrojOL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddArmedSheet";
            this.Text = "ORUŽANI LIST";
            this.Load += new System.EventHandler(this.AddArmedSheet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDodajOruzaniList;
        private System.Windows.Forms.Label lbIdOsobeOL;
        private System.Windows.Forms.Label lbFarbickiBrojOruzjaOL;
        private System.Windows.Forms.TextBox tbRokVazenja;
        private System.Windows.Forms.Label lbRokVazenjaOL;
        private System.Windows.Forms.Label lbDatumIzdavanjaOL;
        private System.Windows.Forms.TextBox tbSerijskiBrojOL;
        private System.Windows.Forms.Label lbSerijskiBrojOL;
        private System.Windows.Forms.Label lbPodaciOOruzju;
        private System.Windows.Forms.Label lbVrstaOruzja;
        private System.Windows.Forms.Label lbMarkaOruzja;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbVrstaOruzja;
        private System.Windows.Forms.ComboBox cbKalibarOruzja;
        private System.Windows.Forms.TextBox tbFabrickiBrojOruzja;
        private System.Windows.Forms.DateTimePicker dtpDatumIzdavanjaOL;
        private System.Windows.Forms.ComboBox cbOsobaOL;
        private System.Windows.Forms.ComboBox cbMarkaOruzja;
    }
}