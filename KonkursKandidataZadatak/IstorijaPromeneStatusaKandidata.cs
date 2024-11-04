using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KonkursKandidataZadatak
{
    public partial class IstorijaPromeneStatusaKandidata : Form
    {
        PrikazKandidata prikazKandidata;
        
        private int kandidatID;
        private SqlConnection konekcija;
        private SqlDataAdapter adapterIstorija;
        private SqlDataAdapter adapterStatusi;
        private DataTable dtIstorija;
        private DataTable dtStatusi;


        public IstorijaPromeneStatusaKandidata(int kandidatID)
        {
            InitializeComponent();
            konekcija = new SqlConnection("Data Source=DESKTOP-B3LH9NO;Initial Catalog=KonkursKandidatiDB;Integrated Security=True;Encrypt=False");
            this.kandidatID = kandidatID; 

            dataGridViewIstorija.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewIstorija.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            UcitajStatuse();
            UcitajIstorijuStatusa();
        }

        private void IstorijaPromeneStatusaKandidata_Load(object sender, EventArgs e)
        {
        }

        public void UcitajStatuse() 
        {
            try
            {
                string query = "SELECT StatusID, NazivStatusa FROM StatusKandidata";
                SqlDataAdapter adapterStatusi = new SqlDataAdapter(query, konekcija);
                dtStatusi = new DataTable();
                adapterStatusi.Fill(dtStatusi);

                //ComboBox kolona za status u DataGridView
                DataGridViewComboBoxColumn statusColoumn = new DataGridViewComboBoxColumn
                {
                    DataPropertyName = "StatusID",
                    HeaderText = "Novi Status",
                    DataSource = dtStatusi,
                    DisplayMember = "NazivStatusa",
                    ValueMember = "StatusID",
                    Name = "NoviStatusID",
                };
                dataGridViewIstorija.Columns.Add(statusColoumn);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greska pri ucitavanju statusa: " + ex.Message);
               
            }
        }

        public void UcitajIstorijuStatusa()
        {
            try
            {
                string query = @"SELECT 
                                IstorijaStatusa.IstorijaStatusaID, Kandidat.Ime, Kandidat.Prezime, StatusKandidata.NazivStatusa, IstorijaStatusa.LastUpdate 
                                FROM IstorijaStatusa 
                                JOIN Kandidat ON IstorijaStatusa.KandidatID = Kandidat.KandidatID 
                                JOIN StatusKandidata ON IstorijaStatusa.StatusID = StatusKandidata.StatusID 
                                WHERE IstorijaStatusa.KandidatID = @KandidatID 
                                ORDER BY IstorijaStatusa.LastUpdate DESC";
                using (SqlCommand komanda = new SqlCommand(query, konekcija))
                {
                    komanda.Parameters.AddWithValue("@KandidatID", kandidatID);
                    adapterIstorija = new SqlDataAdapter(komanda);
                    dtIstorija = new DataTable();
                    adapterIstorija.Fill(dtIstorija);

                }

                dataGridViewIstorija.DataSource = dtIstorija; //Prikazivanje podataka

            }
            catch (Exception ex)
            {
                MessageBox.Show("Greska prilikom istorije statusa: " + ex.Message);
                
            }
        }

        private void btnOsvežiIstoriju_Click(object sender, EventArgs e)
        {
            UcitajIstorijuStatusa();
        }

        private void btnDodajPromenuStatusa_Click(object sender, EventArgs e)
        {
            int noviStatusID = Convert.ToInt32(dataGridViewIstorija.CurrentRow.Cells["NoviStatusID"].Value);

            DodajPromenuStatusa(kandidatID, noviStatusID); // Prosledi kandidatID
        }
        private void DodajPromenuStatusa(int kandidatID, int noviStatusID)
        {
            try
            {
                string query = "INSERT INTO IstorijaStatusa (KandidatID, StatusID, LastUpdate) VALUES (@KandidatID, @StatusID, GETDATE())";
                using (SqlCommand komanda = new SqlCommand(query, konekcija))
                {
                    komanda.Parameters.AddWithValue("@KandidatID", kandidatID);
                    komanda.Parameters.AddWithValue("StatusID", noviStatusID);

                    konekcija.Open();
                    komanda.ExecuteNonQuery();
                }


                MessageBox.Show("Status uspesno promenjen!" );
                UcitajIstorijuStatusa();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greska prilikom dodavanja promena statusa: " + ex.Message);
            }
            finally
            {
                konekcija.Close();
            }
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
