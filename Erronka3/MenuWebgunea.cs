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
    public partial class MenuWebgunea : Form
    {
        private Kontrol kontrol;
        private Langileak erabiltzailea;
        public MenuWebgunea(Kontrol k, Langileak l)
        {
            InitializeComponent();
            this.kontrol = k;
            this.erabiltzailea = l;
            this.kontrol.webgunekoInformazioaIkusi(dgvWebgunekoBalorazioak, dgvWebgunekoIritziak);
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

        private void btnPdf_Click(object sender, EventArgs e)
        {
            this.kontrol.webgunekoInformazioarenPdfSortu(this.erabiltzailea);
        }
    }
}
