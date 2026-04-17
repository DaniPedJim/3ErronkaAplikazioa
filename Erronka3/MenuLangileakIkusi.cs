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
    public partial class MenuLangileakIkusi : Form
    {
        private Kontrol kontrol;
        private List<Langileak> lista;
        private Langileak erabiltzailea;
        public MenuLangileakIkusi(Kontrol k, Langileak l)
        {
            InitializeComponent();
            this.kontrol = k;
            this.erabiltzailea = l;
            lista = this.kontrol.langileakIkusi(dgvLangileakIkusi);
        }

        private void btnAtzera_Click(object sender, EventArgs e)
        {
            Form menu = new MenuLangileBurua(this.kontrol, this.erabiltzailea);
            this.Hide();
            menu.ShowDialog();
        }

        private void dgvLangileakIkusi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvLangileakIkusi.Columns[e.ColumnIndex].HeaderText == "EDITATU")
            {
                for (int i = 0; i < this.lista.Count(); i++)
                {
                    if (this.lista[i].getId() == Convert.ToInt32(dgvLangileakIkusi.Rows[e.RowIndex].Cells[0].Value))
                    {
                        Form MenuLangilearenAldaketak = new MenuLangilearenAldaketak(this.kontrol, this.lista[i]);
                        MenuLangilearenAldaketak.ShowDialog();
                    }
                }
            }
        }
    }
}
