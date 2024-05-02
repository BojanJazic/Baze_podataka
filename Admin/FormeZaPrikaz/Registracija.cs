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
    public partial class Registracija : Form
    {
        public Registracija()
        {
            InitializeComponent();
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistracija_Click(object sender, EventArgs e)
        {

            if (!tbJMB.Text.Equals("") && !tbBrojLK.Text.Equals("") && !tbPrezime.Text.Equals("") && !tbIme.Text.Equals("") && !tbAdresa.Text.Equals("") && !tbTelefon.Text.Equals(""))
            {
                if (tbJMB.Text.Length == 13)
                {
                    if (tbBrojLK.Text.Length == 8)
                    {

                        if (!checkIfPersonAlreadyExist(tbJMB.Text, tbBrojLK.Text))
                        {
                            MessageBox.Show("Vec ste registrovani u bazi.");
                        }
                        else
                        {
                            if (!checkUsername(tbKorisnickoIme.Text))
                            {
                                MessageBox.Show("Ovo korisnicko ime je vec upotrebljeno.");
                                tbKorisnickoIme.Clear();
                            }
                            else
                            {
                                RadSaAdministratorom.insertIntoAdmin(tbJMB.Text, tbBrojLK.Text, tbPrezime.Text, tbIme.Text, tbAdresa.Text, tbTelefon.Text, tbKorisnickoIme.Text, tbLozinka.Text);
                                this.Close();
                            }
                                
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
                MessageBox.Show("Sva polja moraju biti popunjena!");
            }
        }

        public Boolean checkIfPersonAlreadyExist(String JMB, String brojLK)
        {
            List<Osoba> osobe = RadSaOsobama.GetPersons();
            foreach (Osoba o in osobe)
            {
                if (JMB.Equals(o.JMB) || brojLK.Equals(o.BrojLicneKarte))
                {
                    return false;
                }
            }
            return true;
        }
        
        private Boolean checkUsername(String username)
        {
            List<Administrator> admin = RadSaAdministratorom.getAdmin();

            foreach (Administrator a in admin)
            {
                if (tbKorisnickoIme.Text.Equals(a.KorisnickoIme))
                {
                    return false;
                }             
            }
            return true;
        }

    }
}
