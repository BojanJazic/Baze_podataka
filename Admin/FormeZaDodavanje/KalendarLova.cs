using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using Admin.MODEL.DTO;
using Admin.MODEL.PRISTUP_PODACIMA;
using Aspose.Words;
//using Microsoft.Office.Interop.Word;
using SautinSoft.Document;
//using Document = Microsoft.Office.Interop.Word.Document;
using HorizontalAlignment = SautinSoft.Document.HorizontalAlignment;
using Paragraph = SautinSoft.Document.Paragraph;
using Section = SautinSoft.Document.Section;

namespace Admin.Dodavanje
{
    public partial class KalendarLova : Form
    {
        
        List<string> listDivljac = new List<string>();
        List<string> listPeriod = new List<string>();
        List<string> listBrojJedinki = new List<string>();
        List<Divljac> divljac = RadSaDivljaci.getAnimals();

        public KalendarLova()
        {
            InitializeComponent();

        }

        private void KalendarLova_Load(object sender, EventArgs e)
        {
            foreach (Divljac d in divljac)
            {
                cbDivljacKalendarLova.Items.Add(d.Vrsta);
            }
            cbDivljacKalendarLova.SelectedIndex = 0;
        }

        private void btnDodajKalendarLova_Click(object sender, EventArgs e)
        {
            List<Divljac> divljac = RadSaDivljaci.getAnimals();

            int animal = -1;
            if (!cbDivljacKalendarLova.GetItemText(cbDivljacKalendarLova.SelectedItem).Equals(""))
            {
                foreach (Divljac d in divljac)
                {
                    if (cbDivljacKalendarLova.GetItemText(cbDivljacKalendarLova.SelectedItem).Equals(d.Vrsta))
                    {
                        animal = d.DivljacId;
                        break;
                    }
                }
            }

            Console.WriteLine("DODAJ");
            
            listDivljac.Add(cbDivljacKalendarLova.Text);
            listPeriod.Add(dtpPocetakLova.Text + " - " + dtpKrajLova.Text);
            listBrojJedinki.Add(tbBrojJedinki.Text);
            cbDivljacKalendarLova.SelectedIndex = 0;
            tbBrojJedinki.Clear();
            Console.WriteLine(tbBrojJedinki.Text);
            if (!cbDivljacKalendarLova.GetItemText(cbDivljacKalendarLova.SelectedItem).Equals("") && !dtpPocetakLova.Value.Equals("") && !dtpKrajLova.Value.Equals(""))
            {
                RadSaLovnimKalendarom.insertIntoCalender(dtpPocetakLova.Value, dtpKrajLova.Value);
               
            }
            else
            {
                MessageBox.Show("Sva polja moraju biti popunjena");
            }
            int lastInsertedId = RadSaLovnimKalendarom.getLastInsertedId();
            
           // RadSaLovnimKalendarom.insertIntoCalenderOfAnimals(animal, lastInsertedId, int.Parse(tbBrojJedinki.Text));
            
        }

        private void btnNapraviDokument_Click(object sender, EventArgs e)
        {

           DocumentCore documentCore = new DocumentCore();
           SautinSoft.Document.DocumentBuilder documentBuilder = new SautinSoft.Document.DocumentBuilder(documentCore);
            
                        documentBuilder.CharacterFormat.FontName = "Calibri";
                        documentBuilder.CharacterFormat.Size = 44f;
                        documentBuilder.CharacterFormat.FontColor = Color.Black;
                        documentBuilder.CharacterFormat.Bold = true;
                        documentBuilder.ParagraphFormat.Alignment = SautinSoft.Document.HorizontalAlignment.Center;
                        documentBuilder.Writeln("Kalendar lova");

                        documentBuilder.CharacterFormat.FontName = "Times New Roman";
                        documentBuilder.CharacterFormat.Size = 14f;
                        documentBuilder.CharacterFormat.FontColor = Color.Black;
                        documentBuilder.CharacterFormat.Bold = false;
                        documentBuilder.ParagraphFormat.Alignment = SautinSoft.Document.HorizontalAlignment.Justify;

            documentBuilder.Writeln("\n");
            documentBuilder.Writeln(" Divljač                 Period                  Broj jedinki");
            for (int i = 0; i < listDivljac.Count; i++)
            {
                
                documentBuilder.Writeln("  " + listDivljac[i].ToString() + "       " + listPeriod[i].ToString() + "         " + listBrojJedinki[i].ToString());
            }
            documentCore.Save(@"C:\\Users\\Bojan\\Desktop\\11109_19-Bojan_Jazic\\Projekat_A-Lovacko_udruzenje\\KalendarLova\\Kalendar.docx");

            this.Close();
        }
    }
}
