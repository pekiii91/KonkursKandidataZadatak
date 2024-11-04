using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;


namespace KonkursKandidataZadatak
{
    public partial class Prilog : Form
    {

        PrikazKandidata prikazKandidata;
        Form1 form1;
        private int kandidatID;
        private int prilogID;
        private SqlDataAdapter adapterPriloga;
        private SqlDataAdapter adapterTipPriloga;
        private DataTable dtPriloga;
        private DataTable dtTipPriloga;
        private SqlConnection konekcija;
        private OpenFileDialog openFileDialog = new OpenFileDialog();

        public Prilog(int kandidatID)
        {
            InitializeComponent();
            konekcija = new SqlConnection("Data Source=DESKTOP-B3LH9NO;Initial Catalog=KonkursKandidatiDB;Integrated Security=True;Encrypt=False");
            this.kandidatID = kandidatID;

            dataGridViewPrilog.Columns.Add("PrilogID", "PrilogID");
            dataGridViewPrilog.Columns.Add("Naziv", "Naziv");
            dataGridViewPrilog.Columns.Add("TipPriloga", "Naziv Tipa Priloga");
            dataGridViewPrilog.Columns.Add("LastUpdate", "Datum poslednje izmene");

            dataGridViewPrilog.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewPrilog.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            UcitajPrilogeKandidata(kandidatID);
            UcitajTipovePriloga();
            //Drag and drop
            dataGridViewPrilog.AllowDrop = true;
            dataGridViewPrilog.DragEnter += dataGridViewPrilog_DragEnter;
            dataGridViewPrilog.DragDrop += dataGridViewPrilog_DragDrop;
        }

        private void Prilog_Load(object sender, EventArgs e)
        {

        }

        public void UcitajTipovePriloga()
        {
            comboBoxTipPriloga.Items.Clear();
            comboBoxTipPriloga.Items.AddRange(new string[] { "CV", "Propratno pismo", "Sertifikat" });
        }
        private void comboBoxTipPriloga_SelectedIndexChanged(object sender, EventArgs e)
        {
            string izabraniTip = comboBoxTipPriloga.SelectedItem.ToString();
            MessageBox.Show("Izabrali ste: " + izabraniTip);
        }
        private void textBoxNazivPriloga_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        //Ocisti formu i resetovanje 
        public void Clear()
        {
            textBoxNazivPriloga.Clear();
            comboBoxTipPriloga.SelectedIndex = -1;
        }

        //Metoda koja postavlja parametre za komandu. Popuni parametre iz forme.
        public void PrilogParemetri(SqlCommand komanda, byte[] fileData)
        {
            komanda.Parameters.Clear();
            komanda.Parameters.AddWithValue("@KandidatID", kandidatID);
            komanda.Parameters.AddWithValue("@TipPrilogaID", comboBoxTipPriloga.SelectedIndex + 1);
            komanda.Parameters.AddWithValue("@Naziv", textBoxNazivPriloga.Text);
            komanda.Parameters.AddWithValue("@File", fileData);
            komanda.Parameters.AddWithValue("@LastUpdate", DateTime.Now);

        }

        //Metoda koja ucitava sve priloge i postavlja ih u DataGridView
        public void UcitajPrilogeKandidata(int kandidatID)
        {
            dataGridViewPrilog.Rows.Clear();

            string query = @"SELECT PrilogID, Naziv,
                            CASE 
                             WHEN TipPrilogaID = 1 THEN 'CV' 
                             WHEN TipPrilogaID = 2 THEN 'Propratno pismo' 
                             WHEN TipPrilogaID = 3 THEN 'Sertifikat' 
                            ELSE 'Nepoznato' 
                            END AS TipPriloga, LastUpdate 
                            FROM Prilog 
                            WHERE KandidatID = @KandidatID";
            using (SqlCommand komanda = new SqlCommand(query, konekcija))
            {
                komanda.Parameters.AddWithValue("@KandidatID", kandidatID);
                konekcija.Open();
                using (SqlDataReader reader = komanda.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        dataGridViewPrilog.Rows.Add(reader["PrilogID"], reader["Naziv"], reader["TipPriloga"], reader["LastUpdate"]);
                    }
                }
                konekcija.Close();
            }
            
        }
        private void btnDodajPrilog_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "All Files (*.*)|*.*|PDF Files (*.pdf)|*.pdf|Image Files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";


            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                byte[] fileData = File.ReadAllBytes(openFileDialog.FileName);

