using Admin.MODEL.DTO;
using Admin.MODEL.PRISTUP_PODACIMA;
//using Microsoft.Office.Core;
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
    public partial class AddMember : Form
    {
        public AddMember()
        {
            InitializeComponent();
            cbStatus.SelectedIndex = 0;
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {

            if (!Main.isClicked)
            {
                if (!(tbJMB.Text.Equals("")) && !(tbBrojLK.Text.Equals("")) && !(tbPrezime.Text.Equals("")) && !(tbIme.Text.Equals("")) && !(tbAdresa.Text.Equals("")) && !(tbTelefon.Text.Equals("")))
                {
                    if (tbJMB.Text.Length == 13)
                    {
                        int personExist = RadSaOsobama.getPersonId(tbJMB.Text);
                        if (tbBrojLK.Text.Length == 8)
                        {
                            int brojLK = RadSaOsobama.checkIfIdCardExist(tbBrojLK.Text);

                            if (personExist == -1 && brojLK == -1)
                            {
                                RadSaClanovima.insertIntoMembers(tbJMB.Text, tbBrojLK.Text, tbPrezime.Text, tbIme.Text, tbAdresa.Text, tbTelefon.Text, cbStatus.GetItemText(cbStatus.SelectedItem));
                                this.Close();
                            }
                            if (personExist > 0 || brojLK > 0)
                            {
                                      MessageBox.Show("Ova osoba vec postoji u bazi.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Polje BrojLK mora sadrzavati 8 cifara!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Polje JMB mora sadrzavati 13 cifara!");
                    }

                }
                else
                {
                    MessageBox.Show("Sva polja moraju biti popunjena");
                }
            }
            else if (Main.isClicked)
            {  
                RadSaClanovima.updateMembers(Main.osobaJMB, tbBrojLK.Text, tbPrezime.Text, tbIme.Text, tbAdresa.Text, tbTelefon.Text, cbStatus.GetItemText(cbStatus.SelectedItem));
                this.Close();
            }
        }

        private void AddMember_Load(object sender, EventArgs e)
        {
            if (Main.isClicked)
            {
                tbJMB.Text = Main.osobaJMB;
                tbJMB.Enabled = false;
                tbBrojLK.Text = Main.brojLicneKarte;
                tbPrezime.Text = Main.prezimeOsobe;
                tbIme.Text = Main.imeOsobe;
                tbAdresa.Text = Main.adresaStanovanja;
                tbTelefon.Text = Main.telefonOsobe;
                cbStatus.Text = Main.status;

                btnAddMember.Text = "Sačuvaj";
            }
        }

       
    }
}
