using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace KonkursKandidataZadatak
{
    public partial class Kandidat : Form
    {
        Form1 form1;
        private int? selectedKandidatID = null;
        private SqlConnection konekcija;
        private SqlDataAdapter adapterKandidat;
        private SqlDataReader adapterStatusi;
        
        public Kandidat()
        {
            InitializeComponent();
            konekcija = new SqlConnection("Data Source=DESKTOP-B3LH9NO;Initial Catalog=KonkursKandidatiDB;Integrated Security=True;Encrypt=False");
            puniStatus();
            numericUpDownOcena.Minimum = 1;
            numericUpDownOcena.Maximum = 5;
        }
        private void Kandidat_Load(object sender, EventArgs e)
        {

        }

        public void puniStatus()
        {
            string query = "SELECT * FROM StatusKandidata";
            SqlDataAdapter adapterStatusi = new SqlDataAdapter(query, konekcija);
            DataTable dtStatusi = new DataTable();
            adapterStatusi.Fill(dtStatusi);

            comboBoxStatus.DataSource = dtStatusi;
            comboBoxStatus.DisplayMember = "NazivStatusa";
            comboBoxStatus.ValueMember = "StatusID";
          
        }
       
        private void comboBoxStatusi_SelectedIndexChanged(object sender, EventArgs e)
        {
           puniStatus();
        }

        //Metoda koja postavlja parametre za komandu. Popuni parametre iz forme
        public void KandidatParametri(SqlCommand komanda)
        {
            komanda.Parameters.Clear();
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


            komanda.Parameters.AddWithValue("@StatusID", ((DataRowView)comboBoxStatus.SelectedItem)["StatusID"]);

            if (pictureBoxSlika.ImageLocation != null) 
            {
                komanda.Parameters.AddWithValue("@Slika", PretvaranjeSlike(pictureBoxSlika.ImageLocation));
            }
            else
            {
                komanda.Parameters.AddWithValue("@Slika", DBNull.Value);
            }
        }


        private bool ValidacijaPolja(Control control, Func<Control, bool> validationRule, string errorMessage)
        {
            if(!validationRule(control))
            {
                errorProviderKandidat.SetError(control, errorMessage);
                if (control.Focused == false)
                    control.Focus();
                return false;
            }
            else
            {
                errorProviderKandidat.SetError(control, "");
                return true;
            }
        }



        // Validacija obaveznih polja (error provider i mandatory)
        public bool Validacija()
        {
            bool isValid = true;


            // Validacija imena
            isValid &= ValidacijaPolja(textBoxIme, c => !string.IsNullOrEmpty(c.Text), "Ime je obavezno.");

            // Validacija prezimena
            isValid &= ValidacijaPolja(textBoxPrezime, c => !string.IsNullOrEmpty(c.Text), "Prezime je obavezno.");

            // Validacija JMBG-a
            isValid &= ValidacijaPolja(textBoxJMBG, c => c.Text.Length == 13 && long.TryParse(c.Text, out _),
                "JMBG mora imati tačno 13 cifara.");

            // Validacija datuma rođenja
            isValid &= ValidacijaPolja(dateTimePickerDatumRodj, c => ((DateTimePicker)c).Value != null,
                "Datum rođenja je obavezan.");

            // Validacija emaila
            isValid &= ValidacijaPolja(textBoxEmail, c => c.Text.Contains("@") && c.Text.Contains("."),
                "Unesite validnu email adresu.");

            return isValid;
            /*  //validacija imena
              if (string.IsNullOrEmpty(textBoxIme.Text) || textBoxIme.Text.Length<2)
              {
                  errorProviderKandidat.SetError(textBoxIme, "Ime mora sadrzati bar 2 karaktera..");
                  isValid = false; 
              }
              else
              {
                  errorProviderKandidat.SetError(textBoxIme, ""); //ukloni gresku
              }

              //validacija prezimena
              if (string.IsNullOrEmpty(textBoxPrezime.Text) || textBoxPrezime.Text.Length < 2)
              {
                  errorProviderKandidat.SetError(textBoxPrezime, "Prezime mora sadrzati barem 2 karaktera.");
                  isValid = false;
              }
              else
              {
                  errorProviderKandidat.SetError(textBoxPrezime, "");
              }

              //validacija JMBG-a
              if (string.IsNullOrEmpty(textBoxJMBG.Text))
              {
                  errorProviderKandidat.SetError(textBoxJMBG, "JMBG je obavezan.");
                  isValid = false;
              }
              else if (!Regex.IsMatch(textBoxJMBG.Text, @"^\d{13}$"))
              {
                  errorProviderKandidat.SetError(textBoxJMBG, "JMBG mora sadržati tačno 13 cifara.");
                  isValid = false;
              }
              else
              {
                  errorProviderKandidat.SetError(textBoxJMBG, "");
              }

              //validacija datuma rodjenja
              if (dateTimePickerDatumRodj.Value > DateTime.Now)
              {
                  errorProviderKandidat.SetError(dateTimePickerDatumRodj, "Datum rođenja ne moze biti u buducnosti.");
                  isValid = false;
              }
              else
              {
                  errorProviderKandidat.SetError(dateTimePickerDatumRodj, "");
              }


              //validacija email
              if (string.IsNullOrEmpty(textBoxEmail.Text))
              {
                  errorProviderKandidat.SetError(textBoxEmail, "Email je obavezan.");
                  isValid = false;
              }
              else if (!Regex.IsMatch(textBoxEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
              {
                  errorProviderKandidat.SetError(textBoxEmail, "Unesite ispravan email.");
                  isValid = false;
              }
              else
              {
                  errorProviderKandidat.SetError(textBoxEmail, "");
              }


              return isValid; */
        }

        // Metoda koja proverava validnost JMBG i popunjava datum rodjenja
        public bool ValidirajJMBG()
        {
            string jmbg = textBoxJMBG.Text;
            if(jmbg.Length != 13)
            {
                MessageBox.Show("JMBG mora imati 13 cifara.", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            try
            {
                int dan = int.Parse(jmbg.Substring(0, 2));
                int mesec = int.Parse(jmbg.Substring(2, 2));
                int godina = int.Parse(jmbg.Substring(4, 3));

                godina += (godina < 800 ? 2000 : 1000);

                //Kreiranje datuma na osnovu ekstraktovanih podataka
                DateTime datumRodjenja = new DateTime(godina, mesec, dan);

                dateTimePickerDatumRodj.Value = datumRodjenja;

                return true;
            }
            catch 
            {
                MessageBox.Show("JMBG nije validan. Proverite ispravnost podataka.", "Greska");
                return false;
            }

        }

        //Ocisti formu i resetovanje selectedKandidataID nakon brisanja 
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
            textBoxLastUpdate.Clear();
            numericUpDownOcena.Value = 1;
            comboBoxStatus.SelectedIndex = -1;
            
            //Resetovanje Error Provider-a
            errorProviderKandidat.Clear();
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
            if(!char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar)
                && !char.IsPunctuation(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled= true;
            }
        }

        /* Metoda koja je tipa bool, i koja ce vratiti vrednost true ukoliko ni jedan od textBox-a nije prazan
        ukoliko jeste vratice false*/
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

        private void buttonDodajKandidata_Click(object sender, EventArgs e)
        {
            if (!Validacija())
            {
                MessageBox.Show("Molimo vas da ispravite greske pre nego sto nastavite.", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            string query = "INSERT INTO Kandidat (Ime, Prezime, JMBG, DatumRodjenja, Email, DodatniLinkovi, Telefon, Napomena, LastUpdate, Slika, Ocena, StatusID)" +
                              "VALUES (@Ime, @Prezime, @JMBG, @DatumRodjenja, @Email, @DodatniLinkovi, @Telefon, @Napomena, @LastUpdate, @Slika, @Ocena, @StatusID)";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, konekcija))
                {
                    konekcija.Open();
                    KandidatParametri(cmd); 
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Kandidat je uspesno dodat.");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greska");
            }
            finally
            {
                if (konekcija.State == ConnectionState.Open)
                    konekcija.Close();
            }

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!CheckIfNotEmpty())
            {
                MessageBox.Show("Molim vas popunite sva polja.");
            }
            
            this.Close();
        }

        private void textBoxJMBG_Leave(object sender, EventArgs e)
        {
            ValidirajJMBG();
        }

        private void btnUcitavanjeSlike_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"; 

                if(openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBoxSlika.ImageLocation = openFileDialog.FileName;
                }
            }
        }

        private byte[] PretvaranjeSlike(string filePath)
        {
            return File.ReadAllBytes(filePath);
        }

        //Metoda za prikaz slike
        private void PrikazSlike(byte[] slika)
        {
            if(slika != null && slika.Length > 0)
            {
                using (var ms = new MemoryStream(slika))
                {
                    pictureBoxSlika.Image = Image.FromStream(ms);
                }
            }
            else
            {
                pictureBoxSlika.Image = null; //Reset ako nema slike
            }
        }

        private void btnBrisanjeSlike_Click(object sender, EventArgs e)
        {
            pictureBoxSlika.Image = null;

            string query = "UPDATE Kandidat SET Slika = NULL WHERE KandidatID = @KandidatID";

            try
            {
                using (SqlCommand komanda = new SqlCommand(query, konekcija))
                {
                    komanda.Parameters.AddWithValue("@KandidatID", selectedKandidatID);
                    konekcija.Open();

                    komanda.ExecuteNonQuery();

                    MessageBox.Show("Slika je uspesno obrisane iz baze podataka.", "Super", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Doslo je do greske prilikom brisanja slike: " + ex.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if(konekcija.State == ConnectionState.Open)
                    konekcija.Close();
            }
        }

    }
}
