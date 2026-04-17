namespace Erronka3
{
    partial class MenuWebgunea
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
            this.btnAtzera = new System.Windows.Forms.Button();
            this.dgvWebgunekoBalorazioak = new System.Windows.Forms.DataGridView();
            this.lblIzenburua = new System.Windows.Forms.Label();
            this.dgvWebgunekoIritziak = new System.Windows.Forms.DataGridView();
            this.lblPdfSorrera = new System.Windows.Forms.Label();
            this.btnPdf = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWebgunekoBalorazioak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWebgunekoIritziak)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAtzera
            // 
            this.btnAtzera.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtzera.Location = new System.Drawing.Point(671, 379);
            this.btnAtzera.Name = "btnAtzera";
            this.btnAtzera.Size = new System.Drawing.Size(117, 46);
            this.btnAtzera.TabIndex = 14;
            this.btnAtzera.Text = "Atzera";
            this.btnAtzera.UseVisualStyleBackColor = true;
            this.btnAtzera.Click += new System.EventHandler(this.btnAtzera_Click);
            // 
            // dgvWebgunekoBalorazioak
            // 
            this.dgvWebgunekoBalorazioak.AllowUserToAddRows = false;
            this.dgvWebgunekoBalorazioak.AllowUserToDeleteRows = false;
            this.dgvWebgunekoBalorazioak.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWebgunekoBalorazioak.Location = new System.Drawing.Point(12, 112);
            this.dgvWebgunekoBalorazioak.Name = "dgvWebgunekoBalorazioak";
            this.dgvWebgunekoBalorazioak.ReadOnly = true;
            this.dgvWebgunekoBalorazioak.RowHeadersWidth = 51;
            this.dgvWebgunekoBalorazioak.Size = new System.Drawing.Size(360, 214);
            this.dgvWebgunekoBalorazioak.TabIndex = 13;
            // 
            // lblIzenburua
            // 
            this.lblIzenburua.AutoSize = true;
            this.lblIzenburua.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIzenburua.Location = new System.Drawing.Point(113, 21);
            this.lblIzenburua.Name = "lblIzenburua";
            this.lblIzenburua.Size = new System.Drawing.Size(575, 38);
            this.lblIzenburua.TabIndex = 12;
            this.lblIzenburua.Text = "WEBGUNEAREN KUDEATZAILEA";
            // 
            // dgvWebgunekoIritziak
            // 
            this.dgvWebgunekoIritziak.AllowUserToAddRows = false;
            this.dgvWebgunekoIritziak.AllowUserToDeleteRows = false;
            this.dgvWebgunekoIritziak.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWebgunekoIritziak.Location = new System.Drawing.Point(428, 112);
            this.dgvWebgunekoIritziak.Name = "dgvWebgunekoIritziak";
            this.dgvWebgunekoIritziak.ReadOnly = true;
            this.dgvWebgunekoIritziak.RowHeadersWidth = 51;
            this.dgvWebgunekoIritziak.Size = new System.Drawing.Size(360, 214);
            this.dgvWebgunekoIritziak.TabIndex = 15;
            // 
            // lblPdfSorrera
            // 
            this.lblPdfSorrera.AutoSize = true;
            this.lblPdfSorrera.Location = new System.Drawing.Point(70, 379);
            this.lblPdfSorrera.Name = "lblPdfSorrera";
            this.lblPdfSorrera.Size = new System.Drawing.Size(122, 16);
            this.lblPdfSorrera.TabIndex = 16;
            this.lblPdfSorrera.Text = "Datuak gorde (pdf):";
            // 
            // btnPdf
            // 
            this.btnPdf.Location = new System.Drawing.Point(198, 379);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(99, 23);
            this.btnPdf.TabIndex = 17;
            this.btnPdf.Text = "Sortu";
            this.btnPdf.UseVisualStyleBackColor = true;
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            // 
            // MenuWebgunea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPdf);
            this.Controls.Add(this.lblPdfSorrera);
            this.Controls.Add(this.dgvWebgunekoIritziak);
            this.Controls.Add(this.btnAtzera);
            this.Controls.Add(this.dgvWebgunekoBalorazioak);
            this.Controls.Add(this.lblIzenburua);
            this.Name = "MenuWebgunea";
            this.Text = "MenuWebgunea";
            ((System.ComponentModel.ISupportInitialize)(this.dgvWebgunekoBalorazioak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWebgunekoIritziak)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAtzera;
        private System.Windows.Forms.DataGridView dgvWebgunekoBalorazioak;
        private System.Windows.Forms.Label lblIzenburua;
        private System.Windows.Forms.DataGridView dgvWebgunekoIritziak;
        private System.Windows.Forms.Label lblPdfSorrera;
        private System.Windows.Forms.Button btnPdf;
    }
}