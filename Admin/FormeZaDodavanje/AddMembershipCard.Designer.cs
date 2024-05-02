namespace Admin.Dodavanje
{
    partial class AddMembershipCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMembershipCard));
            this.lbOsobaClanskaKarta = new System.Windows.Forms.Label();
            this.lbDatumUclanjivanja = new System.Windows.Forms.Label();
            this.lbDatumIslanjivanja = new System.Windows.Forms.Label();
            this.dtpDatumUclanjivanja = new System.Windows.Forms.DateTimePicker();
            this.btnAddMembershipCard = new System.Windows.Forms.Button();
            this.cbClanskaKartaClan = new System.Windows.Forms.ComboBox();
            this.tbDatumIsclanjivanja = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbOsobaClanskaKarta
            // 
            this.lbOsobaClanskaKarta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOsobaClanskaKarta.Location = new System.Drawing.Point(39, 45);
            this.lbOsobaClanskaKarta.Name = "lbOsobaClanskaKarta";
            this.lbOsobaClanskaKarta.Size = new System.Drawing.Size(114, 31);
            this.lbOsobaClanskaKarta.TabIndex = 0;
            this.lbOsobaClanskaKarta.Text = "Osoba";
            this.lbOsobaClanskaKarta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDatumUclanjivanja
            // 
            this.lbDatumUclanjivanja.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDatumUclanjivanja.Location = new System.Drawing.Point(-2, 98);
            this.lbDatumUclanjivanja.Name = "lbDatumUclanjivanja";
            this.lbDatumUclanjivanja.Size = new System.Drawing.Size(215, 31);
            this.lbDatumUclanjivanja.TabIndex = 2;
            this.lbDatumUclanjivanja.Text = "Datum učlanjivanja";
            this.lbDatumUclanjivanja.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDatumIslanjivanja
            // 
            this.lbDatumIslanjivanja.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDatumIslanjivanja.Location = new System.Drawing.Point(-2, 151);
            this.lbDatumIslanjivanja.Name = "lbDatumIslanjivanja";
            this.lbDatumIslanjivanja.Size = new System.Drawing.Size(215, 31);
            this.lbDatumIslanjivanja.TabIndex = 6;
            this.lbDatumIslanjivanja.Text = "Datum iščlanjivanja";
            this.lbDatumIslanjivanja.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpDatumUclanjivanja
            // 
            this.dtpDatumUclanjivanja.CustomFormat = "dd.M.yyyy";
            this.dtpDatumUclanjivanja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDatumUclanjivanja.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatumUclanjivanja.Location = new System.Drawing.Point(219, 103);
            this.dtpDatumUclanjivanja.Name = "dtpDatumUclanjivanja";
            this.dtpDatumUclanjivanja.Size = new System.Drawing.Size(215, 26);
            this.dtpDatumUclanjivanja.TabIndex = 7;
            // 
            // btnAddMembershipCard
            // 
            this.btnAddMembershipCard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnAddMembershipCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMembershipCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMembershipCard.Location = new System.Drawing.Point(134, 220);
            this.btnAddMembershipCard.Name = "btnAddMembershipCard";
            this.btnAddMembershipCard.Size = new System.Drawing.Size(165, 43);
            this.btnAddMembershipCard.TabIndex = 15;
            this.btnAddMembershipCard.Text = "Dodaj";
            this.btnAddMembershipCard.UseVisualStyleBackColor = true;
            this.btnAddMembershipCard.Click += new System.EventHandler(this.btnAddMembershipCard_Click);
            // 
            // cbClanskaKartaClan
            // 
            this.cbClanskaKartaClan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbClanskaKartaClan.FormattingEnabled = true;
            this.cbClanskaKartaClan.Location = new System.Drawing.Point(159, 48);
            this.cbClanskaKartaClan.Name = "cbClanskaKartaClan";
            this.cbClanskaKartaClan.Size = new System.Drawing.Size(275, 28);
            this.cbClanskaKartaClan.TabIndex = 16;
            // 
            // tbDatumIsclanjivanja
            // 
            this.tbDatumIsclanjivanja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDatumIsclanjivanja.Location = new System.Drawing.Point(219, 154);
            this.tbDatumIsclanjivanja.Name = "tbDatumIsclanjivanja";
            this.tbDatumIsclanjivanja.Size = new System.Drawing.Size(215, 26);
            this.tbDatumIsclanjivanja.TabIndex = 17;
            // 
            // AddMembershipCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(465, 284);
            this.Controls.Add(this.tbDatumIsclanjivanja);
            this.Controls.Add(this.cbClanskaKartaClan);
            this.Controls.Add(this.btnAddMembershipCard);
            this.Controls.Add(this.dtpDatumUclanjivanja);
            this.Controls.Add(this.lbDatumIslanjivanja);
            this.Controls.Add(this.lbDatumUclanjivanja);
            this.Controls.Add(this.lbOsobaClanskaKarta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddMembershipCard";
            this.Text = "ČLANSKA KARTA";
            this.Load += new System.EventHandler(this.AddMembershipCard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbOsobaClanskaKarta;
        private System.Windows.Forms.Label lbDatumUclanjivanja;
        private System.Windows.Forms.Label lbDatumIslanjivanja;
        private System.Windows.Forms.DateTimePicker dtpDatumUclanjivanja;
        private System.Windows.Forms.Button btnAddMembershipCard;
        private System.Windows.Forms.ComboBox cbClanskaKartaClan;
        private System.Windows.Forms.TextBox tbDatumIsclanjivanja;
    }
}