namespace KonkursKandidataZadatak
{
    partial class Kandidat
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
            this.labelIme = new System.Windows.Forms.Label();
            this.labelPrezime = new System.Windows.Forms.Label();
            this.labelJMBG = new System.Windows.Forms.Label();
            this.labelDatumRodjenja = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelLink = new System.Windows.Forms.Label();
            this.labelTelefon = new System.Windows.Forms.Label();
            this.labelNapomena = new System.Windows.Forms.Label();
            this.labelLastUpdate = new System.Windows.Forms.Label();
            this.labelOcena = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.textBoxIme = new System.Windows.Forms.TextBox();
            this.textBoxPrezime = new System.Windows.Forms.TextBox();
            this.textBoxJMBG = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxTelefon = new System.Windows.Forms.TextBox();
            this.textBoxNapomena = new System.Windows.Forms.TextBox();
            this.numericUpDownOcena = new System.Windows.Forms.NumericUpDown();
            this.textBoxLastUpdate = new System.Windows.Forms.TextBox();
            this.dateTimePickerDatumRodj = new System.Windows.Forms.DateTimePicker();
            this.buttonDodajKandidata = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.richTextBoxDodatniLinkovi = new System.Windows.Forms.RichTextBox();
            this.pictureBoxSlika = new System.Windows.Forms.PictureBox();
            this.btnUcitavanjeSlike = new System.Windows.Forms.Button();
            this.btnBrisanjeSlike = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOcena)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSlika)).BeginInit();
            this.SuspendLayout();
            // 
            // labelIme
            // 
            this.labelIme.AutoSize = true;
            this.labelIme.Location = new System.Drawing.Point(67, 46);
            this.labelIme.Name = "labelIme";
            this.labelIme.Size = new System.Drawing.Size(32, 16);
            this.labelIme.TabIndex = 0;
            this.labelIme.Text = "Ime:";
            // 
            // labelPrezime
            // 
            this.labelPrezime.AutoSize = true;
            this.labelPrezime.Location = new System.Drawing.Point(67, 83);
            this.labelPrezime.Name = "labelPrezime";
            this.labelPrezime.Size = new System.Drawing.Size(59, 16);
            this.labelPrezime.TabIndex = 1;
            this.labelPrezime.Text = "Prezime:";
            // 
            // labelJMBG
            // 
            this.labelJMBG.AutoSize = true;
            this.labelJMBG.Location = new System.Drawing.Point(67, 118);
            this.labelJMBG.Name = "labelJMBG";
            this.labelJMBG.Size = new System.Drawing.Size(47, 16);
            this.labelJMBG.TabIndex = 2;
            this.labelJMBG.Text = "JMBG:";
            // 
            // labelDatumRodjenja
            // 
            this.labelDatumRodjenja.AutoSize = true;
            this.labelDatumRodjenja.Location = new System.Drawing.Point(67, 156);
            this.labelDatumRodjenja.Name = "labelDatumRodjenja";
            this.labelDatumRodjenja.Size = new System.Drawing.Size(107, 16);
            this.labelDatumRodjenja.TabIndex = 3;
            this.labelDatumRodjenja.Text = "Datum Rodjenja:";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(67, 196);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(47, 16);
            this.labelEmail.TabIndex = 4;
            this.labelEmail.Text = "Email: ";
            // 
            // labelLink
            // 
            this.labelLink.AutoSize = true;
            this.labelLink.Location = new System.Drawing.Point(67, 236);
            this.labelLink.Name = "labelLink";
            this.labelLink.Size = new System.Drawing.Size(34, 16);
            this.labelLink.TabIndex = 5;
            this.labelLink.Text = "Link:";
            // 
            // labelTelefon
            // 
            this.labelTelefon.AutoSize = true;
            this.labelTelefon.Location = new System.Drawing.Point(67, 327);
            this.labelTelefon.Name = "labelTelefon";
            this.labelTelefon.Size = new System.Drawing.Size(56, 16);
            this.labelTelefon.TabIndex = 6;
            this.labelTelefon.Text = "Telefon:";
            // 
            // labelNapomena
            // 
            this.labelNapomena.AutoSize = true;
            this.labelNapomena.Location = new System.Drawing.Point(67, 388);
            this.labelNapomena.Name = "labelNapomena";
            this.labelNapomena.Size = new System.Drawing.Size(78, 16);
            this.labelNapomena.TabIndex = 7;
            this.labelNapomena.Text = "Napomena:";
            // 
            // labelLastUpdate
            // 
            this.labelLastUpdate.AutoSize = true;
            this.labelLastUpdate.Location = new System.Drawing.Point(488, 190);
            this.labelLastUpdate.Name = "labelLastUpdate";
            this.labelLastUpdate.Size = new System.Drawing.Size(117, 16);
            this.labelLastUpdate.TabIndex = 8;
            this.labelLastUpdate.Text = "Poslednje izmena:";
            // 
            // labelOcena
            // 
            this.labelOcena.AutoSize = true;
            this.labelOcena.Location = new System.Drawing.Point(488, 69);
            this.labelOcena.Name = "labelOcena";
            this.labelOcena.Size = new System.Drawing.Size(50, 16);
            this.labelOcena.TabIndex = 10;
            this.labelOcena.Text = "Ocena:";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(0, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 23);
            this.label12.TabIndex = 0;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(488, 124);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(47, 16);
            this.labelStatus.TabIndex = 11;
            this.labelStatus.Text = "Status:";
            // 
            // textBoxIme
            // 
            this.textBoxIme.Location = new System.Drawing.Point(204, 46);
            this.textBoxIme.Name = "textBoxIme";
            this.textBoxIme.Size = new System.Drawing.Size(246, 22);
            this.textBoxIme.TabIndex = 12;
            this.textBoxIme.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxIme_KeyPress);
            // 
            // textBoxPrezime
            // 
            this.textBoxPrezime.Location = new System.Drawing.Point(204, 83);
            this.textBoxPrezime.Name = "textBoxPrezime";
            this.textBoxPrezime.Size = new System.Drawing.Size(246, 22);
            this.textBoxPrezime.TabIndex = 13;
            this.textBoxPrezime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPrezime_KeyPress);
            // 
            // textBoxJMBG
            // 
            this.textBoxJMBG.Location = new System.Drawing.Point(204, 115);
            this.textBoxJMBG.Name = "textBoxJMBG";
            this.textBoxJMBG.Size = new System.Drawing.Size(246, 22);
            this.textBoxJMBG.TabIndex = 14;
            this.textBoxJMBG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxJMBG_KeyPress);
            this.textBoxJMBG.Leave += new System.EventHandler(this.textBoxJMBG_Leave);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(204, 190);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(246, 22);
            this.textBoxEmail.TabIndex = 15;
            this.textBoxEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxEmail_KeyPress);
            // 
            // textBoxTelefon
            // 
            this.textBoxTelefon.Location = new System.Drawing.Point(204, 327);
            this.textBoxTelefon.Name = "textBoxTelefon";
            this.textBoxTelefon.Size = new System.Drawing.Size(246, 22);
            this.textBoxTelefon.TabIndex = 16;
            this.textBoxTelefon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTelefon_KeyPress);
            // 
            // textBoxNapomena
            // 
            this.textBoxNapomena.Location = new System.Drawing.Point(204, 385);
            this.textBoxNapomena.Multiline = true;
            this.textBoxNapomena.Name = "textBoxNapomena";
            this.textBoxNapomena.Size = new System.Drawing.Size(246, 107);
            this.textBoxNapomena.TabIndex = 17;
            this.textBoxNapomena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNapomena_KeyPress);
            // 
            // numericUpDownOcena
            // 
            this.numericUpDownOcena.Location = new System.Drawing.Point(623, 69);
            this.numericUpDownOcena.Name = "numericUpDownOcena";
            this.numericUpDownOcena.Size = new System.Drawing.Size(163, 22);
            this.numericUpDownOcena.TabIndex = 19;
            // 
            // textBoxLastUpdate
            // 
            this.textBoxLastUpdate.Location = new System.Drawing.Point(623, 190);
            this.textBoxLastUpdate.Name = "textBoxLastUpdate";
            this.textBoxLastUpdate.ReadOnly = true;
            this.textBoxLastUpdate.Size = new System.Drawing.Size(241, 22);
            this.textBoxLastUpdate.TabIndex = 21;
            // 
            // dateTimePickerDatumRodj
            // 
            this.dateTimePickerDatumRodj.Location = new System.Drawing.Point(204, 150);
            this.dateTimePickerDatumRodj.Name = "dateTimePickerDatumRodj";
            this.dateTimePickerDatumRodj.Size = new System.Drawing.Size(246, 22);
            this.dateTimePickerDatumRodj.TabIndex = 22;
            // 
            // buttonDodajKandidata
            // 
            this.buttonDodajKandidata.Location = new System.Drawing.Point(508, 427);
            this.buttonDodajKandidata.Name = "buttonDodajKandidata";
            this.buttonDodajKandidata.Size = new System.Drawing.Size(97, 56);
            this.buttonDodajKandidata.TabIndex = 23;
            this.buttonDodajKandidata.Text = "Dodaj Kandidata";
            this.buttonDodajKandidata.UseVisualStyleBackColor = true;
            this.buttonDodajKandidata.Click += new System.EventHandler(this.buttonDodajKandidata_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(869, 473);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 34);
            this.btnOk.TabIndex = 32;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.ForeColor = System.Drawing.Color.Black;
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(623, 121);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(241, 24);
            this.comboBoxStatus.TabIndex = 34;
            this.comboBoxStatus.TabStop = false;
            this.comboBoxStatus.SelectedIndexChanged += new System.EventHandler(this.comboBoxStatusi_SelectedIndexChanged);
            // 
            // richTextBoxDodatniLinkovi
            // 
            this.richTextBoxDodatniLinkovi.Location = new System.Drawing.Point(204, 236);
            this.richTextBoxDodatniLinkovi.Name = "richTextBoxDodatniLinkovi";
            this.richTextBoxDodatniLinkovi.Size = new System.Drawing.Size(246, 61);
            this.richTextBoxDodatniLinkovi.TabIndex = 35;
            this.richTextBoxDodatniLinkovi.Text = "";
            // 
            // pictureBoxSlika
            // 
            this.pictureBoxSlika.Location = new System.Drawing.Point(686, 242);
            this.pictureBoxSlika.Name = "pictureBoxSlika";
            this.pictureBoxSlika.Size = new System.Drawing.Size(232, 211);
            this.pictureBoxSlika.TabIndex = 36;
            this.pictureBoxSlika.TabStop = false;
            // 
            // btnUcitavanjeSlike
            // 
            this.btnUcitavanjeSlike.Location = new System.Drawing.Point(559, 242);
            this.btnUcitavanjeSlike.Name = "btnUcitavanjeSlike";
            this.btnUcitavanjeSlike.Size = new System.Drawing.Size(100, 55);
            this.btnUcitavanjeSlike.TabIndex = 37;
            this.btnUcitavanjeSlike.Text = "Ucitavanje Slike";
            this.btnUcitavanjeSlike.UseVisualStyleBackColor = true;
            this.btnUcitavanjeSlike.Click += new System.EventHandler(this.btnUcitavanjeSlike_Click);
            // 
            // btnBrisanjeSlike
            // 
            this.btnBrisanjeSlike.Location = new System.Drawing.Point(559, 327);
            this.btnBrisanjeSlike.Name = "btnBrisanjeSlike";
            this.btnBrisanjeSlike.Size = new System.Drawing.Size(100, 47);
            this.btnBrisanjeSlike.TabIndex = 38;
            this.btnBrisanjeSlike.Text = "Brisanje Slike";
            this.btnBrisanjeSlike.UseVisualStyleBackColor = true;
            this.btnBrisanjeSlike.Click += new System.EventHandler(this.btnBrisanjeSlike_Click);
            // 
            // Kandidat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 529);
            this.Controls.Add(this.btnBrisanjeSlike);
            this.Controls.Add(this.btnUcitavanjeSlike);
            this.Controls.Add(this.pictureBoxSlika);
            this.Controls.Add(this.richTextBoxDodatniLinkovi);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.buttonDodajKandidata);
            this.Controls.Add(this.dateTimePickerDatumRodj);
            this.Controls.Add(this.textBoxLastUpdate);
            this.Controls.Add(this.numericUpDownOcena);
            this.Controls.Add(this.textBoxNapomena);
            this.Controls.Add(this.textBoxTelefon);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxJMBG);
            this.Controls.Add(this.textBoxPrezime);
            this.Controls.Add(this.textBoxIme);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.labelOcena);
            this.Controls.Add(this.labelLastUpdate);
            this.Controls.Add(this.labelNapomena);
            this.Controls.Add(this.labelTelefon);
            this.Controls.Add(this.labelLink);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelDatumRodjenja);
            this.Controls.Add(this.labelJMBG);
            this.Controls.Add(this.labelPrezime);
            this.Controls.Add(this.labelIme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Kandidat";
            this.Text = "Kandidat";
            this.Load += new System.EventHandler(this.Kandidat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOcena)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSlika)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelIme;
        private System.Windows.Forms.Label labelPrezime;
        private System.Windows.Forms.Label labelJMBG;
        private System.Windows.Forms.Label labelDatumRodjenja;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelLink;
        private System.Windows.Forms.Label labelTelefon;
        private System.Windows.Forms.Label labelNapomena;
        private System.Windows.Forms.Label labelLastUpdate;
        private System.Windows.Forms.Label labelOcena;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.TextBox textBoxIme;
        private System.Windows.Forms.TextBox textBoxPrezime;
        private System.Windows.Forms.TextBox textBoxJMBG;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxTelefon;
        private System.Windows.Forms.TextBox textBoxNapomena;
        private System.Windows.Forms.NumericUpDown numericUpDownOcena;
        private System.Windows.Forms.TextBox textBoxLastUpdate;
        private System.Windows.Forms.DateTimePicker dateTimePickerDatumRodj;
        private System.Windows.Forms.Button buttonDodajKandidata;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.RichTextBox richTextBoxDodatniLinkovi;
        private System.Windows.Forms.PictureBox pictureBoxSlika;
        private System.Windows.Forms.Button btnUcitavanjeSlike;
        private System.Windows.Forms.Button btnBrisanjeSlike;
    }
}