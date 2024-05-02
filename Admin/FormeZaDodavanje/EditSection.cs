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

namespace Admin.FormeZaDodavanje
{
    public partial class EditSection : Form
    {
        public EditSection()
        {
            InitializeComponent();
        }

        private void EditSection_Load(object sender, EventArgs e)
        {
            tbIdSekcije.Text = Main.sectionId;
            tbNazivSekcije.Text = Main.sectionName;
            tbBrojClanova.Text = Main.brojClanovaUSekciji;
            lbSectionId.Visible = false;

            Console.WriteLine("DA VIDIMO: " + sender.ToString());
        }

        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
           
                RadSaSekcijama.updateSection(Int32.Parse(tbIdSekcije.Text), tbNazivSekcije.Text, Int32.Parse(tbBrojClanova.Text));
                this.Close();
            
            
        }
    }
}
