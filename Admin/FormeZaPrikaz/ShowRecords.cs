using Admin.MODEL.DTO;
using Admin.MODEL.PRISTUP_PODACIMA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin
{
    public partial class ShowRecords : Form
    {
        public ShowRecords()
        {
            InitializeComponent();
            FillGrid();
        }

       private void FillGrid()
        {
            dgvPregledOdstrela.Rows.Clear();
            foreach (EvidencijaOdstrela e in RadSaEvidencijomOdstrela.getData(tbPretragaOdstrela.Text))
            {
                DataGridViewRow row = new DataGridViewRow()
                {
                    Tag = e
                };
                row.CreateCells(dgvPregledOdstrela, e.OsobaId.Prezime, e.DivljacId.Vrsta, e.DatumOdstrela.ToShortDateString());
                dgvPregledOdstrela.Rows.Add(row);
            }
        }

        private void tbPretragaOdstrela_TextChanged(object sender, EventArgs e)
        {
            FillGrid();
        }
    }
}
