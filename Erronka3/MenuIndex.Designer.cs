namespace Erronka3
{
    partial class MenuIndex
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
            this.lblIzenburua = new System.Windows.Forms.Label();
            this.btnAtzera = new System.Windows.Forms.Button();
            this.dgvIndexekoJokoak = new System.Windows.Forms.DataGridView();
            this.lblIdAgertu = new System.Windows.Forms.Label();
            this.btnAurreraAgertu = new System.Windows.Forms.Button();
            this.txtIdAgertu = new System.Windows.Forms.TextBox();
            this.btnAurreraDesagertu = new System.Windows.Forms.Button();
            this.txtIdDesagertu = new System.Windows.Forms.TextBox();
            this.lblIdDesagertu = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBidali = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIndexekoJokoak)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIzenburua
            // 
            this.lblIzenburua.AutoSize = true;
            this.lblIzenburua.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIzenburua.Location = new System.Drawing.Point(207, 38);
            this.lblIzenburua.Name = "lblIzenburua";
            this.lblIzenburua.Size = new System.Drawing.Size(410, 38);
            this.lblIzenburua.TabIndex = 9;
            this.lblIzenburua.Text = "INDEX KUDEATZAILEA";
            // 
            // btnAtzera
            // 
            this.btnAtzera.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtzera.Location = new System.Drawing.Point(671, 392);
            this.btnAtzera.Name = "btnAtzera";
            this.btnAtzera.Size = new System.Drawing.Size(117, 46);
            this.btnAtzera.TabIndex = 11;
            this.btnAtzera.Text = "Atzera";
            this.btnAtzera.UseVisualStyleBackColor = true;
            this.btnAtzera.Click += new System.EventHandler(this.btnAtzera_Click);
            // 
            // dgvIndexekoJokoak
            // 
            this.dgvIndexekoJokoak.AllowUserToAddRows = false;
            this.dgvIndexekoJokoak.AllowUserToDeleteRows = false;
            this.dgvIndexekoJokoak.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIndexekoJokoak.Location = new System.Drawing.Point(12, 98);
            this.dgvIndexekoJokoak.Name = "dgvIndexekoJokoak";
            this.dgvIndexekoJokoak.ReadOnly = true;
            this.dgvIndexekoJokoak.RowHeadersWidth = 51;
            this.dgvIndexekoJokoak.Size = new System.Drawing.Size(390, 340);
            this.dgvIndexekoJokoak.TabIndex = 10;
            // 
            // lblIdAgertu
            // 
            this.lblIdAgertu.AutoSize = true;
            this.lblIdAgertu.Location = new System.Drawing.Point(18, 32);
            this.lblIdAgertu.Name = "lblIdAgertu";
            this.lblIdAgertu.Size = new System.Drawing.Size(21, 16);
            this.lblIdAgertu.TabIndex = 12;
            this.lblIdAgertu.Text = "Id:";
            // 
            // btnAurreraAgertu
            // 
            this.btnAurreraAgertu.Location = new System.Drawing.Point(173, 29);
            this.btnAurreraAgertu.Name = "btnAurreraAgertu";
            this.btnAurreraAgertu.Size = new System.Drawing.Size(75, 23);
            this.btnAurreraAgertu.TabIndex = 14;
            this.btnAurreraAgertu.Text = "Aurrera";
            this.btnAurreraAgertu.UseVisualStyleBackColor = true;
            this.btnAurreraAgertu.Click += new System.EventHandler(this.btnAurreraAgertu_Click);
            // 
            // txtIdAgertu
            // 
            this.txtIdAgertu.Location = new System.Drawing.Point(57, 30);
            this.txtIdAgertu.Name = "txtIdAgertu";
            this.txtIdAgertu.Size = new System.Drawing.Size(100, 22);
            this.txtIdAgertu.TabIndex = 13;
            // 
            // btnAurreraDesagertu
            // 
            this.btnAurreraDesagertu.Location = new System.Drawing.Point(175, 27);
            this.btnAurreraDesagertu.Name = "btnAurreraDesagertu";
            this.btnAurreraDesagertu.Size = new System.Drawing.Size(75, 23);
            this.btnAurreraDesagertu.TabIndex = 17;
            this.btnAurreraDesagertu.Text = "Aurrera";
            this.btnAurreraDesagertu.UseVisualStyleBackColor = true;
            this.btnAurreraDesagertu.Click += new System.EventHandler(this.btnAurreraDesagertu_Click);
            // 
            // txtIdDesagertu
            // 
            this.txtIdDesagertu.Location = new System.Drawing.Point(59, 28);
            this.txtIdDesagertu.Name = "txtIdDesagertu";
            this.txtIdDesagertu.Size = new System.Drawing.Size(100, 22);
            this.txtIdDesagertu.TabIndex = 16;
            // 
            // lblIdDesagertu
            // 
            this.lblIdDesagertu.AutoSize = true;
            this.lblIdDesagertu.Location = new System.Drawing.Point(20, 30);
            this.lblIdDesagertu.Name = "lblIdDesagertu";
            this.lblIdDesagertu.Size = new System.Drawing.Size(21, 16);
            this.lblIdDesagertu.TabIndex = 15;
            this.lblIdDesagertu.Text = "Id:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAurreraAgertu);
            this.groupBox1.Controls.Add(this.txtIdAgertu);
            this.groupBox1.Controls.Add(this.lblIdAgertu);
            this.groupBox1.Location = new System.Drawing.Point(477, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 80);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Indexean agertzeko";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAurreraDesagertu);
            this.groupBox2.Controls.Add(this.txtIdDesagertu);
            this.groupBox2.Controls.Add(this.lblIdDesagertu);
            this.groupBox2.Location = new System.Drawing.Point(475, 253);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(270, 68);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Indexean desagertzeko";
            // 
            // btnBidali
            // 
            this.btnBidali.Location = new System.Drawing.Point(534, 341);
            this.btnBidali.Name = "btnBidali";
            this.btnBidali.Size = new System.Drawing.Size(138, 32);
            this.btnBidali.TabIndex = 20;
            this.btnBidali.Text = "Aldaketak egin";
            this.btnBidali.UseVisualStyleBackColor = true;
            this.btnBidali.Click += new System.EventHandler(this.btnBidali_Click);
            // 
            // MenuIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBidali);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAtzera);
            this.Controls.Add(this.dgvIndexekoJokoak);
            this.Controls.Add(this.lblIzenburua);
            this.Name = "MenuIndex";
            this.Text = "MenuIndex";
            ((System.ComponentModel.ISupportInitialize)(this.dgvIndexekoJokoak)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIzenburua;
        private System.Windows.Forms.Button btnAtzera;
        private System.Windows.Forms.DataGridView dgvIndexekoJokoak;
        private System.Windows.Forms.Label lblIdAgertu;
        private System.Windows.Forms.Button btnAurreraAgertu;
        private System.Windows.Forms.TextBox txtIdAgertu;
        private System.Windows.Forms.Button btnAurreraDesagertu;
        private System.Windows.Forms.TextBox txtIdDesagertu;
        private System.Windows.Forms.Label lblIdDesagertu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBidali;
    }
}