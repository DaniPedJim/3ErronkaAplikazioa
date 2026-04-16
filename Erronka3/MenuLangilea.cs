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
    public partial class MenuLangilea : Form
    {
        private Kontrol kontrol;
        private Langileak erabiltzailea;
        public MenuLangilea(Kontrol k, Langileak l)
        {
            InitializeComponent();
            this.kontrol = k;
            this.erabiltzailea = l;
        }
        private void btnDenuntzia_Click(object sender, EventArgs e)
        {
            Form denuntzia = new MenuDenuntzia(this.kontrol, this.erabiltzailea);
            this.Hide();
            denuntzia.ShowDialog();
        }
        private void btnJokoak_Click(object sender, EventArgs e)
        {
            Form bideojokoa = new MenuBideojokoa(this.kontrol, this.erabiltzailea);
            this.Hide();
            bideojokoa.ShowDialog();
        }
        private void btnIndex_Click(object sender, EventArgs e)
        {
            Form index = new MenuIndex(this.kontrol, this.erabiltzailea);
            this.Hide();
            index.ShowDialog();
        }
        private void btnWebgunea_Click(object sender, EventArgs e)
        {
            Form webgunea = new MenuWebgunea(this.kontrol, this.erabiltzailea);
            this.Hide();
            webgunea.ShowDialog();
        }
    }
}