                string query = "INSERT INTO Prilog (KandidatID, TipPrilogaID, Naziv, [File], LastUpdate) " +
                               "VALUES (@KandidatID, @TipPrilogaID, @Naziv, @File, GETDATE())";
                try
                {
                    using (SqlConnection konekcija = new SqlConnection("Data Source=DESKTOP-B3LH9NO;Initial Catalog=KonkursKandidatiDB;Integrated Security=True;Encrypt=False"))
                    using (SqlCommand komanda = new SqlCommand(query, konekcija))
                    {

                        komanda.Parameters.Clear();

                        PrilogParemetri(komanda, fileData);
                        konekcija.Open();
                        komanda.ExecuteNonQuery();

                        MessageBox.Show("Prilog je uspesno dodat.");

                        UcitajPrilogeKandidata(kandidatID);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Greška prilikom dodavanja priloga: " + ex.Message);

                }
                finally
                {
                    if (konekcija.State == ConnectionState.Open)
                        konekcija.Close();
                }
            }

        }

        private void btnObrisiPrilog_Click(object sender, EventArgs e)
        {
            if (dataGridViewPrilog.SelectedRows.Count > 0)
            {
                int prilogID = (int)dataGridViewPrilog.SelectedRows[0].Cells["PrilogID"].Value;

                try
                {
                    string query = "DELETE FROM Prilog Where PrilogID=@PrilogID ";
                    using (SqlConnection konekcija = new SqlConnection("Data Source=DESKTOP-B3LH9NO;Initial Catalog=KonkursKandidatiDB;Integrated Security=True;Encrypt=False"))
                    using (SqlCommand komanda = new SqlCommand(query, konekcija))
                    {
                        komanda.Parameters.AddWithValue("@PrilogID", prilogID);
                        konekcija.Open();
                        komanda.ExecuteNonQuery();
                    }

                    MessageBox.Show("Prilog je uspesno obrisan. ", "Obrisi prilog", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UcitajPrilogeKandidata(kandidatID);
                    UcitajTipovePriloga();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Greska pri brisanje priloga: " + ex.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnPreuzmi_Click(object sender, EventArgs e)
        {
            if (dataGridViewPrilog.SelectedRows.Count > 0)
            {
                int prilogID = Convert.ToInt32(dataGridViewPrilog.SelectedRows[0].Cells["PrilogID"].Value);

                //Pozivamo metodu PreuzmiPrilog
                PreuzmiPrilog(prilogID);
            }
            else
            {
                MessageBox.Show("Molim vas izaberiti prilog za preuzimanje.", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void PreuzmiPrilog(int prilogID)
        {
            string query = "SELECT [File], [Naziv] FROM Prilog WHERE PrilogID = @PrilogID";
            using (SqlCommand komanda = new SqlCommand(query, konekcija))
            {
                komanda.Parameters.AddWithValue("@PrilogID", prilogID);

                konekcija.Open();
                using (SqlDataReader reader = komanda.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        byte[] fileData = (byte[])reader["File"];
                        string naziv = reader["Naziv"].ToString();

                        SaveFileDialog saveFileDialog = new SaveFileDialog();
                        saveFileDialog.FileName = naziv;
                        saveFileDialog.Filter = "All Files|*.*";

                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            string filePath = saveFileDialog.FileName;
                            File.WriteAllBytes(filePath, fileData);

                            //Otvaramo fajl u podrazumevanom pretrazivacu
                            Process.Start(new ProcessStartInfo(filePath) { UseShellExecute = true });
                        }
                    }
                }
                konekcija.Close();
            }
        }

        private void btnPrikazPriloga_Click(object sender, EventArgs e)
        {
            if (dataGridViewPrilog.SelectedRows.Count > 0)
            {
                int prilogID = Convert.ToInt32(dataGridViewPrilog.SelectedRows[0].Cells["PrilogID"].Value);

                string query = "SELECT [File], Naziv FROM Prilog WHERE PrilogID = @PrilogID";
                using (SqlCommand komanda = new SqlCommand(query, konekcija))
                {
                    komanda.Parameters.AddWithValue("@PrilogID", prilogID);
                    konekcija.Open();

                    using (SqlDataReader reader = komanda.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            byte[] fileData = (byte[])reader["File"];
                            string naziv = reader["Naziv"].ToString();

                            //Otvaram novu formu PrikazPriloga
                            PrikazPriloga prikazPriloga = new PrikazPriloga(fileData, naziv + ".pdf");
                            prikazPriloga.ShowDialog();
                        }
                    }
                    konekcija.Close();
                }
            }
            else
            {
                MessageBox.Show("Molim vas izaberiti prilog za prikaz.", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Drag and drop upload priloga
        private void dataGridViewPrilog_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
                Console.WriteLine("Datoteka je prebačena, efekat postavljen na Copy.");
            }
            else
            {
                e.Effect = DragDropEffects.None;
                Console.WriteLine("Nije pronađena datoteka, efekat postavljen na None.");
            }
        }

        private void dataGridViewPrilog_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            foreach (string file in files)
            {
                try
                {
                    byte[] fileData = File.ReadAllBytes(file);
                    string fileName = Path.GetFileName(file);

                    UcitajTipPriloga(fileData, fileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Greska prilikom ucitavanja fajla: " + ex.Message);
                }
            }
        }

        public void UcitajTipPriloga(byte[] fileData, string fileName)
        {
            dataGridViewPrilog.Rows.Add(new object[] { fileData, fileName, "Novi Prilog" });
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOsvezi_Click(object sender, EventArgs e)
        {
            UcitajPrilogeKandidata(kandidatID);
        }
    }
}

