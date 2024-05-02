namespace Admin
{
    partial class ShowRecords
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowRecords));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPretragaOdstrela = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvPregledOdstrela = new System.Windows.Forms.DataGridView();
            this.clan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.divljac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregledOdstrela)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbPretragaOdstrela);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 51);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pretraga";
            // 
            // tbPretragaOdstrela
            // 
            this.tbPretragaOdstrela.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPretragaOdstrela.Location = new System.Drawing.Point(98, 12);
            this.tbPretragaOdstrela.Name = "tbPretragaOdstrela";
            this.tbPretragaOdstrela.Size = new System.Drawing.Size(404, 29);
            this.tbPretragaOdstrela.TabIndex = 0;
            this.tbPretragaOdstrela.TextChanged += new System.EventHandler(this.tbPretragaOdstrela_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvPregledOdstrela);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1000, 467);
            this.panel2.TabIndex = 1;
            // 
            // dgvPregledOdstrela
            // 
            this.dgvPregledOdstrela.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPregledOdstrela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPregledOdstrela.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clan,
            this.divljac,
            this.datum});
            this.dgvPregledOdstrela.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPregledOdstrela.Location = new System.Drawing.Point(0, 0);
            this.dgvPregledOdstrela.Name = "dgvPregledOdstrela";
            this.dgvPregledOdstrela.Size = new System.Drawing.Size(1000, 467);
            this.dgvPregledOdstrela.TabIndex = 0;
            // 
            // clan
            // 
            this.clan.HeaderText = "Član";
            this.clan.Name = "clan";
            // 
            // divljac
            // 
            this.divljac.HeaderText = "Divljač";
            this.divljac.Name = "divljac";
            // 
            // datum
            // 
            this.datum.HeaderText = "Datum";
            this.datum.Name = "datum";
            // 
            // ShowRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 518);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ShowRecords";
            this.Text = "Prikaz odstrela";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregledOdstrela)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvPregledOdstrela;
        private System.Windows.Forms.TextBox tbPretragaOdstrela;
        private System.Windows.Forms.DataGridViewTextBoxColumn clan;
        private System.Windows.Forms.DataGridViewTextBoxColumn divljac;
        private System.Windows.Forms.DataGridViewTextBoxColumn datum;
        private System.Windows.Forms.Label label1;
    }
}