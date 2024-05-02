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
    public partial class AddArmedSheet : Form
    {
        public AddArmedSheet()
        {
            InitializeComponent();
        }

        private void AddArmedSheet_Load(object sender, EventArgs e)
        {
            
            List<Clan> clanovi = RadSaClanovima.GetMembers();
            List<Oruzje> oruzje = RadSaOruzjem.getWeapons();
            List<string> vrste = RadSaOruzjem.getWeaponsType();
            List<string> marka = RadSaOruzjem.getWeaponsBrand();
            List<string> kalibar = RadSaOruzjem.getWeaponsCaliber();

            foreach (Clan c in clanovi)
            {
                cbOsobaOL.Items.Add(c.OsobaId.JMB + " " + c.OsobaId.Prezime + " " + c.OsobaId.Ime);
                //Console.WriteLine("OSOBA: " + c.OsobaId.Prezime + " " + c.OsobaId.Ime);
            }
            cbOsobaOL.SelectedIndex = 0;

            foreach (string s in vrste)
                cbVrstaOruzja.Items.Add(s);
            
            cbVrstaOruzja.SelectedIndex = 0;

            foreach (string s in marka)
                cbMarkaOruzja.Items.Add(s);

            cbMarkaOruzja.SelectedIndex = 0;

            foreach (string s in kalibar)
                cbKalibarOruzja.Items.Add(s);

            cbKalibarOruzja.SelectedIndex = 0;
        }

        private void btnDodajOruzaniList_Click(object sender, EventArgs e)
        {          
            if (!tbFabrickiBrojOruzja.Text.Equals("") && (!tbSerijskiBrojOL.Text.Equals("")) && (!dtpDatumIzdavanjaOL.Text.Equals("")) && (!tbRokVazenja.Text.Equals("")) && !(cbVrstaOruzja.GetItemText(cbVrstaOruzja.SelectedItem).Equals("")))
            {
                if (!RadSaOruzjem.checkIfExist(tbFabrickiBrojOruzja.Text))
                {
                    if (tbFabrickiBrojOruzja.Text.Length == 5)
                    {
                        if (!RadSaOruzanimListom.checkIfArmedSheetExists(tbSerijskiBrojOL.Text))
                        {
                            if (tbSerijskiBrojOL.Text.Length == 6)
                            {
                                RadSaOruzjem.insertWeapon(tbFabrickiBrojOruzja.Text, cbVrstaOruzja.GetItemText(cbVrstaOruzja.SelectedItem),
                                cbMarkaOruzja.GetItemText(cbMarkaOruzja.SelectedItem),
                                                          cbKalibarOruzja.GetItemText(cbKalibarOruzja.SelectedItem));
                                RadSaOruzanimListom.insertArmedSheet(tbSerijskiBrojOL.Text, dtpDatumIzdavanjaOL.Value, tbRokVazenja.Text, tbFabrickiBrojOruzja.Text, cbOsobaOL.GetItemText(cbOsobaOL.SelectedItem));
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Polje Serijski broj mora sadrzavati tacno 6 cifara!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Oruzani list sa ovim serijskim brojem vec postoji");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Polje Fabricki broj mora sadrzavati tacno 5 cifara!");
                    }
                }
                else
                {
                    MessageBox.Show("Oruzje sa ovim fabrickim brojem vec postoji");
                }
            }
            else
            {
                MessageBox.Show("Sva polja moraju biti popunjena.");
            }
           
        }
    }
}
