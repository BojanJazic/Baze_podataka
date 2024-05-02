using Admin.Dodavanje;
using Admin.FormeZaDodavanje;
using Admin.FormeZaPrikaz;
using Admin.MODEL.DTO;
using Admin.MODEL.PRISTUP_PODACIMA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Admin
{
    public partial class Main : Form
    {
        public static string sectionName = "";
        public static string brojClanovaUSekciji = "";
        public static string sectionId = "";

        public static Boolean isClicked = false;

        //varijable u koje cu smjestiti vrijednosti iz dgvPregledClanova da bih mogao izvrsiti edit nekih podataka
        public static int idOsobe = 0;
        public static string osobaJMB = "";
        public static string brojLicneKarte = "";
        public static string prezimeOsobe = "";
        public static string imeOsobe = "";
        public static string adresaStanovanja = "";
        public static string telefonOsobe = "";
        public static string nazivSekcije = "";
        public static string status = "";

        public Main()
        {
           
            InitializeComponent();
            FillGrid();
            FillGridWithSections();
        }
     
        private void FillGrid()
        {
  
            dgvPregledClanova.Rows.Clear();

            foreach (Clan item in RadSaClanovima.GetDataForFillGridView(tbSearch.Text))
            {
                DataGridViewRow row = new DataGridViewRow()
                {
                    Tag = item
                };
                row.CreateCells(dgvPregledClanova, item.OsobaId.JMB, item.OsobaId.BrojLicneKarte, item.OsobaId.Prezime, item.OsobaId.Ime,
                                item.OsobaId.Adresa, item.OsobaId.Telefon, item.Status);
                dgvPregledClanova.Rows.Add(row);
            }
        }

        public void FillGridWithSections()
        {
            dgvPregledSekcija.Rows.Clear();

            foreach(Sekcija s in RadSaSekcijama.GetSections(tbPretraga.Text))
            {
                DataGridViewRow row = new DataGridViewRow()
                {
                    Tag = s
                };
                row.CreateCells(dgvPregledSekcija, s.SekcijaId, s.Naziv, s.BrojClanova);

                dgvPregledSekcija.Rows.Add(row);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            lbDateTime.Text = dateTime.ToString("dd.MM.yyyy. HH.mm.ss");
        }

        private void Main_Load(object sender, EventArgs e)
        {
            timer1.Start();
            
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            isClicked = false;
            new AddMember().ShowDialog();
            FillGrid();
        }

        private void btnEditMember_Click(object sender, EventArgs e)
        {
            DataGridViewRow dgv = dgvPregledClanova.SelectedRows[0];
            if (dgvPregledClanova.RowCount == 0)
            {
                MessageBox.Show("Funkcija nije moguca, jer clanovi ne postoje!");
            }
            if (dgv.Cells[0].Value != null)
            {
                isClicked = true;
                int index = dgvPregledClanova.CurrentCell.RowIndex;
                DataGridViewRow row = dgvPregledClanova.Rows[index];
                osobaJMB = row.Cells[0].Value.ToString();
               // Console.WriteLine("ID OSOBE: " + osobaJMB);
                brojLicneKarte = row.Cells[1].Value.ToString();
                prezimeOsobe = row.Cells[2].Value.ToString();
                imeOsobe = row.Cells[3].Value.ToString();
                adresaStanovanja = row.Cells[4].Value.ToString();
                telefonOsobe = row.Cells[5].Value.ToString();
                status = row.Cells[6].Value.ToString();

                new AddMember().ShowDialog();
                FillGrid();
        }
            else
            {
                MessageBox.Show("Da biste izmijenili člana morate označiti red");
            }
}

        private void btnAddArmedSheet_Click(object sender, EventArgs e)
        {
           
            if (dgvPregledClanova.Rows.Count == 1)
               MessageBox.Show("Nije moguce unijeti oruzje bez postojanja clana");
            else
                new AddArmedSheet().ShowDialog();
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            new AddRecord().ShowDialog();
        }

        private void btnShowRecords_Click(object sender, EventArgs e)
        {
            new ShowRecords().ShowDialog();
        }

        private void btnEditNotification_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = @"C:\\Users\\Bojan\\Desktop\\11109_19-Bojan_Jazic\\Projekat_A-Lovacko_udruzenje\\Obavjestenja",
                Title = "Browse Text Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                rtbShowNotification.Text = File.ReadAllText(openFileDialog.FileName);
            }
            

        }

        private void btnSaveNotification_Click(object sender, EventArgs e)
        {
            if (!rtbShowNotification.Text.Equals(""))
            {

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "txt files (*.txt)|*.txt";
                saveFileDialog.Title = "Save an text file";
                FileStream fileStream;
                StreamWriter streamWriter;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileName = saveFileDialog.FileName;
                    string extension = Path.GetExtension(fileName);

                    fileStream = new FileStream(fileName, FileMode.OpenOrCreate);
                    streamWriter = new StreamWriter(fileStream);
                    streamWriter.WriteLine(rtbShowNotification.Text);

                    streamWriter.Close();
                    fileStream.Close();

                }
                rtbShowNotification.Clear();
            }
            else
            {
                MessageBox.Show("Ne mozete sacuvati prazan dokument!");
            }
            
        }

        private void btnAddMembershipCard_Click(object sender, EventArgs e)
        {
            new AddMembershipCard().ShowDialog();
        }

        private void btnKalendarLova_Click(object sender, EventArgs e)
        {
            new KalendarLova().ShowDialog();
        } 

        private void btnDeleteSection_Click(object sender, EventArgs e)
        {
            int index = dgvPregledSekcija.CurrentCell.RowIndex;
            DataGridViewRow row = dgvPregledSekcija.Rows[index];
            RadSaSekcijama.deleteSection((int)row.Cells[0].Value);
            FillGridWithSections();
        }

        private void btnEditSection_Click(object sender, EventArgs e)
        {
            int index = dgvPregledSekcija.CurrentCell.RowIndex;
            DataGridViewRow row = dgvPregledSekcija.Rows[index];
                sectionId = row.Cells[0].Value.ToString();
                sectionName = row.Cells[1].Value.ToString();
                brojClanovaUSekciji = row.Cells[2].Value.ToString();

            new EditSection().ShowDialog();
            FillGridWithSections();
        }

        private void tbPretraga_TextChanged(object sender, EventArgs e)
        {
            FillGridWithSections();
        }

        private void btnAddSection_Click(object sender, EventArgs e)
        {
            if(!(tbNazivSekcije.Text.Equals("")) && !(tbBrojClanova.Text.Equals("")))
            {
                List<Sekcija> sekcije = RadSaSekcijama.GetSections();
                Boolean check = false;
                foreach(Sekcija s in sekcije)
                {
                    if (tbNazivSekcije.Text.Equals(s.Naziv))
                    {
                        check = true;
                        break;
                    }
                }
                if (!check)
                {
                    RadSaSekcijama.insertIntoSection(tbNazivSekcije.Text, int.Parse(tbBrojClanova.Text));
                    tbNazivSekcije.Clear();
                    tbBrojClanova.Clear();
                }
                else
                {
                    MessageBox.Show("Ova sekcija vec postoji u bazi");
                }
               
            }
            else
            {
                MessageBox.Show("Oba polja moraju biti popunjena!");
            }
            
            FillGridWithSections();
        }

        private void bntExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void btnDeleteMember_Click(object sender, EventArgs e)
        {
            int index = dgvPregledClanova.CurrentCell.RowIndex;
            DataGridViewRow row = dgvPregledClanova.Rows[index];
            int idOsobe = RadSaOsobama.getPersonId(row.Cells[0].Value.ToString());
           
            RadSaClanovima.deleteMember(idOsobe);
            FillGrid();
        }

        private void btnDeleteNotification_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = @"C:\\Users\Bojan\Desktop\\11109_19-Bojan_Jazic\\Projekat_A-Lovacko_udruzenje\\Obavjestenja\\Obavjestenja",
                Title = "Browse Text Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
               File.Delete(openFileDialog.FileName);
            else
                        Console.WriteLine("NISTA");
            
        }

        private void btnPrikazOruzja_Click(object sender, EventArgs e)
        {
            new PrikazOruzja().ShowDialog();
        }
    }
}
