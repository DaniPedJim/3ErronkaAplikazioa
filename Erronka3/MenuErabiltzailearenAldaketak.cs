using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Erronka3
{
    public partial class MenuErabiltzailearenAldaketak : Form
    {
        private Kontrol kontrol;
        private Erabiltzaileak era;
        public MenuErabiltzailearenAldaketak(Erabiltzaileak e, Kontrol kontrol)
        {
            InitializeComponent();
            this.kontrol = kontrol;
            this.era = e;
            txtIzena.Text = this.era.getIzena();
            txtEmail.Text = this.era.getEmail();
            txtPasahitza.Text = this.era.getPasahitza();
        }

        private void btnAldaketa_Click(object sender, EventArgs e)
        {
            this.era.setIzena(txtIzena.Text);
            this.era.setEmail(txtEmail.Text);
            this.era.setPasahitza(txtPasahitza.Text);
            if (this.kontrol.erabiltzaileaAldatu(this.era))
            {
                MessageBox.Show("Ondo egin dira aldaketak");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Akatsen bat gertatu da aldaketak egiterakoan");
            }
        }
    }
}
