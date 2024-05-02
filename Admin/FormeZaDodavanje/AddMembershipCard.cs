using Admin.MODEL.DTO;
using Admin.MODEL.PRISTUP_PODACIMA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin.Dodavanje
{
    public partial class AddMembershipCard : Form
    {
        List<Clan> clanovi = RadSaClanovima.GetMembers();

        public AddMembershipCard()
        {
            InitializeComponent();
        }

        private void AddMembershipCard_Load(object sender, EventArgs e)
        {
            
            foreach(Clan c in clanovi)
            {
                cbClanskaKartaClan.Items.Add(c.OsobaId.OsobaId + " " + c.OsobaId.JMB + " " + c.OsobaId.Prezime + " " + c.OsobaId.Ime);           
            }
        }

        private void btnAddMembershipCard_Click(object sender, EventArgs e)
        {
            if (!cbClanskaKartaClan.GetItemText(cbClanskaKartaClan.SelectedItem).Equals(""))
            {
                string[] tmp = null;
                tmp = cbClanskaKartaClan.GetItemText(cbClanskaKartaClan.SelectedItem).Split(' ');
                int idClana = int.Parse(tmp[0]);
                Console.WriteLine("ID CLANA: " + idClana);
                if (!check(idClana))
                { 
                    RadSaClanskomKartom.insertIntoMemberShipCard(dtpDatumUclanjivanja.Value, tbDatumIsclanjivanja.Text, idClana);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ova osoba vec posjeduje clansku kartu!");
                }
            }
            else
            {
                MessageBox.Show("Morate prvo izabrati osobu!");
            }
        }

        private Boolean check(int id)
        {
            Boolean result = false;
            foreach(ClanskaKarta ck in RadSaClanskomKartom.getMemberShipCard())
            {
                if (id.Equals(ck.OsobaId.OsobaId.OsobaId))
                    result = true;
            }

            return result;
        }

    }
}
