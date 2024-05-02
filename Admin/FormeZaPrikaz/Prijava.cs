using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Admin.FormeZaPrikaz;
using Admin.MODEL.DTO;
using Admin.MODEL.PRISTUP_PODACIMA;
using Aspose.Words.Drawing.Charts;

namespace Admin
{
    public partial class Prijava : Form
    {
        


        public Prijava()
        {
            InitializeComponent();
         
        }

        private void llbForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlLogin.Visible = false;       
            pnlForgotPassword.Visible = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlLogin.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            

            if (tbUsername.Text == "")
            {
                lbUsernameWarning.Show();
            }
            else if (tbUsername.Text != "")
            {
                lbUsernameWarning.Hide();
            }
            else if (tbPassword.Text == "")
            {
                lbPassWarning.Show();
            }
            else if (tbPassword.Text != "")
            {
                lbPassWarning.Hide();
            }
            
            if(loginCheck(tbUsername.Text, tbPassword.Text))
            {
                new Main().ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Nesipravni kredencijali");
            }
            
        }

        private Boolean loginCheck(String username, String password)
        {
            List<Administrator> administrators = RadSaAdministratorom.getAdmin();
            Boolean result = false;
            foreach (Administrator a in administrators)
            {
                
                if (a.KorisnickoIme.Equals(username) && a.Lozinka.Equals(password))
                {
                    result = true; 
                    break;
                }
                else
                {
                    result = false;
                }
            }
            return result;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (tbUsernameRepair.Text.Equals("") || tbNewPassword.Text.Equals("") || tbConfirmPassword.Text.Equals(""))
                MessageBox.Show("Polja moraji biti popunjena.");
            else
            {
                List<Administrator> admin = RadSaAdministratorom.getAdmin();
                foreach (Administrator a in admin)
                {
                    if (tbUsernameRepair.Text.Equals(a.KorisnickoIme))
                    {
                        RadSaAdministratorom.updateAdmin(tbNewPassword.Text, a.Id.OsobaId);
                        break;
                    }
                }
                pnlLogin.Show();
            }
        }

  
       

        private void lbRegistracija_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Registracija().ShowDialog();
        }

        

        
    }
}
