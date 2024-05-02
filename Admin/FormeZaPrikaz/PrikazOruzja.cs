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

namespace Admin.FormeZaPrikaz
{
    public partial class PrikazOruzja : Form
    {
        public PrikazOruzja()
        {
            InitializeComponent();
            FillGrid();
        }

        private void FillGrid()
        {
            dgvPregledOruzja.Rows.Clear();
            foreach(OruzaniList ol in RadSaOruzanimListom.getDataForGridView(tbSearch.Text))
            {
                DataGridViewRow row = new DataGridViewRow()
                {
                    Tag = ol
                };
                row.CreateCells(dgvPregledOruzja, ol.OsobaId.OsobaId.JMB, ol.OsobaId.OsobaId.Prezime, ol.OsobaId.OsobaId.Ime, ol.FabrickiBroj.FabrickiBroj, ol.FabrickiBroj.MarkaOruzjaId.MarkaOruzjaNaziv, ol.FabrickiBroj.VrstaOruzjaId.VrstaOruzjaNaziv, ol.FabrickiBroj.KalibarOruzjaId.Kalibar);
                dgvPregledOruzja.Rows.Add(row);
            }
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            FillGrid();
        }

       
    }
}
