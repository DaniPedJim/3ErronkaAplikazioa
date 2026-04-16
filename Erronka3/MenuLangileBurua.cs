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
    public partial class MenuLangileBurua : Form
    {
        private Kontrol kontrol;
        private Langileak erabiltzailea;
        public MenuLangileBurua(Kontrol k, Langileak l)
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
        private void btnBideojokoak_Click(object sender, EventArgs e)
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
        private void btnBlokeatuta_Click(object sender, EventArgs e)
        {
            Form blokeoak = new MenuBlokeatutakoErabiltzaileak(this.kontrol, this.erabiltzailea);
            this.Hide();
            blokeoak.ShowDialog();
        }
        private void btnErabiltzaileak_Click(object sender, EventArgs e)
        {
            Form erabiltzailea = new MenuErabiltzaileakIkusi(this.kontrol, this.erabiltzailea);
            this.Hide();
            erabiltzailea.ShowDialog();
        }
        private void btnLangileak_Click(object sender, EventArgs e)
        {
            Form langileak = new MenuLangileakIkusi(this.kontrol, this.erabiltzailea);
            this.Hide();
            langileak.ShowDialog();
        }
    }
}
