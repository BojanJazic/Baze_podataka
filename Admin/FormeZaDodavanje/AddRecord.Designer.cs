namespace Admin
{
    partial class AddRecord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddRecord));
            this.lbDatumOdstrela = new System.Windows.Forms.Label();
            this.cbOdstrelLovca = new System.Windows.Forms.ComboBox();
            this.lbLovac = new System.Windows.Forms.Label();
            this.cbDivljac = new System.Windows.Forms.ComboBox();
            this.lbDivljac = new System.Windows.Forms.Label();
            this.dtpEvidencijaOdstrelaDatum = new System.Windows.Forms.DateTimePicker();
            this.btnAddRecord = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbDatumOdstrela
            // 
            this.lbDatumOdstrela.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbDatumOdstrela.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbDatumOdstrela.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDatumOdstrela.Location = new System.Drawing.Point(23, 144);
            this.lbDatumOdstrela.Name = "lbDatumOdstrela";
            this.lbDatumOdstrela.Size = new System.Drawing.Size(107, 28);
            this.lbDatumOdstrela.TabIndex = 10;
            this.lbDatumOdstrela.Text = "Datum odstrela";
            this.lbDatumOdstrela.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbOdstrelLovca
            // 
            this.cbOdstrelLovca.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbOdstrelLovca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOdstrelLovca.FormattingEnabled = true;
            this.cbOdstrelLovca.Location = new System.Drawing.Point(136, 94);
            this.cbOdstrelLovca.Name = "cbOdstrelLovca";
            this.cbOdstrelLovca.Size = new System.Drawing.Size(265, 28);
            this.cbOdstrelLovca.TabIndex = 9;
            // 
            // lbLovac
            // 
            this.lbLovac.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbLovac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbLovac.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLovac.Location = new System.Drawing.Point(23, 94);
            this.lbLovac.Name = "lbLovac";
            this.lbLovac.Size = new System.Drawing.Size(107, 28);
            this.lbLovac.TabIndex = 8;
            this.lbLovac.Text = "Osoba";
            this.lbLovac.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbDivljac
            // 
            this.cbDivljac.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbDivljac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDivljac.FormattingEnabled = true;
            this.cbDivljac.Location = new System.Drawing.Point(136, 45);
            this.cbDivljac.Name = "cbDivljac";
            this.cbDivljac.Size = new System.Drawing.Size(265, 28);
            this.cbDivljac.Sorted = true;
            this.cbDivljac.TabIndex = 7;
            // 
            // lbDivljac
            // 
            this.lbDivljac.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbDivljac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbDivljac.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDivljac.Location = new System.Drawing.Point(23, 45);
            this.lbDivljac.Name = "lbDivljac";
            this.lbDivljac.Size = new System.Drawing.Size(107, 28);
            this.lbDivljac.TabIndex = 6;
            this.lbDivljac.Text = "Divljač";
            this.lbDivljac.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpEvidencijaOdstrelaDatum
            // 
            this.dtpEvidencijaOdstrelaDatum.CustomFormat = "dd.M.yyyy";
            this.dtpEvidencijaOdstrelaDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEvidencijaOdstrelaDatum.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEvidencijaOdstrelaDatum.Location = new System.Drawing.Point(136, 144);
            this.dtpEvidencijaOdstrelaDatum.Name = "dtpEvidencijaOdstrelaDatum";
            this.dtpEvidencijaOdstrelaDatum.Size = new System.Drawing.Size(265, 26);
            this.dtpEvidencijaOdstrelaDatum.TabIndex = 11;
            // 
            // btnAddRecord
            // 
            this.btnAddRecord.FlatAppearance.BorderSize = 2;
            this.btnAddRecord.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnAddRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRecord.Location = new System.Drawing.Point(136, 212);
            this.btnAddRecord.Name = "btnAddRecord";
            this.btnAddRecord.Size = new System.Drawing.Size(166, 39);
            this.btnAddRecord.TabIndex = 12;
            this.btnAddRecord.Text = "Dodaj";
            this.btnAddRecord.UseVisualStyleBackColor = true;
            this.btnAddRecord.Click += new System.EventHandler(this.btnAddRecord_Click);
            // 
            // AddRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(430, 273);
            this.Controls.Add(this.btnAddRecord);
            this.Controls.Add(this.dtpEvidencijaOdstrelaDatum);
            this.Controls.Add(this.lbDatumOdstrela);
            this.Controls.Add(this.cbOdstrelLovca);
            this.Controls.Add(this.lbLovac);
            this.Controls.Add(this.cbDivljac);
            this.Controls.Add(this.lbDivljac);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddRecord";
            this.Text = "EVIDENCIJA ODSTRELA";
            this.Load += new System.EventHandler(this.AddRecord_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbDatumOdstrela;
        private System.Windows.Forms.ComboBox cbOdstrelLovca;
        private System.Windows.Forms.Label lbLovac;
        private System.Windows.Forms.ComboBox cbDivljac;
        private System.Windows.Forms.Label lbDivljac;
        private System.Windows.Forms.DateTimePicker dtpEvidencijaOdstrelaDatum;
        private System.Windows.Forms.Button btnAddRecord;
    }
}