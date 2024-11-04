namespace KonkursKandidataZadatak
{
    partial class Form1
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
            this.btnKandidat = new System.Windows.Forms.Button();
            this.btnPrikazKandidata = new System.Windows.Forms.Button();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKandidat
            // 
            this.btnKandidat.Location = new System.Drawing.Point(75, 44);
            this.btnKandidat.Name = "btnKandidat";
            this.btnKandidat.Size = new System.Drawing.Size(91, 42);
            this.btnKandidat.TabIndex = 0;
            this.btnKandidat.Text = "Kandidat";
            this.btnKandidat.UseVisualStyleBackColor = true;
            this.btnKandidat.Click += new System.EventHandler(this.btnKandidat_Click);
            // 
            // btnPrikazKandidata
            // 
            this.btnPrikazKandidata.Location = new System.Drawing.Point(75, 108);
            this.btnPrikazKandidata.Name = "btnPrikazKandidata";
            this.btnPrikazKandidata.Size = new System.Drawing.Size(91, 53);
            this.btnPrikazKandidata.TabIndex = 1;
            this.btnPrikazKandidata.Text = "Prikaz Kandidata";
            this.btnPrikazKandidata.UseVisualStyleBackColor = true;
            this.btnPrikazKandidata.Click += new System.EventHandler(this.btnPrikazKandidata_Click);
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.Location = new System.Drawing.Point(176, 217);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(104, 48);
            this.btnIzlaz.TabIndex = 3;
            this.btnIzlaz.Text = "Izlaz";
            this.btnIzlaz.UseVisualStyleBackColor = true;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 275);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.btnPrikazKandidata);
            this.Controls.Add(this.btnKandidat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Konkurs Kandidata";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKandidat;
        private System.Windows.Forms.Button btnPrikazKandidata;
        private System.Windows.Forms.Button btnIzlaz;
    }
}

