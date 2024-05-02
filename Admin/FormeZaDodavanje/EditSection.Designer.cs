namespace Admin.FormeZaDodavanje
{
    partial class EditSection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditSection));
            this.tbBrojClanova = new System.Windows.Forms.TextBox();
            this.lbBrojClanova = new System.Windows.Forms.Label();
            this.tbNazivSekcije = new System.Windows.Forms.TextBox();
            this.lbNazivSekcije = new System.Windows.Forms.Label();
            this.btnSaveEdit = new System.Windows.Forms.Button();
            this.tbIdSekcije = new System.Windows.Forms.TextBox();
            this.lbSectionId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbBrojClanova
            // 
            this.tbBrojClanova.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBrojClanova.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBrojClanova.Location = new System.Drawing.Point(143, 94);
            this.tbBrojClanova.MaxLength = 13;
            this.tbBrojClanova.Name = "tbBrojClanova";
            this.tbBrojClanova.Size = new System.Drawing.Size(227, 26);
            this.tbBrojClanova.TabIndex = 7;
            // 
            // lbBrojClanova
            // 
            this.lbBrojClanova.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbBrojClanova.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBrojClanova.Location = new System.Drawing.Point(31, 94);
            this.lbBrojClanova.Name = "lbBrojClanova";
            this.lbBrojClanova.Size = new System.Drawing.Size(106, 23);
            this.lbBrojClanova.TabIndex = 8;
            this.lbBrojClanova.Text = "Broj članova";
            this.lbBrojClanova.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbNazivSekcije
            // 
            this.tbNazivSekcije.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNazivSekcije.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNazivSekcije.Location = new System.Drawing.Point(143, 53);
            this.tbNazivSekcije.MaxLength = 13;
            this.tbNazivSekcije.Name = "tbNazivSekcije";
            this.tbNazivSekcije.Size = new System.Drawing.Size(227, 26);
            this.tbNazivSekcije.TabIndex = 5;
            // 
            // lbNazivSekcije
            // 
            this.lbNazivSekcije.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNazivSekcije.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNazivSekcije.Location = new System.Drawing.Point(31, 53);
            this.lbNazivSekcije.Name = "lbNazivSekcije";
            this.lbNazivSekcije.Size = new System.Drawing.Size(106, 23);
            this.lbNazivSekcije.TabIndex = 6;
            this.lbNazivSekcije.Text = "Naziv";
            this.lbNazivSekcije.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSaveEdit
            // 
            this.btnSaveEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnSaveEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveEdit.Location = new System.Drawing.Point(143, 147);
            this.btnSaveEdit.Name = "btnSaveEdit";
            this.btnSaveEdit.Size = new System.Drawing.Size(176, 36);
            this.btnSaveEdit.TabIndex = 9;
            this.btnSaveEdit.Text = "Sačuvaj";
            this.btnSaveEdit.UseVisualStyleBackColor = true;
            this.btnSaveEdit.Click += new System.EventHandler(this.btnSaveEdit_Click);
            // 
            // tbIdSekcije
            // 
            this.tbIdSekcije.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbIdSekcije.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIdSekcije.Location = new System.Drawing.Point(143, 9);
            this.tbIdSekcije.MaxLength = 13;
            this.tbIdSekcije.Name = "tbIdSekcije";
            this.tbIdSekcije.Size = new System.Drawing.Size(227, 26);
            this.tbIdSekcije.TabIndex = 10;
            this.tbIdSekcije.Visible = false;
            // 
            // lbSectionId
            // 
            this.lbSectionId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSectionId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSectionId.Location = new System.Drawing.Point(31, 9);
            this.lbSectionId.Name = "lbSectionId";
            this.lbSectionId.Size = new System.Drawing.Size(106, 23);
            this.lbSectionId.TabIndex = 11;
            this.lbSectionId.Text = "Id sekcije";
            this.lbSectionId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EditSection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(423, 200);
            this.Controls.Add(this.tbIdSekcije);
            this.Controls.Add(this.lbSectionId);
            this.Controls.Add(this.btnSaveEdit);
            this.Controls.Add(this.tbBrojClanova);
            this.Controls.Add(this.lbBrojClanova);
            this.Controls.Add(this.tbNazivSekcije);
            this.Controls.Add(this.lbNazivSekcije);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditSection";
            this.Text = "Izmjena sekcije";
            this.Load += new System.EventHandler(this.EditSection_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbBrojClanova;
        private System.Windows.Forms.Label lbBrojClanova;
        private System.Windows.Forms.TextBox tbNazivSekcije;
        private System.Windows.Forms.Label lbNazivSekcije;
        private System.Windows.Forms.Button btnSaveEdit;
        private System.Windows.Forms.TextBox tbIdSekcije;
        private System.Windows.Forms.Label lbSectionId;
    }
}