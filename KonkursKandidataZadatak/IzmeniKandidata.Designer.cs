namespace KonkursKandidataZadatak
{
    partial class IzmeniKandidata
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelIme = new System.Windows.Forms.Label();
            this.labelPrezime = new System.Windows.Forms.Label();
            this.labelJMBG = new System.Windows.Forms.Label();
            this.labelDatumRodjenja = new System.Windows.Forms.Label();
            this.btnSačuvaj = new System.Windows.Forms.Button();
            this.textBoxIme = new System.Windows.Forms.TextBox();
            this.textBoxPrezime = new System.Windows.Forms.TextBox();
            this.textBoxJMBG = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.dateTimePickerDatumRodj = new System.Windows.Forms.DateTimePicker();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelTelefon = new System.Windows.Forms.Label();
            this.textBoxTelefon = new System.Windows.Forms.TextBox();
            this.textBoxNapomena = new System.Windows.Forms.TextBox();
            this.labelNapomena = new System.Windows.Forms.Label();
            this.labelDodatniLinkovi = new System.Windows.Forms.Label();
            this.richTextBoxDodatniLinkovi = new System.Windows.Forms.RichTextBox();
            this.labelOcena = new System.Windows.Forms.Label();
            this.numericUpDownOcena = new System.Windows.Forms.NumericUpDown();
            this.textBoxLastUpdate = new System.Windows.Forms.TextBox();
            this.labelLastUpdate = new System.Windows.Forms.Label();
            this.pictureBoxSlika = new System.Windows.Forms.PictureBox();
            this.btnBrisanjeSlike = new System.Windows.Forms.Button();
            this.btnUcitavanjeNoveSlike = new System.Windows.Forms.Button();
            this.errorProviderIzmenaKandidata = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOcena)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSlika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderIzmenaKandidata)).BeginInit();
            this.SuspendLayout();
            // 
            // labelIme
            // 
            this.labelIme.AutoSize = true;
            this.labelIme.Location = new System.Drawing.Point(42, 47);
            this.labelIme.Name = "labelIme";
            this.labelIme.Size = new System.Drawing.Size(32, 16);
            this.labelIme.TabIndex = 0;
            this.labelIme.Text = "Ime:";
            // 
            // labelPrezime
            // 
            this.labelPrezime.AutoSize = true;
            this.labelPrezime.Location = new System.Drawing.Point(39, 96);
            this.labelPrezime.Name = "labelPrezime";
            this.labelPrezime.Size = new System.Drawing.Size(59, 16);
            this.labelPrezime.TabIndex = 1;
            this.labelPrezime.Text = "Prezime:";
            // 
            // labelJMBG
            // 
            this.labelJMBG.AutoSize = true;
            this.labelJMBG.Location = new System.Drawing.Point(42, 150);
            this.labelJMBG.Name = "labelJMBG";
            this.labelJMBG.Size = new System.Drawing.Size(47, 16);
            this.labelJMBG.TabIndex = 2;
            this.labelJMBG.Text = "JMBG:";
            // 
            // labelDatumRodjenja
            // 
            this.labelDatumRodjenja.AutoSize = true;
            this.labelDatumRodjenja.Location = new System.Drawing.Point(42, 192);
            this.labelDatumRodjenja.Name = "labelDatumRodjenja";
            this.labelDatumRodjenja.Size = new System.Drawing.Size(107, 16);
            this.labelDatumRodjenja.TabIndex = 3;
            this.labelDatumRodjenja.Text = "Datum Rodjenja:";
            // 
            // btnSačuvaj
            // 
            this.btnSačuvaj.Location = new System.Drawing.Point(833, 508);
            this.btnSačuvaj.Name = "btnSačuvaj";
            this.btnSačuvaj.Size = new System.Drawing.Size(116, 36);
            this.btnSačuvaj.TabIndex = 4;
            this.btnSačuvaj.Text = "Sačuvaj";
            this.btnSačuvaj.UseVisualStyleBackColor = true;
            this.btnSačuvaj.Click += new System.EventHandler(this.btnSačuvaj_Click);
            // 
            // textBoxIme
            // 
            this.textBoxIme.Location = new System.Drawing.Point(250, 40);
            this.textBoxIme.Name = "textBoxIme";
            this.textBoxIme.Size = new System.Drawing.Size(250, 22);
            this.textBoxIme.TabIndex = 5;
            this.textBoxIme.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxIme_KeyPress);
            // 
            // textBoxPrezime
            // 
            this.textBoxPrezime.Location = new System.Drawing.Point(250, 93);
            this.textBoxPrezime.Name = "textBoxPrezime";
            this.textBoxPrezime.Size = new System.Drawing.Size(250, 22);
            this.textBoxPrezime.TabIndex = 6;
            this.textBoxPrezime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPrezime_KeyPress);
            // 
            // textBoxJMBG
            // 
            this.textBoxJMBG.Location = new System.Drawing.Point(250, 147);
            this.textBoxJMBG.Name = "textBoxJMBG";
            this.textBoxJMBG.Size = new System.Drawing.Size(250, 22);
            this.textBoxJMBG.TabIndex = 7;
            this.textBoxJMBG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxJMBG_KeyPress);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(250, 238);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(250, 22);
            this.textBoxEmail.TabIndex = 8;
            this.textBoxEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxEmail_KeyPress);
            // 
            // dateTimePickerDatumRodj
            // 
            this.dateTimePickerDatumRodj.Location = new System.Drawing.Point(250, 192);
            this.dateTimePickerDatumRodj.Name = "dateTimePickerDatumRodj";
            this.dateTimePickerDatumRodj.Size = new System.Drawing.Size(250, 22);
            this.dateTimePickerDatumRodj.TabIndex = 9;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(42, 244);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(44, 16);
            this.labelEmail.TabIndex = 10;
            this.labelEmail.Text = "Email:";
            // 
            // labelTelefon
            // 
            this.labelTelefon.AutoSize = true;
            this.labelTelefon.Location = new System.Drawing.Point(42, 382);
            this.labelTelefon.Name = "labelTelefon";
            this.labelTelefon.Size = new System.Drawing.Size(56, 16);
            this.labelTelefon.TabIndex = 11;
            this.labelTelefon.Text = "Telefon:";
            // 
            // textBoxTelefon
            // 
            this.textBoxTelefon.Location = new System.Drawing.Point(250, 382);
            this.textBoxTelefon.Name = "textBoxTelefon";
            this.textBoxTelefon.Size = new System.Drawing.Size(250, 22);
            this.textBoxTelefon.TabIndex = 12;
            this.textBoxTelefon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTelefon_KeyPress);
            // 
            // textBoxNapomena
            // 
            this.textBoxNapomena.Location = new System.Drawing.Point(250, 435);
            this.textBoxNapomena.Multiline = true;
            this.textBoxNapomena.Name = "textBoxNapomena";
            this.textBoxNapomena.Size = new System.Drawing.Size(250, 100);
            this.textBoxNapomena.TabIndex = 13;
            this.textBoxNapomena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNapomena_KeyPress);
            // 
            // labelNapomena
            // 
            this.labelNapomena.AutoSize = true;
            this.labelNapomena.Location = new System.Drawing.Point(45, 438);
            this.labelNapomena.Name = "labelNapomena";
            this.labelNapomena.Size = new System.Drawing.Size(78, 16);
            this.labelNapomena.TabIndex = 14;
            this.labelNapomena.Text = "Napomena:";
            // 
            // labelDodatniLinkovi
            // 
            this.labelDodatniLinkovi.AutoSize = true;
            this.labelDodatniLinkovi.Location = new System.Drawing.Point(42, 302);
            this.labelDodatniLinkovi.Name = "labelDodatniLinkovi";
            this.labelDodatniLinkovi.Size = new System.Drawing.Size(34, 16);
            this.labelDodatniLinkovi.TabIndex = 17;
            this.labelDodatniLinkovi.Text = "Link:";
            // 
            // richTextBoxDodatniLinkovi
            // 
            this.richTextBoxDodatniLinkovi.Location = new System.Drawing.Point(250, 285);
            this.richTextBoxDodatniLinkovi.Name = "richTextBoxDodatniLinkovi";
            this.richTextBoxDodatniLinkovi.Size = new System.Drawing.Size(250, 63);
            this.richTextBoxDodatniLinkovi.TabIndex = 18;
            this.richTextBoxDodatniLinkovi.Text = "";
            // 
            // labelOcena
            // 
            this.labelOcena.AutoSize = true;
            this.labelOcena.Location = new System.Drawing.Point(590, 47);
            this.labelOcena.Name = "labelOcena";
            this.labelOcena.Size = new System.Drawing.Size(50, 16);
            this.labelOcena.TabIndex = 19;
            this.labelOcena.Text = "Ocena:";
            // 
            // numericUpDownOcena
            // 
            this.numericUpDownOcena.Location = new System.Drawing.Point(679, 47);
            this.numericUpDownOcena.Name = "numericUpDownOcena";
            this.numericUpDownOcena.Size = new System.Drawing.Size(241, 22);
            this.numericUpDownOcena.TabIndex = 20;
            // 
            // textBoxLastUpdate
            // 
            this.textBoxLastUpdate.Location = new System.Drawing.Point(679, 120);
            this.textBoxLastUpdate.Name = "textBoxLastUpdate";
            this.textBoxLastUpdate.ReadOnly = true;
            this.textBoxLastUpdate.Size = new System.Drawing.Size(241, 22);
            this.textBoxLastUpdate.TabIndex = 22;
            // 
            // labelLastUpdate
            // 
            this.labelLastUpdate.AutoSize = true;
            this.labelLastUpdate.Location = new System.Drawing.Point(543, 120);
            this.labelLastUpdate.Name = "labelLastUpdate";
            this.labelLastUpdate.Size = new System.Drawing.Size(117, 16);
            this.labelLastUpdate.TabIndex = 23;
            this.labelLastUpdate.Text = "Poslednja izmena:";
            // 
            // pictureBoxSlika
            // 
            this.pictureBoxSlika.Location = new System.Drawing.Point(712, 220);
            this.pictureBoxSlika.Name = "pictureBoxSlika";
            this.pictureBoxSlika.Size = new System.Drawing.Size(237, 209);
            this.pictureBoxSlika.TabIndex = 24;
            this.pictureBoxSlika.TabStop = false;
            // 
            // btnBrisanjeSlike
            // 
            this.btnBrisanjeSlike.Location = new System.Drawing.Point(562, 220);
            this.btnBrisanjeSlike.Name = "btnBrisanjeSlike";
            this.btnBrisanjeSlike.Size = new System.Drawing.Size(119, 54);
            this.btnBrisanjeSlike.TabIndex = 25;
            this.btnBrisanjeSlike.Text = "Brisanje Slike";
            this.btnBrisanjeSlike.UseVisualStyleBackColor = true;
            this.btnBrisanjeSlike.Click += new System.EventHandler(this.btnBrisanjeSlike_Click);
            // 
            // btnUcitavanjeNoveSlike
            // 
            this.btnUcitavanjeNoveSlike.Location = new System.Drawing.Point(562, 316);
            this.btnUcitavanjeNoveSlike.Name = "btnUcitavanjeNoveSlike";
            this.btnUcitavanjeNoveSlike.Size = new System.Drawing.Size(119, 56);
            this.btnUcitavanjeNoveSlike.TabIndex = 26;
            this.btnUcitavanjeNoveSlike.Text = "Ucitavanja Nove Slike";
            this.btnUcitavanjeNoveSlike.UseVisualStyleBackColor = true;
            this.btnUcitavanjeNoveSlike.Click += new System.EventHandler(this.btnUcitavanjeNoveSlike_Click);
            // 
            // errorProviderIzmenaKandidata
            // 
            this.errorProviderIzmenaKandidata.ContainerControl = this;
            // 
            // IzmeniKandidata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 566);
            this.Controls.Add(this.btnUcitavanjeNoveSlike);
            this.Controls.Add(this.btnBrisanjeSlike);
            this.Controls.Add(this.pictureBoxSlika);
            this.Controls.Add(this.labelLastUpdate);
            this.Controls.Add(this.textBoxLastUpdate);
            this.Controls.Add(this.numericUpDownOcena);
            this.Controls.Add(this.labelOcena);
            this.Controls.Add(this.richTextBoxDodatniLinkovi);
            this.Controls.Add(this.labelDodatniLinkovi);
            this.Controls.Add(this.labelNapomena);
            this.Controls.Add(this.textBoxNapomena);
            this.Controls.Add(this.textBoxTelefon);
            this.Controls.Add(this.labelTelefon);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.dateTimePickerDatumRodj);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxJMBG);
            this.Controls.Add(this.textBoxPrezime);
            this.Controls.Add(this.textBoxIme);
            this.Controls.Add(this.btnSačuvaj);
            this.Controls.Add(this.labelDatumRodjenja);
            this.Controls.Add(this.labelJMBG);
            this.Controls.Add(this.labelPrezime);
            this.Controls.Add(this.labelIme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "IzmeniKandidata";
            this.Text = "Izmeni Kandidata";
            this.Load += new System.EventHandler(this.IzmeniKandidata_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOcena)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSlika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderIzmenaKandidata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelIme;
        private System.Windows.Forms.Label labelPrezime;
        private System.Windows.Forms.Label labelJMBG;
        private System.Windows.Forms.Label labelDatumRodjenja;
        private System.Windows.Forms.Button btnSačuvaj;
        private System.Windows.Forms.TextBox textBoxIme;
        private System.Windows.Forms.TextBox textBoxPrezime;
        private System.Windows.Forms.TextBox textBoxJMBG;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.DateTimePicker dateTimePickerDatumRodj;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelTelefon;
        private System.Windows.Forms.TextBox textBoxTelefon;
        private System.Windows.Forms.TextBox textBoxNapomena;
        private System.Windows.Forms.Label labelNapomena;
        private System.Windows.Forms.Label labelDodatniLinkovi;
        private System.Windows.Forms.RichTextBox richTextBoxDodatniLinkovi;
        private System.Windows.Forms.Label labelOcena;
        private System.Windows.Forms.NumericUpDown numericUpDownOcena;
        private System.Windows.Forms.TextBox textBoxLastUpdate;
        private System.Windows.Forms.Label labelLastUpdate;
        private System.Windows.Forms.PictureBox pictureBoxSlika;
        private System.Windows.Forms.Button btnBrisanjeSlike;
        private System.Windows.Forms.Button btnUcitavanjeNoveSlike;
        private System.Windows.Forms.ErrorProvider errorProviderIzmenaKandidata;
    }
}