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
using Microsoft.Office.Interop.Word;

namespace UserApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            rtbShowNotification.Enabled= false;
        }

        private void btnOpenNotification_Click(object sender, EventArgs e)
        {
            rtbShowNotification.Clear();
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

        private void btnKalendarLova_Click(object sender, EventArgs e)
        {
            rtbShowNotification.Clear();
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = @"C:\\Users\\Bojan\\Desktop\\11109_19-Bojan_Jazic\\Projekat_A-Lovacko_udruzenje\\KalendarLova",
                Title = "Browse Text Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "docx files (*.docx)|*.docx",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Microsoft.Office.Interop.Word.Application wordObject = new Microsoft.Office.Interop.Word.Application();
                object File = openFileDialog.FileName; //this is the path
                object nullobject = System.Reflection.Missing.Value; Microsoft.Office.Interop.Word.Application wordobject = new Microsoft.Office.Interop.Word.Application();
                wordobject.DisplayAlerts = Microsoft.Office.Interop.Word.WdAlertLevel.wdAlertsNone; Microsoft.Office.Interop.Word._Document docs = wordObject.Documents.Open(ref File, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject); docs.ActiveWindow.Selection.WholeStory();
                docs.ActiveWindow.Selection.Copy();
                this.rtbShowNotification.Paste();
                docs.Close(ref nullobject, ref nullobject, ref nullobject);
                wordobject.Quit(ref nullobject, ref nullobject, ref nullobject);

            }
        }

       public void ImportWord()
        {
            Microsoft.Office.Interop.Word.Application wordObject = new Microsoft.Office.Interop.Word.Application();
            object File = "c:\\Test.docx"; //this is the path
            object nullobject = System.Reflection.Missing.Value; Microsoft.Office.Interop.Word.Application wordobject = new Microsoft.Office.Interop.Word.Application();
            wordobject.DisplayAlerts = Microsoft.Office.Interop.Word.WdAlertLevel.wdAlertsNone; Microsoft.Office.Interop.Word._Document docs = wordObject.Documents.Open(ref File, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject); docs.ActiveWindow.Selection.WholeStory();
            docs.ActiveWindow.Selection.Copy();
            this.rtbShowNotification.Paste();
            docs.Close(ref nullobject, ref nullobject, ref nullobject);
            wordobject.Quit(ref nullobject, ref nullobject, ref nullobject);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
