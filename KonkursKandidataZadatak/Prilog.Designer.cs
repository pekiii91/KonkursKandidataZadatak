namespace KonkursKandidataZadatak
{
    partial class Prilog
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
            this.textBoxNazivPriloga = new System.Windows.Forms.TextBox();
            this.btnObrisiPrilog = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.dataGridViewPrilog = new System.Windows.Forms.DataGridView();
            this.labelNazivPriloga = new System.Windows.Forms.Label();
            this.btnDodajPrilog = new System.Windows.Forms.Button();
            this.btnPreuzmi = new System.Windows.Forms.Button();
            this.comboBoxTipPriloga = new System.Windows.Forms.ComboBox();
            this.labelTipPriloga = new System.Windows.Forms.Label();
            this.textBoxLastUpdate = new System.Windows.Forms.TextBox();
            this.labelDatumPoslednjeIzmene = new System.Windows.Forms.Label();
            this.btnPrikazPriloga = new System.Windows.Forms.Button();
            this.btnOsvezi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrilog)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNazivPriloga
            // 
            this.textBoxNazivPriloga.Location = new System.Drawing.Point(165, 50);
            this.textBoxNazivPriloga.Name = "textBoxNazivPriloga";
            this.textBoxNazivPriloga.Size = new System.Drawing.Size(205, 22);
            this.textBoxNazivPriloga.TabIndex = 2;
            this.textBoxNazivPriloga.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNazivPriloga_KeyPress);
            // 
            // btnObrisiPrilog
            // 
            this.btnObrisiPrilog.Location = new System.Drawing.Point(395, 366);
            this.btnObrisiPrilog.Name = "btnObrisiPrilog";
            this.btnObrisiPrilog.Size = new System.Drawing.Size(92, 46);
            this.btnObrisiPrilog.TabIndex = 5;
            this.btnObrisiPrilog.Text = "Obriši Prilog";
            this.btnObrisiPrilog.UseVisualStyleBackColor = true;
            this.btnObrisiPrilog.Click += new System.EventHandler(this.btnObrisiPrilog_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(644, 390);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(94, 39);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // dataGridViewPrilog
            // 
            this.dataGridViewPrilog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPrilog.Location = new System.Drawing.Point(37, 184);
            this.dataGridViewPrilog.Name = "dataGridViewPrilog";
            this.dataGridViewPrilog.RowHeadersWidth = 51;
            this.dataGridViewPrilog.RowTemplate.Height = 24;
            this.dataGridViewPrilog.Size = new System.Drawing.Size(650, 134);
            this.dataGridViewPrilog.TabIndex = 7;
            this.dataGridViewPrilog.DragDrop += new System.Windows.Forms.DragEventHandler(this.dataGridViewPrilog_DragDrop);
            this.dataGridViewPrilog.DragEnter += new System.Windows.Forms.DragEventHandler(this.dataGridViewPrilog_DragEnter);
            // 
            // labelNazivPriloga
            // 
            this.labelNazivPriloga.AutoSize = true;
            this.labelNazivPriloga.Location = new System.Drawing.Point(13, 50);
            this.labelNazivPriloga.Name = "labelNazivPriloga";
            this.labelNazivPriloga.Size = new System.Drawing.Size(89, 16);
            this.labelNazivPriloga.TabIndex = 10;
            this.labelNazivPriloga.Text = "Naziv priloga:";
            // 
            // btnDodajPrilog
            // 
            this.btnDodajPrilog.Location = new System.Drawing.Point(254, 366);
            this.btnDodajPrilog.Name = "btnDodajPrilog";
            this.btnDodajPrilog.Size = new System.Drawing.Size(100, 46);
            this.btnDodajPrilog.TabIndex = 11;
            this.btnDodajPrilog.Text = "Dodaj Prilog";
            this.btnDodajPrilog.UseVisualStyleBackColor = true;
            this.btnDodajPrilog.Click += new System.EventHandler(this.btnDodajPrilog_Click);
            // 
            // btnPreuzmi
            // 
            this.btnPreuzmi.Location = new System.Drawing.Point(133, 366);
            this.btnPreuzmi.Name = "btnPreuzmi";
            this.btnPreuzmi.Size = new System.Drawing.Size(75, 46);
            this.btnPreuzmi.TabIndex = 12;
            this.btnPreuzmi.Text = "Preuzmi";
            this.btnPreuzmi.UseVisualStyleBackColor = true;
            this.btnPreuzmi.Click += new System.EventHandler(this.btnPreuzmi_Click);
            // 
            // comboBoxTipPriloga
            // 
            this.comboBoxTipPriloga.FormattingEnabled = true;
            this.comboBoxTipPriloga.Location = new System.Drawing.Point(165, 94);
            this.comboBoxTipPriloga.Name = "comboBoxTipPriloga";
            this.comboBoxTipPriloga.Size = new System.Drawing.Size(205, 24);
            this.comboBoxTipPriloga.TabIndex = 13;
            this.comboBoxTipPriloga.SelectedIndexChanged += new System.EventHandler(this.comboBoxTipPriloga_SelectedIndexChanged);
            // 
            // labelTipPriloga
            // 
            this.labelTipPriloga.AutoSize = true;
            this.labelTipPriloga.Location = new System.Drawing.Point(13, 97);
            this.labelTipPriloga.Name = "labelTipPriloga";
            this.labelTipPriloga.Size = new System.Drawing.Size(75, 16);
            this.labelTipPriloga.TabIndex = 14;
            this.labelTipPriloga.Text = "Tip priloga:";
            // 
            // textBoxLastUpdate
            // 
            this.textBoxLastUpdate.Location = new System.Drawing.Point(196, 146);
            this.textBoxLastUpdate.Name = "textBoxLastUpdate";
            this.textBoxLastUpdate.ReadOnly = true;
            this.textBoxLastUpdate.Size = new System.Drawing.Size(205, 22);
            this.textBoxLastUpdate.TabIndex = 15;
            // 
            // labelDatumPoslednjeIzmene
            // 
            this.labelDatumPoslednjeIzmene.AutoSize = true;
            this.labelDatumPoslednjeIzmene.Location = new System.Drawing.Point(16, 146);
            this.labelDatumPoslednjeIzmene.Name = "labelDatumPoslednjeIzmene";
            this.labelDatumPoslednjeIzmene.Size = new System.Drawing.Size(158, 16);
            this.labelDatumPoslednjeIzmene.TabIndex = 16;
            this.labelDatumPoslednjeIzmene.Text = "Datum poslednje izmene:";
            // 
            // btnPrikazPriloga
            // 
            this.btnPrikazPriloga.Location = new System.Drawing.Point(521, 366);
            this.btnPrikazPriloga.Name = "btnPrikazPriloga";
            this.btnPrikazPriloga.Size = new System.Drawing.Size(85, 46);
            this.btnPrikazPriloga.TabIndex = 17;
            this.btnPrikazPriloga.Text = "Prikaz Priloga";
            this.btnPrikazPriloga.UseVisualStyleBackColor = true;
            this.btnPrikazPriloga.Click += new System.EventHandler(this.btnPrikazPriloga_Click);
            // 
            // btnOsvezi
            // 
            this.btnOsvezi.Location = new System.Drawing.Point(12, 366);
            this.btnOsvezi.Name = "btnOsvezi";
            this.btnOsvezi.Size = new System.Drawing.Size(90, 46);
            this.btnOsvezi.TabIndex = 18;
            this.btnOsvezi.Text = "Osveži Prilog";
            this.btnOsvezi.UseVisualStyleBackColor = true;
            this.btnOsvezi.Click += new System.EventHandler(this.btnOsvezi_Click);
            // 
            // Prilog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 450);
            this.Controls.Add(this.btnOsvezi);
            this.Controls.Add(this.btnPrikazPriloga);
            this.Controls.Add(this.labelDatumPoslednjeIzmene);
            this.Controls.Add(this.textBoxLastUpdate);
            this.Controls.Add(this.labelTipPriloga);
            this.Controls.Add(this.comboBoxTipPriloga);
            this.Controls.Add(this.btnPreuzmi);
            this.Controls.Add(this.btnDodajPrilog);
            this.Controls.Add(this.labelNazivPriloga);
            this.Controls.Add(this.dataGridViewPrilog);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnObrisiPrilog);
            this.Controls.Add(this.textBoxNazivPriloga);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "Prilog";
            this.Text = "Prilog";
            this.Load += new System.EventHandler(this.Prilog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrilog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxNazivPriloga;
        private System.Windows.Forms.Button btnObrisiPrilog;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.DataGridView dataGridViewPrilog;
        private System.Windows.Forms.Label labelNazivPriloga;
        private System.Windows.Forms.Button btnDodajPrilog;
        private System.Windows.Forms.Button btnPreuzmi;
        private System.Windows.Forms.ComboBox comboBoxTipPriloga;
        private System.Windows.Forms.Label labelTipPriloga;
        private System.Windows.Forms.TextBox textBoxLastUpdate;
        private System.Windows.Forms.Label labelDatumPoslednjeIzmene;
        private System.Windows.Forms.Button btnPrikazPriloga;
        private System.Windows.Forms.Button btnOsvezi;
    }
}