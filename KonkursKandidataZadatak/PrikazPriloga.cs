using System;
using System.IO;
using System.Windows.Forms;

namespace KonkursKandidataZadatak
{
    public partial class PrikazPriloga : Form
    {
        Prilog prilogForm;
        public PrikazPriloga(byte[] fileData, string fileName)
        {
            InitializeComponent();
            string tempFilePath = Path.Combine(Path.GetTempPath(), fileName);

            File.WriteAllBytes(tempFilePath, fileData);

            if (File.Exists(tempFilePath))
            {
                try
                {
                    axAcroPDF1.LoadFile(tempFilePath);
                    axAcroPDF1.setShowToolbar(false);
                    axAcroPDF1.setView("Fit");
                    axAcroPDF1.setPageMode("UseNone");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Greska prilikom ucitavanja PDF-a. " + ex.Message);
                }
               
            }
           
        }

        private void PrikazPriloga_Load(object sender, EventArgs e)
        {

        }
    }
}
