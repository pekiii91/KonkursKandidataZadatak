namespace KonkursKandidataZadatak
{
    partial class IstorijaPromeneStatusaKandidata
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
            this.dataGridViewIstorija = new System.Windows.Forms.DataGridView();
            this.btnOsvežiIstoriju = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnDodajPromenuStatusa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIstorija)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewIstorija
            // 
            this.dataGridViewIstorija.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIstorija.Location = new System.Drawing.Point(12, 28);
            this.dataGridViewIstorija.Name = "dataGridViewIstorija";
            this.dataGridViewIstorija.RowHeadersWidth = 51;
            this.dataGridViewIstorija.RowTemplate.Height = 24;
            this.dataGridViewIstorija.Size = new System.Drawing.Size(754, 122);
            this.dataGridViewIstorija.TabIndex = 0;
            // 
            // btnOsvežiIstoriju
            // 
            this.btnOsvežiIstoriju.Location = new System.Drawing.Point(139, 208);
            this.btnOsvežiIstoriju.Name = "btnOsvežiIstoriju";
            this.btnOsvežiIstoriju.Size = new System.Drawing.Size(108, 46);
            this.btnOsvežiIstoriju.TabIndex = 1;
            this.btnOsvežiIstoriju.Text = "Osveži Istoriju";
            this.btnOsvežiIstoriju.UseVisualStyleBackColor = true;
            this.btnOsvežiIstoriju.Click += new System.EventHandler(this.btnOsvežiIstoriju_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(651, 269);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(101, 50);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnDodajPromenuStatusa
            // 
            this.btnDodajPromenuStatusa.Location = new System.Drawing.Point(317, 208);
            this.btnDodajPromenuStatusa.Name = "btnDodajPromenuStatusa";
            this.btnDodajPromenuStatusa.Size = new System.Drawing.Size(131, 46);
            this.btnDodajPromenuStatusa.TabIndex = 3;
            this.btnDodajPromenuStatusa.Text = "Dodaj Promenu Statusa";
            this.btnDodajPromenuStatusa.UseVisualStyleBackColor = true;
            this.btnDodajPromenuStatusa.Click += new System.EventHandler(this.btnDodajPromenuStatusa_Click);
            // 
            // IstorijaPromeneStatusaKandidata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 348);
            this.Controls.Add(this.btnDodajPromenuStatusa);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnOsvežiIstoriju);
            this.Controls.Add(this.dataGridViewIstorija);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "IstorijaPromeneStatusaKandidata";
            this.Text = "IstorijaPromeneStatusaKandidata";
            this.Load += new System.EventHandler(this.IstorijaPromeneStatusaKandidata_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIstorija)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewIstorija;
        private System.Windows.Forms.Button btnOsvežiIstoriju;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnDodajPromenuStatusa;
    }
}