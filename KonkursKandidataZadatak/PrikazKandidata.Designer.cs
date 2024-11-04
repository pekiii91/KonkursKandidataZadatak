namespace KonkursKandidataZadatak
{
    partial class PrikazKandidata
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
            this.dataGridViewKandidati = new System.Windows.Forms.DataGridView();
            this.btnOsveži = new System.Windows.Forms.Button();
            this.btnObriši = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.labelImePrezime = new System.Windows.Forms.Label();
            this.textBoxPretraga = new System.Windows.Forms.TextBox();
            this.btnIzmeniKandidata = new System.Windows.Forms.Button();
            this.btnIstorijaPromenaStatusa = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.linkLabelDodatniLinkovi = new System.Windows.Forms.LinkLabel();
            this.btnPrilog = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKandidati)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewKandidati
            // 
            this.dataGridViewKandidati.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKandidati.Location = new System.Drawing.Point(12, 82);
            this.dataGridViewKandidati.Name = "dataGridViewKandidati";
            this.dataGridViewKandidati.RowHeadersWidth = 51;
            this.dataGridViewKandidati.RowTemplate.Height = 24;
            this.dataGridViewKandidati.Size = new System.Drawing.Size(1839, 212);
            this.dataGridViewKandidati.TabIndex = 0;
            this.dataGridViewKandidati.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKandidati_CellClick);
            this.dataGridViewKandidati.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKandidati_CellEndEdit_1);
            this.dataGridViewKandidati.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridViewKandidati_RowPrePaint);
            // 
            // btnOsveži
            // 
            this.btnOsveži.Location = new System.Drawing.Point(151, 326);
            this.btnOsveži.Name = "btnOsveži";
            this.btnOsveži.Size = new System.Drawing.Size(117, 56);
            this.btnOsveži.TabIndex = 5;
            this.btnOsveži.Text = "Osveži Kandidata";
            this.btnOsveži.UseVisualStyleBackColor = true;
            this.btnOsveži.Click += new System.EventHandler(this.btnOsveži_Click);
            // 
            // btnObriši
            // 
            this.btnObriši.Location = new System.Drawing.Point(352, 326);
            this.btnObriši.Name = "btnObriši";
            this.btnObriši.Size = new System.Drawing.Size(115, 56);
            this.btnObriši.TabIndex = 6;
            this.btnObriši.Text = "Obriši Kandidata";
            this.btnObriši.UseVisualStyleBackColor = true;
            this.btnObriši.Click += new System.EventHandler(this.btnObriši_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(1723, 411);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 40);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "Ok";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // labelImePrezime
            // 
            this.labelImePrezime.AutoEllipsis = true;
            this.labelImePrezime.AutoSize = true;
            this.labelImePrezime.Location = new System.Drawing.Point(41, 23);
            this.labelImePrezime.MaximumSize = new System.Drawing.Size(300, 300);
            this.labelImePrezime.Name = "labelImePrezime";
            this.labelImePrezime.Size = new System.Drawing.Size(136, 32);
            this.labelImePrezime.TabIndex = 8;
            this.labelImePrezime.Text = "Pretraga Kandidata: \r\nIme, Prezime ili JMBG\r\n";
            // 
            // textBoxPretraga
            // 
            this.textBoxPretraga.Location = new System.Drawing.Point(254, 25);
            this.textBoxPretraga.Multiline = true;
            this.textBoxPretraga.Name = "textBoxPretraga";
            this.textBoxPretraga.Size = new System.Drawing.Size(303, 30);
            this.textBoxPretraga.TabIndex = 9;
            this.textBoxPretraga.TextChanged += new System.EventHandler(this.textBoxPretraga_TextChanged);
            // 
            // btnIzmeniKandidata
            // 
            this.btnIzmeniKandidata.Location = new System.Drawing.Point(537, 326);
            this.btnIzmeniKandidata.Name = "btnIzmeniKandidata";
            this.btnIzmeniKandidata.Size = new System.Drawing.Size(145, 56);
            this.btnIzmeniKandidata.TabIndex = 10;
            this.btnIzmeniKandidata.Text = "Izmeni Kandidata";
            this.btnIzmeniKandidata.UseVisualStyleBackColor = true;
            this.btnIzmeniKandidata.Click += new System.EventHandler(this.btnIzmeniKandidata_Click);
            // 
            // btnIstorijaPromenaStatusa
            // 
            this.btnIstorijaPromenaStatusa.Location = new System.Drawing.Point(754, 326);
            this.btnIstorijaPromenaStatusa.Name = "btnIstorijaPromenaStatusa";
            this.btnIstorijaPromenaStatusa.Size = new System.Drawing.Size(145, 56);
            this.btnIstorijaPromenaStatusa.TabIndex = 11;
            this.btnIstorijaPromenaStatusa.Text = "Istorija Promena Statusa Statusa";
            this.btnIstorijaPromenaStatusa.UseVisualStyleBackColor = true;
            this.btnIstorijaPromenaStatusa.Click += new System.EventHandler(this.btnIstorijaPromenaStatusa_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(965, 326);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(102, 56);
            this.btnExport.TabIndex = 12;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // linkLabelDodatniLinkovi
            // 
            this.linkLabelDodatniLinkovi.Location = new System.Drawing.Point(0, 0);
            this.linkLabelDodatniLinkovi.Name = "linkLabelDodatniLinkovi";
            this.linkLabelDodatniLinkovi.Size = new System.Drawing.Size(100, 23);
            this.linkLabelDodatniLinkovi.TabIndex = 0;
            // 
            // btnPrilog
            // 
            this.btnPrilog.Location = new System.Drawing.Point(1093, 326);
            this.btnPrilog.Name = "btnPrilog";
            this.btnPrilog.Size = new System.Drawing.Size(100, 56);
            this.btnPrilog.TabIndex = 13;
            this.btnPrilog.Text = "Prilog";
            this.btnPrilog.UseVisualStyleBackColor = true;
            this.btnPrilog.Click += new System.EventHandler(this.btnPrilog_Click);
            // 
            // PrikazKandidata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1863, 463);
            this.Controls.Add(this.btnPrilog);
            this.Controls.Add(this.linkLabelDodatniLinkovi);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnIstorijaPromenaStatusa);
            this.Controls.Add(this.btnIzmeniKandidata);
            this.Controls.Add(this.textBoxPretraga);
            this.Controls.Add(this.labelImePrezime);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnObriši);
            this.Controls.Add(this.btnOsveži);
            this.Controls.Add(this.dataGridViewKandidati);
            this.MaximizeBox = false;
            this.Name = "PrikazKandidata";
            this.Text = "Prikaz Kandidata";
            this.Load += new System.EventHandler(this.PrikazKandidata_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKandidati)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewKandidati;
        private System.Windows.Forms.Button btnOsveži;
        private System.Windows.Forms.Button btnObriši;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label labelImePrezime;
        private System.Windows.Forms.TextBox textBoxPretraga;
        private System.Windows.Forms.Button btnIzmeniKandidata;
        private System.Windows.Forms.Button btnIstorijaPromenaStatusa;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.LinkLabel linkLabelDodatniLinkovi;
        private System.Windows.Forms.Button btnPrilog;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}