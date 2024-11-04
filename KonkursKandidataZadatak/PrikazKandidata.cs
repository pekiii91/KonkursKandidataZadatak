using OfficeOpenXml;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace KonkursKandidataZadatak
{
    public partial class PrikazKandidata : Form
    {
        Form1 form1;

        private SqlConnection konekcija;
        private SqlDataAdapter adapterKandidat;
        private SqlDataAdapter adapterStatusi;
        private DataTable dtKandidati;
        private DataTable dtStatusi;

        private void PrikazKandidata_Load(object sender, EventArgs e)
        {

        }
        public PrikazKandidata()
        {
            InitializeComponent();
            konekcija = new SqlConnection("Data Source=DESKTOP-B3LH9NO;Initial Catalog=KonkursKandidatiDB;Integrated Security=True;Encrypt=False");
            dataGridViewKandidati.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewKandidati.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            UcitajKandidata(); //Metoda koja ucitava podatke o kandidatima
            UcitajStatusKandidate();
            textBoxPretraga.TextChanged += textBoxPretraga_TextChanged;

            dataGridViewKandidati.RowPrePaint += dataGridViewKandidati_RowPrePaint;
            dataGridViewKandidati.CellEndEdit += dataGridViewKandidati_CellEndEdit_1;


        }

        //Metoda, pretraga po imenu, prezimenu i JMBG
        private void textBoxPretraga_TextChanged(object sender, EventArgs e)
        {
            if (dtKandidati != null)
            {
                DataView dataView = new DataView(dtKandidati);

                //filter pretraga po imenu i prezimenu kandidata i JMBG
                dataView.RowFilter = $"Ime LIKE '%{textBoxPretraga.Text}%' OR Prezime LIKE '%{textBoxPretraga.Text}%' OR JMBG LIKE '%{textBoxPretraga.Text}%'";

                dataGridViewKandidati.DataSource = dataView;
            }
        }

        public void Clear()
        {
            textBoxPretraga.Clear();
        }

        //Ucitava podatke o kandidatima u DataGridView
        public void UcitajKandidata()
        {
            try
            {
                string query = "SELECT * FROM Kandidat";
                adapterKandidat = new SqlDataAdapter(query, konekcija);
                dtKandidati = new DataTable();
                adapterKandidat.Fill(dtKandidati);
                dataGridViewKandidati.DataSource = dtKandidati;

            }
            catch (Exception ex)
            {

                MessageBox.Show("Greska pri ucitavanju podataka." + ex.Message);
            }
        }

        //Ucitava podatake o statusima u DataTable za ComboBox u DataGridView
        public void UcitajStatusKandidate()
        {
            try
            {
                string queryStatus = "SELECT StatusID, NazivStatusa FROM StatusKandidata";
                adapterStatusi = new SqlDataAdapter(queryStatus, konekcija);
                dtStatusi = new DataTable();
                adapterStatusi.Fill(dtStatusi);

                //ComboBox kolona za status u DataGridView
                DataGridViewComboBoxColumn statusColoumn = new DataGridViewComboBoxColumn
                {
                    DataPropertyName = "StatusID",
                    HeaderText = "Status",
                    DataSource = dtStatusi,
                    DisplayMember = "NazivStatusa",
                    ValueMember = "StatusID",
                    Name = "StatusID",
                };
                dataGridViewKandidati.Columns.Add(statusColoumn);

            }
            catch (Exception ex)
            {

                MessageBox.Show("Greska pri ucitavanju statusa: " + ex.Message);
            }
        }

        //Dugme za osvezavanje liste kandidata
        private void btnOsveži_Click(object sender, EventArgs e)
        {
            UcitajKandidata();
        }

        //Metoda za brisanje kandidata iz baze podataka
        public void ObrisiKandidata(int kadnidatID)
        {
            try
            {
                string query = "DELETE FROM Kandidat Where KandidatID=@KandidatID ";
                using (SqlCommand komanda = new SqlCommand(query, konekcija))
                {
                    komanda.Parameters.AddWithValue("@KandidatID", kadnidatID);
                    konekcija.Open();
                    komanda.ExecuteNonQuery();
                }

                MessageBox.Show("Kandidat je uspesno obrisan. ", "Obrisi kandidata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UcitajKandidata();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Greska pri brisanje kandidata: " + ex.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally 
            { 
                konekcija.Close(); 
            }
        }

        private void btnObriši_Click(object sender, EventArgs e)
        {
            if(dataGridViewKandidati.SelectedRows.Count > 0)
            {
                int kandidatID = Convert.ToInt32(dataGridViewKandidati.SelectedRows[0].Cells["KandidatID"].Value);
                ObrisiKandidata(kandidatID);
            }
            else
            {
                MessageBox.Show("Izaberite kandidata za brisanje.");
            }
        }
        //Omogucava brzu izmenu statusa i ocene direktno u DataGridView
        private void dataGridViewKandidati_CellEndEdit_1(object sender, DataGridViewCellEventArgs e)
        {
            int kandidatID = Convert.ToInt32(dataGridViewKandidati.Rows[e.RowIndex].Cells["KandidatID"].Value);
            string kolonaIzmenjena = dataGridViewKandidati.Columns[e.ColumnIndex].Name;
            var novaVrednost = dataGridViewKandidati.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;


            if(kolonaIzmenjena == "StatusID")
            {
                try
                {
                    string query = $"UPDATE Kandidat SET {kolonaIzmenjena} = @novaVrednost WHERE KandidatID = @KandidatID";
                    using (SqlCommand command = new SqlCommand(query, konekcija))
                    {
                        command.Parameters.AddWithValue("@novaVrednost", novaVrednost ?? DBNull.Value);
                        command.Parameters.AddWithValue("@KandidatID", kandidatID);
                        konekcija.Open();
                        command.ExecuteNonQuery();
                    }

                   
                    MessageBox.Show("Podaci kandidata su uspesno azurirani." );
                    this.DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Greska pri azuriranju podataka: " + ex.Message);
                }
                finally
                {
                    konekcija.Close();
                }
            }
            else
            {
                MessageBox.Show("Azuriranje nije dozvoljeno za ovu kolonu.");
            }

            
        }

        //Pozivamo Formu IzmeniKandidata
        private void btnIzmeniKandidata_Click(object sender, EventArgs e)
        {
            
            if(dataGridViewKandidati.SelectedRows.Count > 0)
            {
               
                int KandidatID = Convert.ToInt32(dataGridViewKandidati.SelectedRows[0].Cells["KandidatID"].Value);
                string ime = dataGridViewKandidati.SelectedRows[0].Cells["Ime"].Value.ToString();
                string prezime = dataGridViewKandidati.SelectedRows[0].Cells["Prezime"].Value.ToString();
                string jmbg = dataGridViewKandidati.SelectedRows[0].Cells["JMBG"].Value.ToString();
                string email = dataGridViewKandidati.SelectedRows[0].Cells["Email"].Value.ToString();
                DateTime datumRodjenja = Convert.ToDateTime(dataGridViewKandidati.SelectedRows[0].Cells["DatumRodjenja"].Value);
                string link = dataGridViewKandidati.SelectedRows[0].Cells["DodatniLinkovi"].Value.ToString();
                string telefon = dataGridViewKandidati.SelectedRows[0].Cells["Telefon"].Value.ToString();
                string napomena = dataGridViewKandidati.SelectedRows[0].Cells["Napomena"].Value.ToString();
                decimal ocena = Convert.ToDecimal(dataGridViewKandidati.SelectedRows[0].Cells["Ocena"].Value);
                int StatusID = Convert.ToInt32(dataGridViewKandidati.SelectedRows[0].Cells["StatusID"].Value);

                //Kreiramo i otvaramo formu za izmenu kandidata
                IzmeniKandidata izmeniKandidatForm = new IzmeniKandidata(KandidatID, ime, prezime, ocena, jmbg,
                                email, datumRodjenja, link, telefon, napomena);
                
                if (izmeniKandidatForm.ShowDialog() == DialogResult.OK)
                {
                    UcitajKandidata();
                }
            }
            else
            {
                MessageBox.Show("Izaberite kandidata za izmenu");
            }
        }

        // Pozivamo Formu IstorijaPromenaStatusaKandidata
        private void btnIstorijaPromenaStatusa_Click(object sender, EventArgs e)
        {
            if (dataGridViewKandidati.SelectedRows.Count > 0)
            {
                int kandidatID = Convert.ToInt32(dataGridViewKandidati.SelectedRows[0].Cells["KandidatID"].Value);
                IstorijaPromeneStatusaKandidata istorijaStatusaForm = new IstorijaPromeneStatusaKandidata(kandidatID);
                istorijaStatusaForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Molimo izaberite kandidata.");
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Za promenu boje reda na osnovu Statusa. Omogucava promenu boje svake tabele
        private void dataGridViewKandidati_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            var cellValue = dataGridViewKandidati.Rows[e.RowIndex].Cells["StatusID"].Value;

            if (cellValue != null && cellValue != DBNull.Value && int.TryParse(cellValue.ToString(), out int statusID))
            {
                // Postavljanje boje na osnovu vrednosti StatusID
                switch (statusID)
                {
                    case 1:
                        dataGridViewKandidati.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightBlue;
                        break;
                    case 2:
                        dataGridViewKandidati.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightSkyBlue;
                        break;
                    case 3:
                        dataGridViewKandidati.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightCoral;
                        break;
                    default:
                        dataGridViewKandidati.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                        break;
                }
            }
            else
            {
                dataGridViewKandidati.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
            }
        }

        // Izvoz podataka u XLSX fajl
        public void ExportToExcel()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("Kandidati");

                for(int i = 0; i < dataGridViewKandidati.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1].Value = dataGridViewKandidati.Columns[i].HeaderText;
                }

                for(int i=0; i < dataGridViewKandidati.Rows.Count; i++)
                {
                    for(int j = 0; j < dataGridViewKandidati.Columns.Count; j++)
                    {
                        worksheet.Cells[i+2, j+1].Value = dataGridViewKandidati.Rows[i].Cells[j].Value?.ToString();
                    }
                }

                worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();

             
                using (var saveFileDialog = new SaveFileDialog { Filter = "Excel Files|*.xlsx", FileName="Kandidati.xlsx" })
                {
                    if(saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllBytes(saveFileDialog.FileName, package.GetAsByteArray());
                        MessageBox.Show("Podaci su uspesno ubaceni u Excel fajl.", "Oke", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        private void btnExport_Click(object sender, EventArgs e)
        {
            ExportToExcel();
        }

        //Otvaranja Dodatnih Linkova u Browser-u
        private void dataGridViewKandidati_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int linkColumnIndex = dataGridViewKandidati.Columns["DodatniLinkovi"].Index;

            if (e.ColumnIndex == linkColumnIndex && e.RowIndex >= 0)
            {
                string url = dataGridViewKandidati.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString();

                if (!string.IsNullOrEmpty(url))
                {
                    if (!url.StartsWith("http://") && !url.StartsWith("https://"))
                    {
                        url = "https://" + url;
                    }

                    try
                    {
                        Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Došlo je do greške prilikom otvaranja linka: " + ex.Message);
                    }

                }
            }
        }

        //Poziv formu Prilog
        private void btnPrilog_Click(object sender, EventArgs e)
        {
            
            if (dataGridViewKandidati.SelectedRows.Count > 0)
            {
                int kandidatID = Convert.ToInt32(dataGridViewKandidati.SelectedRows[0].Cells["KandidatID"].Value);
                Prilog prilogForm = new Prilog(kandidatID);
                prilogForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Molimo izaberite kandidata, pre otvaranja forme za prilog.");
            }

        }

        
    }
}
