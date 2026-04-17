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
    public partial class MenuLangilearenAldaketak : Form
    {
        private Kontrol kontrol;
        private Langileak langilea;
        public MenuLangilearenAldaketak(Kontrol k, Langileak l)
        {
            InitializeComponent();
            this.kontrol = k;
            this.langilea = l;
            txtIzena.Text = this.langilea.getIzena();
            txtAbizena.Text = this.langilea.getAbizena();
            txtEmail.Text = this.langilea.getEmail();
            txtPasahitza.Text = this.langilea.getPasahitza();
        }

        private void btnAldaketa_Click(object sender, EventArgs e)
        {
            this.langilea.setIzena(txtIzena.Text);
            this.langilea.setAbizena(txtAbizena.Text);
            this.langilea.setEmail(txtEmail.Text);
            this.langilea.setPasahitza(txtPasahitza.Text);
            if (this.kontrol.langileakAldatu(this.langilea))
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
