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
    public partial class MenuErabiltzaileakIkusi : Form
    {
        private Kontrol kontrol;
        private List<Erabiltzaileak> lista;
        private Langileak erabiltzailea;
        public MenuErabiltzaileakIkusi(Kontrol k, Langileak l)
        {
            InitializeComponent();
            this.kontrol = k;
            this.erabiltzailea = l;
            lista = this.kontrol.erabibltzaileakIkusi(dgvErabiltzaileak);
        }

        private void btnAtzera_Click(object sender, EventArgs e)
        {
            Form menu = new MenuLangileBurua(this.kontrol, this.erabiltzailea);
            this.Hide();
            menu.ShowDialog();
        }
        private void dgvErabiltzaileak_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvErabiltzaileak.Columns[e.ColumnIndex].HeaderText == "EDITATU")
            {
                for (int i = 0; i < this.lista.Count(); i++)
                {
                    if (this.lista[i].getId() == Convert.ToInt32(dgvErabiltzaileak.Rows[e.RowIndex].Cells[0].Value))
                    {
                        Form MenuErabiltzailearenAldaketak = new MenuErabiltzailearenAldaketak(this.lista[i], this.kontrol);
                        MenuErabiltzailearenAldaketak.ShowDialog();
                    }
                }
            }
        }
    }
}
