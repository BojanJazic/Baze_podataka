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
    public partial class AddRecord : Form
    {
        public AddRecord()
        {
            InitializeComponent();
        }

        private void AddRecord_Load(object sender, EventArgs e)
        {
            List<Divljac> divljac = RadSaDivljaci.getAnimals();
            List<Clan> clanovi = RadSaClanovima.GetMembers();

            foreach (Divljac d in divljac)
                cbDivljac.Items.Add(d.Vrsta);
            cbDivljac.SelectedIndex = 0;

            foreach (Clan c in clanovi)
                cbOdstrelLovca.Items.Add(c.OsobaId.JMB + " " + c.OsobaId.Prezime + " " + c.OsobaId.Ime);
            cbOdstrelLovca.SelectedIndex = 0;
        }

        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            List<Divljac> divljac = RadSaDivljaci.getAnimals();

            string[] tmp = cbOdstrelLovca.Text.Split(' ');

            int idDivljaci = 0;
            int idClana = 0;

            idClana = RadSaOsobama.getPersonId(tmp[0]);

            foreach(Divljac d in divljac)
            {
                if (cbDivljac.GetItemText(cbDivljac.SelectedItem).Equals(d.Vrsta))
                {
                    idDivljaci = d.DivljacId;
                    break;
                }
            }

            RadSaEvidencijomOdstrela.insertRecord(idDivljaci, idClana, dtpEvidencijaOdstrelaDatum.Value);

            this.Close();
        }
    }
}
