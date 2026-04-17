namespace Erronka3
{
    partial class MenuBlokeatutakoErabiltzaileak
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
            this.dgvBlokeoak = new System.Windows.Forms.DataGridView();
            this.lblTitulua = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnBlokeatu = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBlokeoak)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAtzera
            // 
            this.btnAtzera.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtzera.Location = new System.Drawing.Point(671, 381);
            this.btnAtzera.Name = "btnAtzera";
            this.btnAtzera.Size = new System.Drawing.Size(117, 46);
            this.btnAtzera.TabIndex = 23;
            this.btnAtzera.Text = "Atzera";
            this.btnAtzera.UseVisualStyleBackColor = true;
            this.btnAtzera.Click += new System.EventHandler(this.btnAtzera_Click);
            // 
            // dgvBlokeoak
            // 
            this.dgvBlokeoak.AllowUserToAddRows = false;
            this.dgvBlokeoak.AllowUserToDeleteRows = false;
            this.dgvBlokeoak.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBlokeoak.Location = new System.Drawing.Point(12, 87);
            this.dgvBlokeoak.Name = "dgvBlokeoak";
            this.dgvBlokeoak.ReadOnly = true;
            this.dgvBlokeoak.RowHeadersWidth = 51;
            this.dgvBlokeoak.Size = new System.Drawing.Size(527, 340);
            this.dgvBlokeoak.TabIndex = 22;
            // 
            // lblTitulua
            // 
            this.lblTitulua.AutoSize = true;
            this.lblTitulua.Font = new System.Drawing.Font("Times New Roman", 19.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulua.Location = new System.Drawing.Point(-4, 18);
            this.lblTitulua.Name = "lblTitulua";
            this.lblTitulua.Size = new System.Drawing.Size(801, 36);
            this.lblTitulua.TabIndex = 21;
            this.lblTitulua.Text = "ERABILTZAILEAREN BLOKEOAK KUDEATZAILEA";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(39, 33);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 16);
            this.lblId.TabIndex = 24;
            this.lblId.Text = "Id:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(76, 30);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(117, 22);
            this.txtId.TabIndex = 25;
            // 
            // btnBlokeatu
            // 
            this.btnBlokeatu.Location = new System.Drawing.Point(57, 71);
            this.btnBlokeatu.Name = "btnBlokeatu";
            this.btnBlokeatu.Size = new System.Drawing.Size(109, 48);
            this.btnBlokeatu.TabIndex = 26;
            this.btnBlokeatu.Text = "Blokeatu";
            this.btnBlokeatu.UseVisualStyleBackColor = true;
            this.btnBlokeatu.Click += new System.EventHandler(this.btnBlokeatu_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBlokeatu);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.lblId);
            this.groupBox1.Location = new System.Drawing.Point(558, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 129);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            // 
            // MenuBlokeatutakoErabiltzaileak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAtzera);
            this.Controls.Add(this.dgvBlokeoak);
            this.Controls.Add(this.lblTitulua);
            this.Name = "MenuBlokeatutakoErabiltzaileak";
            this.Text = "MenuBlokeatutakoErabiltzaileak";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBlokeoak)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAtzera;
        private System.Windows.Forms.DataGridView dgvBlokeoak;
        private System.Windows.Forms.Label lblTitulua;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnBlokeatu;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}