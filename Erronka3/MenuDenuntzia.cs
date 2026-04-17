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
    public partial class MenuDenuntzia : Form
    {
        private Kontrol kontrol;
        private List<Iritziak> lista;
        private Langileak erabiltzailea;
        public MenuDenuntzia(Kontrol k, Langileak l)
        {
            InitializeComponent();
            this.kontrol = k;
            this.erabiltzailea = l;
            lista = this.kontrol.denuntziatutakoIritziakIkusi(dgvDenuntzia);
        }
        private void btnAtzera_Click(object sender, EventArgs e)
        {
            Form menu;
            if (this.erabiltzailea.getKargua().Equals("Langilea"))
            {
                menu = new MenuLangilea(this.kontrol, this.erabiltzailea);
            }
            else
            {
                menu = new MenuLangileBurua(this.kontrol, this.erabiltzailea);
            }
            this.Hide();
            menu.ShowDialog();
        }
        private void btnOnartu_Click(object sender, EventArgs e)
        {
            if (this.kontrol.iritziakIkusgaiEz(Convert.ToInt16(txtDenuntziaOnartu.Text), lista))
            {
                MessageBox.Show("Ondo kendu da");
            }
            else
            {
                MessageBox.Show("Arazoren bat gertatu da");
            }
            txtDenuntziaOnartu.Text = String.Empty;
        }
        private void btnDesegin_Click(object sender, EventArgs e)
        {
            if (this.kontrol.iritziakIkusgai(Convert.ToInt16(txtDenuntziaDesegin.Text), lista))
            {
                MessageBox.Show("Ondo kendu da");
            }
            else
            {
                MessageBox.Show("Arazoren bat gertatu da");
            }
            txtDenuntziaDesegin.Text = String.Empty;
        }
    }
}
