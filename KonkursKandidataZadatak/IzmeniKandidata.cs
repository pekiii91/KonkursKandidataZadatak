using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Design;
using System.IO;
using System.Windows.Forms;

namespace KonkursKandidataZadatak
{
    public partial class IzmeniKandidata : Form
    {
        Kandidat kandidatForm;
        PrikazKandidata prikazKandidata;
        private int? selectedKandidatID = null;
        private int KandidatID;
        private SqlConnection konekcija;
        private SqlDataAdapter adapterKandidat;
        private SqlDataReader adapterStatusi;
        public IzmeniKandidata()
        {
            InitializeComponent();
            konekcija = new SqlConnection("Data Source=DESKTOP-B3LH9NO;Initial Catalog=KonkursKandidatiDB;Integrated Security=True;Encrypt=False");
            numericUpDownOcena.Minimum = 1;
            numericUpDownOcena.Maximum = 5;
        }
        private void IzmeniKandidata_Load(object sender, EventArgs e)
        {

        }

        private void textBoxIme_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void textBoxPrezime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void textBoxJMBG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void textBoxEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar)
                    && e.KeyChar != '.' && e.KeyChar != '@' && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void textBoxTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)
                    && e.KeyChar != '/' && e.KeyChar != '-' && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void textBoxNapomena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar)
                && !char.IsPunctuation(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        
        private bool CheckIfNotEmpty()
        {
            if ((textBoxIme.Text != "") &&
                (textBoxPrezime.Text != "") &&
                (textBoxJMBG.Text != "") &&
                (textBoxEmail.Text != "") &&
                (richTextBoxDodatniLinkovi.Text != "") &&
                (textBoxTelefon.Text != "") &&
                (textBoxNapomena.Text != ""))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Molim vas popunite sva polja.");
                return false;
            }
        }

        // Ocisti formu
        public void Clear()
        {
            selectedKandidatID = null;
            textBoxIme.Clear();
            textBoxPrezime.Clear();
            textBoxJMBG.Clear();
            textBoxEmail.Clear();
            textBoxJMBG.Clear();
            textBoxNapomena.Clear();
            richTextBoxDodatniLinkovi.Clear();
            textBoxTelefon.Clear();
            numericUpDownOcena.Value = 1;
        }

        // Validacija obaveznih polja
        public bool Validacija()
        {
            if (string.IsNullOrEmpty(textBoxIme.Text))
            {
                MessageBox.Show("Morate uneti ime", "Poruka");
                textBoxIme.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(textBoxPrezime.Text))
            {
                MessageBox.Show("Morate uneti prezime", "Poruka");
                textBoxPrezime.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(textBoxJMBG.Text))
            {
                MessageBox.Show("Morate uneti jmbg", "Poruka");
                textBoxJMBG.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(dateTimePickerDatumRodj.Text))
            {
                MessageBox.Show("Morate uneti datum rodjenja", "Poruka");
                dateTimePickerDatumRodj.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(textBoxEmail.Text))
            {
                MessageBox.Show("Morate uneti email", "Poruka");
                textBoxEmail.Focus();
                return false;
            }

            return true;
        }

        public IzmeniKandidata(int KandidatID, string ime, string prezime, decimal ocena, string jmbg,
                               string email, DateTime datumRodjenja, string link, string telefon, string napomena)
        {
            InitializeComponent();

            konekcija = new SqlConnection("Data Source=DESKTOP-B3LH9NO;Initial Catalog=KonkursKandidatiDB;Integrated Security=True;Encrypt=False");

            selectedKandidatID = KandidatID;
            textBoxIme.Text = ime;
            textBoxPrezime.Text = prezime;
            textBoxJMBG.Text = jmbg;
            dateTimePickerDatumRodj.Value = datumRodjenja;
            textBoxEmail.Text = email;
            richTextBoxDodatniLinkovi.Text = link;
            textBoxTelefon.Text = telefon;
            textBoxNapomena.Text = napomena;
            numericUpDownOcena.Value = ocena;

        }

        private void btnSačuvaj_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Kandidat SET Ime = @Ime, Prezime = @Prezime, JMBG = @JMBG, DatumRodjenja = @DatumRodjenja, " +
                       "Email = @Email, DodatniLinkovi = @DodatniLinkovi, Telefon = @Telefon, Napomena = @Napomena, Ocena = @Ocena, Slika = @Slika, LastUpdate = @LastUpdate WHERE KandidatID = @KandidatID";

            try
            {
                using (SqlCommand komanda = new SqlCommand(query, konekcija))
                {
                    komanda.Parameters.AddWithValue("@KandidatID", selectedKandidatID);
                    komanda.Parameters.AddWithValue("@Ime", textBoxIme.Text);
                    komanda.Parameters.AddWithValue("@Prezime", textBoxPrezime.Text);
                    komanda.Parameters.AddWithValue("@JMBG", textBoxJMBG.Text);
                    komanda.Parameters.AddWithValue("@DatumRodjenja", dateTimePickerDatumRodj.Value);
                    komanda.Parameters.AddWithValue("@Email", textBoxEmail.Text);
                    komanda.Parameters.AddWithValue("@DodatniLinkovi", richTextBoxDodatniLinkovi.Text);
                    komanda.Parameters.AddWithValue("@Telefon", textBoxTelefon.Text);
                    komanda.Parameters.AddWithValue("@Napomena", textBoxNapomena.Text);
                    komanda.Parameters.AddWithValue("@Ocena", numericUpDownOcena.Value);
                    komanda.Parameters.AddWithValue("@LastUpdate", DateTime.Now);
                    komanda.Parameters.AddWithValue("@Slika", pictureBoxSlika.Image != null ? CuvanjeSlike(pictureBoxSlika.Image) : (object)DBNull.Value);

                    konekcija.Open();
                    komanda.ExecuteNonQuery();

                    MessageBox.Show("Podaci o kandidatu su uspesno azurirani.");
                    this.DialogResult = DialogResult.OK;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greska pri cuvanju izmena: " + ex.Message);
            }
            finally 
            {
                konekcija.Close();
            }
        }

        private void btnBrisanjeSlike_Click(object sender, EventArgs e)
        {
            pictureBoxSlika.Image = null;
        }

        private void btnUcitavanjeNoveSlike_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBoxSlika.Image = Image.FromFile(openFileDialog.FileName);
                }
            }
        }

        //Cuvanje Slike u bazi
        private byte[] CuvanjeSlike(Image image) 
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }
    }
}
