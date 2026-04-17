namespace Erronka3
{
    partial class MenuErabiltzaileakIkusi
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
            this.dgvErabiltzaileak = new System.Windows.Forms.DataGridView();
            this.lblIzenburua = new System.Windows.Forms.Label();
            this.lblTitulua = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvErabiltzaileak)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAtzera
            // 
            this.btnAtzera.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtzera.Location = new System.Drawing.Point(671, 381);
            this.btnAtzera.Name = "btnAtzera";
            this.btnAtzera.Size = new System.Drawing.Size(117, 46);
            this.btnAtzera.TabIndex = 17;
            this.btnAtzera.Text = "Atzera";
            this.btnAtzera.UseVisualStyleBackColor = true;
            this.btnAtzera.Click += new System.EventHandler(this.btnAtzera_Click);
            // 
            // dgvErabiltzaileak
            // 
            this.dgvErabiltzaileak.AllowUserToAddRows = false;
            this.dgvErabiltzaileak.AllowUserToDeleteRows = false;
            this.dgvErabiltzaileak.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvErabiltzaileak.Location = new System.Drawing.Point(12, 87);
            this.dgvErabiltzaileak.Name = "dgvErabiltzaileak";
            this.dgvErabiltzaileak.ReadOnly = true;
            this.dgvErabiltzaileak.RowHeadersWidth = 51;
            this.dgvErabiltzaileak.Size = new System.Drawing.Size(776, 267);
            this.dgvErabiltzaileak.TabIndex = 16;
            this.dgvErabiltzaileak.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvErabiltzaileak_CellClick);
            // 
            // lblIzenburua
            // 
            this.lblIzenburua.AutoSize = true;
            this.lblIzenburua.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIzenburua.Location = new System.Drawing.Point(113, 23);
            this.lblIzenburua.Name = "lblIzenburua";
            this.lblIzenburua.Size = new System.Drawing.Size(553, 38);
            this.lblIzenburua.TabIndex = 15;
            this.lblIzenburua.Text = "LANGILEAREN KUDEATZAILEA";
            // 
            // lblTitulua
            // 
            this.lblTitulua.AutoSize = true;
            this.lblTitulua.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulua.Location = new System.Drawing.Point(82, 23);
            this.lblTitulua.Name = "lblTitulua";
            this.lblTitulua.Size = new System.Drawing.Size(653, 38);
            this.lblTitulua.TabIndex = 15;
            this.lblTitulua.Text = "ERABILTZAILEAREN KUDEATZAILEA";
            // 
            // MenuErabiltzaileakIkusi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAtzera);
            this.Controls.Add(this.dgvErabiltzaileak);
            this.Controls.Add(this.lblTitulua);
            this.Controls.Add(this.lblIzenburua);
            this.Name = "MenuErabiltzaileakIkusi";
            this.Text = "MenuErabiltzaileakIkusi";
            ((System.ComponentModel.ISupportInitialize)(this.dgvErabiltzaileak)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAtzera;
        private System.Windows.Forms.DataGridView dgvErabiltzaileak;
        private System.Windows.Forms.Label lblIzenburua;
        private System.Windows.Forms.Label lblTitulua;
    }
}