namespace Erronka3
{
    partial class MenuLangilearenAldaketak
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
            this.txtIzena = new System.Windows.Forms.TextBox();
            this.txtAbizena = new System.Windows.Forms.TextBox();
            this.lblAbizena = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtPasahitza = new System.Windows.Forms.TextBox();
            this.lblPasahitza = new System.Windows.Forms.Label();
            this.btnAldaketa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIzena
            // 
            this.lblIzena.AutoSize = true;
            this.lblIzena.Location = new System.Drawing.Point(21, 83);
            this.lblIzena.Name = "lblIzena";
            this.lblIzena.Size = new System.Drawing.Size(42, 16);
            this.lblIzena.TabIndex = 0;
            this.lblIzena.Text = "Izena:";
            // 
            // txtIzena
            // 
            this.txtIzena.Location = new System.Drawing.Point(69, 80);
            this.txtIzena.Name = "txtIzena";
            this.txtIzena.Size = new System.Drawing.Size(100, 22);
            this.txtIzena.TabIndex = 1;
            // 
            // txtAbizena
            // 
            this.txtAbizena.Location = new System.Drawing.Point(246, 80);
            this.txtAbizena.Name = "txtAbizena";
            this.txtAbizena.Size = new System.Drawing.Size(100, 22);
            this.txtAbizena.TabIndex = 3;
            // 
            // lblAbizena
            // 
            this.lblAbizena.AutoSize = true;
            this.lblAbizena.Location = new System.Drawing.Point(176, 85);
            this.lblAbizena.Name = "lblAbizena";
            this.lblAbizena.Size = new System.Drawing.Size(59, 16);
            this.lblAbizena.TabIndex = 2;
            this.lblAbizena.Text = "Abizena:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(416, 79);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 22);
            this.txtEmail.TabIndex = 5;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(360, 83);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(44, 16);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email:";
            // 
            // txtPasahitza
            // 
            this.txtPasahitza.Location = new System.Drawing.Point(605, 81);
            this.txtPasahitza.Name = "txtPasahitza";
            this.txtPasahitza.Size = new System.Drawing.Size(100, 22);
            this.txtPasahitza.TabIndex = 7;
            // 
            // lblPasahitza
            // 
            this.lblPasahitza.AutoSize = true;
            this.lblPasahitza.Location = new System.Drawing.Point(527, 83);
            this.lblPasahitza.Name = "lblPasahitza";
            this.lblPasahitza.Size = new System.Drawing.Size(69, 16);
            this.lblPasahitza.TabIndex = 6;
            this.lblPasahitza.Text = "Pasahitza:";
            // 
            // btnAldaketa
            // 
            this.btnAldaketa.Location = new System.Drawing.Point(311, 126);
            this.btnAldaketa.Name = "btnAldaketa";
            this.btnAldaketa.Size = new System.Drawing.Size(125, 44);
            this.btnAldaketa.TabIndex = 8;
            this.btnAldaketa.Text = "Aldaketa";
            this.btnAldaketa.UseVisualStyleBackColor = true;
            this.btnAldaketa.Click += new System.EventHandler(this.btnAldaketa_Click);
            // 
            // MenuLangilearenAldaketak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 182);
            this.Controls.Add(this.btnAldaketa);
            this.Controls.Add(this.txtPasahitza);
            this.Controls.Add(this.lblPasahitza);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtAbizena);
            this.Controls.Add(this.lblAbizena);
            this.Controls.Add(this.txtIzena);
            this.Controls.Add(this.lblIzena);
            this.Name = "MenuLangilearenAldaketak";
            this.Text = "MenuLangilearenAldaketak";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIzena;
        private System.Windows.Forms.TextBox txtIzena;
        private System.Windows.Forms.TextBox txtAbizena;
        private System.Windows.Forms.Label lblAbizena;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtPasahitza;
        private System.Windows.Forms.Label lblPasahitza;
        private System.Windows.Forms.Button btnAldaketa;
    }
}