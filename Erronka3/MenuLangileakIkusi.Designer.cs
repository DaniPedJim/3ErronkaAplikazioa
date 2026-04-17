namespace Erronka3
{
    partial class MenuLangileakIkusi
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
            this.dgvLangileakIkusi = new System.Windows.Forms.DataGridView();
            this.lblTitulua = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLangileakIkusi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAtzera
            // 
            this.btnAtzera.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtzera.Location = new System.Drawing.Point(671, 381);
            this.btnAtzera.Name = "btnAtzera";
            this.btnAtzera.Size = new System.Drawing.Size(117, 46);
            this.btnAtzera.TabIndex = 20;
            this.btnAtzera.Text = "Atzera";
            this.btnAtzera.UseVisualStyleBackColor = true;
            this.btnAtzera.Click += new System.EventHandler(this.btnAtzera_Click);
            // 
            // dgvLangileakIkusi
            // 
            this.dgvLangileakIkusi.AllowUserToAddRows = false;
            this.dgvLangileakIkusi.AllowUserToDeleteRows = false;
            this.dgvLangileakIkusi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLangileakIkusi.Location = new System.Drawing.Point(12, 87);
            this.dgvLangileakIkusi.Name = "dgvLangileakIkusi";
            this.dgvLangileakIkusi.ReadOnly = true;
            this.dgvLangileakIkusi.RowHeadersWidth = 51;
            this.dgvLangileakIkusi.Size = new System.Drawing.Size(776, 279);
            this.dgvLangileakIkusi.TabIndex = 19;
            this.dgvLangileakIkusi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLangileakIkusi_CellContentClick);
            // 
            // lblTitulua
            // 
            this.lblTitulua.AutoSize = true;
            this.lblTitulua.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulua.Location = new System.Drawing.Point(113, 23);
            this.lblTitulua.Name = "lblTitulua";
            this.lblTitulua.Size = new System.Drawing.Size(553, 38);
            this.lblTitulua.TabIndex = 18;
            this.lblTitulua.Text = "LANGILEAREN KUDEATZAILEA";
            // 
            // MenuLangileakIkusi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAtzera);
            this.Controls.Add(this.dgvLangileakIkusi);
            this.Controls.Add(this.lblTitulua);
            this.Name = "MenuLangileakIkusi";
            this.Text = "MenuLangileakIkusi";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLangileakIkusi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAtzera;
        private System.Windows.Forms.DataGridView dgvLangileakIkusi;
        private System.Windows.Forms.Label lblTitulua;
    }
}