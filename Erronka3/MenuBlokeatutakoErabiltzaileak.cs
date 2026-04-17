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
    public partial class MenuBlokeatutakoErabiltzaileak : Form
    {
        private Kontrol kontrol;
        private List<Erabiltzaileak> lista;
        private Langileak erabiltzailea;
        public MenuBlokeatutakoErabiltzaileak(Kontrol k, Langileak l)
        {
            InitializeComponent();
            this.kontrol = k;
            this.erabiltzailea = l;
            lista = this.kontrol.erabiltzailearenBlokeoEgoeraIkusi(dgvBlokeoak);
        }

        private void btnAtzera_Click(object sender, EventArgs e)
        {
            Form menu = new MenuLangileBurua(this.kontrol, this.erabiltzailea);
            this.Hide();
            menu.ShowDialog();
        }

        private void btnBlokeatu_Click(object sender, EventArgs e)
        {
            if (this.kontrol.erabiltzaileBlokeatzekoEgoeraAldatu(Convert.ToInt16(txtId.Text), lista))
            {
                MessageBox.Show("Ondo blokeatu da");
            }
            else
            {
                MessageBox.Show("Arazoren bat gertatu da");
            }
        }
    }
}
