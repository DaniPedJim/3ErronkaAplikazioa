namespace Erronka3
{
    partial class MenuBideojokoa
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
            this.dgvBideojokoak = new System.Windows.Forms.DataGridView();
            this.lblIzenburua = new System.Windows.Forms.Label();
            this.btnAtzera = new System.Windows.Forms.Button();
            this.lblJokoaGehitu = new System.Windows.Forms.Label();
            this.txtJokoaGehitu = new System.Windows.Forms.TextBox();
            this.btnJokoaGehitu = new System.Windows.Forms.Button();
            this.grBoxJokoaGehitu = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBideojokoak)).BeginInit();
            this.grBoxJokoaGehitu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBideojokoak
            // 
            this.dgvBideojokoak.AllowUserToAddRows = false;
            this.dgvBideojokoak.AllowUserToDeleteRows = false;
            this.dgvBideojokoak.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBideojokoak.Location = new System.Drawing.Point(22, 98);
            this.dgvBideojokoak.Name = "dgvBideojokoak";
            this.dgvBideojokoak.ReadOnly = true;
            this.dgvBideojokoak.RowHeadersWidth = 51;
            this.dgvBideojokoak.Size = new System.Drawing.Size(766, 257);
            this.dgvBideojokoak.TabIndex = 7;
            this.dgvBideojokoak.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBideojokoak_CellContentClick);
            // 
            // lblIzenburua
            // 
            this.lblIzenburua.AutoSize = true;
            this.lblIzenburua.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIzenburua.Location = new System.Drawing.Point(167, 30);
            this.lblIzenburua.Name = "lblIzenburua";
            this.lblIzenburua.Size = new System.Drawing.Size(504, 38);
            this.lblIzenburua.TabIndex = 8;
            this.lblIzenburua.Text = "BIDEOJOKO KUDEATZAILEA";
            // 
            // btnAtzera
            // 
            this.btnAtzera.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtzera.Location = new System.Drawing.Point(671, 392);
            this.btnAtzera.Name = "btnAtzera";
            this.btnAtzera.Size = new System.Drawing.Size(117, 46);
            this.btnAtzera.TabIndex = 9;
            this.btnAtzera.Text = "Atzera";
            this.btnAtzera.UseVisualStyleBackColor = true;
            this.btnAtzera.Click += new System.EventHandler(this.btnAtzera_Click);
            // 
            // lblJokoaGehitu
            // 
            this.lblJokoaGehitu.AutoSize = true;
            this.lblJokoaGehitu.Location = new System.Drawing.Point(15, 31);
            this.lblJokoaGehitu.Name = "lblJokoaGehitu";
            this.lblJokoaGehitu.Size = new System.Drawing.Size(42, 16);
            this.lblJokoaGehitu.TabIndex = 10;
            this.lblJokoaGehitu.Text = "Izena:";
            // 
            // txtJokoaGehitu
            // 
            this.txtJokoaGehitu.Location = new System.Drawing.Point(78, 28);
            this.txtJokoaGehitu.Name = "txtJokoaGehitu";
            this.txtJokoaGehitu.Size = new System.Drawing.Size(126, 22);
            this.txtJokoaGehitu.TabIndex = 11;
            // 
            // btnJokoaGehitu
            // 
            this.btnJokoaGehitu.Location = new System.Drawing.Point(214, 27);
            this.btnJokoaGehitu.Name = "btnJokoaGehitu";
            this.btnJokoaGehitu.Size = new System.Drawing.Size(75, 23);
            this.btnJokoaGehitu.TabIndex = 12;
            this.btnJokoaGehitu.Text = "Aurrera";
            this.btnJokoaGehitu.UseVisualStyleBackColor = true;
            this.btnJokoaGehitu.Click += new System.EventHandler(this.btnJokoaGehitu_Click);
            // 
            // grBoxJokoaGehitu
            // 
            this.grBoxJokoaGehitu.Controls.Add(this.btnJokoaGehitu);
            this.grBoxJokoaGehitu.Controls.Add(this.txtJokoaGehitu);
            this.grBoxJokoaGehitu.Controls.Add(this.lblJokoaGehitu);
            this.grBoxJokoaGehitu.Location = new System.Drawing.Point(184, 368);
            this.grBoxJokoaGehitu.Name = "grBoxJokoaGehitu";
            this.grBoxJokoaGehitu.Size = new System.Drawing.Size(311, 59);
            this.grBoxJokoaGehitu.TabIndex = 13;
            this.grBoxJokoaGehitu.TabStop = false;
            this.grBoxJokoaGehitu.Text = "Jokoak gehitu";
            // 
            // MenuBideojokoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grBoxJokoaGehitu);
            this.Controls.Add(this.btnAtzera);
            this.Controls.Add(this.lblIzenburua);
            this.Controls.Add(this.dgvBideojokoak);
            this.Name = "MenuBideojokoa";
            this.Text = "MenuBideojokoa";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBideojokoak)).EndInit();
            this.grBoxJokoaGehitu.ResumeLayout(false);
            this.grBoxJokoaGehitu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBideojokoak;
        private System.Windows.Forms.Label lblIzenburua;
        private System.Windows.Forms.Button btnAtzera;
        private System.Windows.Forms.Label lblJokoaGehitu;
        private System.Windows.Forms.TextBox txtJokoaGehitu;
        private System.Windows.Forms.Button btnJokoaGehitu;
        private System.Windows.Forms.GroupBox grBoxJokoaGehitu;
    }
}