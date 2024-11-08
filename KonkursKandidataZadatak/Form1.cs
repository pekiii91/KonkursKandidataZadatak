using System;
using System.Windows.Forms;

namespace KonkursKandidataZadatak
{
    public partial class Form1 : Form
    {
        private Kandidat kandidatForm;
        private PrikazKandidata prikazForm;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           

        }

        private void btnKandidat_Click(object sender, EventArgs e)
        {
            Kandidat kandidatForm = new Kandidat();
            kandidatForm.ShowDialog();
            this.DialogResult = DialogResult.OK;

        }

        private void btnPrikazKandidata_Click(object sender, EventArgs e)
        {
            PrikazKandidata prikazForm = new PrikazKandidata();
            prikazForm.ShowDialog();
            this.DialogResult = DialogResult.OK;

        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
