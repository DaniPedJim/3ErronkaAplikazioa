namespace Erronka3
{
    partial class MenuErabiltzailearenAldaketak
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
            this.lblIzena = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPasahitza = new System.Windows.Forms.Label();
            this.txtIzena = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPasahitza = new System.Windows.Forms.TextBox();
            this.btnAldaketa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIzena
            // 
            this.lblIzena.AutoSize = true;
            this.lblIzena.Location = new System.Drawing.Point(12, 43);
            this.lblIzena.Name = "lblIzena";
            this.lblIzena.Size = new System.Drawing.Size(42, 16);
            this.lblIzena.TabIndex = 0;
            this.lblIzena.Text = "Izena:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(198, 43);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(44, 16);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email:";
            // 
            // lblPasahitza
            // 
            this.lblPasahitza.AutoSize = true;
            this.lblPasahitza.Location = new System.Drawing.Point(392, 42);
            this.lblPasahitza.Name = "lblPasahitza";
            this.lblPasahitza.Size = new System.Drawing.Size(69, 16);
            this.lblPasahitza.TabIndex = 2;
            this.lblPasahitza.Text = "Pasahitza:";
            // 
            // txtIzena
            // 
            this.txtIzena.Location = new System.Drawing.Point(60, 39);
            this.txtIzena.Name = "txtIzena";
            this.txtIzena.Size = new System.Drawing.Size(115, 22);
            this.txtIzena.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(261, 38);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(115, 22);
            this.txtEmail.TabIndex = 4;
            // 
            // txtPasahitza
            // 
            this.txtPasahitza.Location = new System.Drawing.Point(467, 39);
            this.txtPasahitza.Name = "txtPasahitza";
            this.txtPasahitza.Size = new System.Drawing.Size(115, 22);
            this.txtPasahitza.TabIndex = 5;
            // 
            // btnAldaketa
            // 
            this.btnAldaketa.Location = new System.Drawing.Point(216, 84);
            this.btnAldaketa.Name = "btnAldaketa";
            this.btnAldaketa.Size = new System.Drawing.Size(160, 39);
            this.btnAldaketa.TabIndex = 6;
            this.btnAldaketa.Text = "Aldatu";
            this.btnAldaketa.UseVisualStyleBackColor = true;
            this.btnAldaketa.Click += new System.EventHandler(this.btnAldaketa_Click);
            // 
            // MenuErabiltzailearenAldaketak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 146);
            this.Controls.Add(this.btnAldaketa);
            this.Controls.Add(this.txtPasahitza);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtIzena);
            this.Controls.Add(this.lblPasahitza);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblIzena);
            this.Name = "MenuErabiltzailearenAldaketak";
            this.Text = "MenuErabiltzailearenAldaketak";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIzena;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPasahitza;
        private System.Windows.Forms.TextBox txtIzena;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPasahitza;
        private System.Windows.Forms.Button btnAldaketa;
    }
}