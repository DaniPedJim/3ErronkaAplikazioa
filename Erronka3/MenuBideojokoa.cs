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
    public partial class MenuBideojokoa : Form
    {
        private String izena, sortzailea, generoa, irudia;
        private int argitaratzeUrtea;
        private double prezioa;
        private Kontrol kontrol;
        private List<Bideojokoak> lista;
        private Langileak erabiltzailea;
        public MenuBideojokoa(Kontrol k, Langileak l)
        {
            InitializeComponent();
            this.kontrol = k;
            this.erabiltzailea = l;
            lista = this.kontrol.bideojokoakIkusi(dgvBideojokoak);
        }

        private void dgvBideojokoak_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvBideojokoak.Columns[e.ColumnIndex].HeaderText == "EDITATU")
            {
                for (int i = 0; i < this.lista.Count(); i++)
                {
                    if (this.lista[i].getId() == Convert.ToInt32(dgvBideojokoak.Rows[e.RowIndex].Cells[0].Value))
                    {
                        Form MenuBideojokoarenAldaketak = new MenuBideojokoarenAldaketak(this.lista[i], this.kontrol);
                        MenuBideojokoarenAldaketak.ShowDialog();
                    }
                }
            }
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
        private void btnJokoaGehitu_Click(object sender, EventArgs e)
        {
            switch (lblJokoaGehitu.Text)
            {
                case "Izena:":
                    this.izena = txtJokoaGehitu.Text;
                    lblJokoaGehitu.Text = "Prezioa:";
                    break;
                case "Prezioa:":
                    this.prezioa = Convert.ToDouble(txtJokoaGehitu.Text);
                    lblJokoaGehitu.Text = "Sortzailea:";
                    break;
                case "Sortzailea:":
                    this.sortzailea = txtJokoaGehitu.Text;
                    lblJokoaGehitu.Text = "Generoa:";
                    break;
                case "Generoa:":
                    this.generoa = txtJokoaGehitu.Text;
                    lblJokoaGehitu.Text = "Irudia:";
                    break;
                case "Irudia:":
                    this.irudia = txtJokoaGehitu.Text;
                    lblJokoaGehitu.Text = "Argitaratze urtea:";
                    break;
                case "Argitaratze urtea:":
                    this.argitaratzeUrtea = Convert.ToInt16(txtJokoaGehitu.Text);
                    lblJokoaGehitu.Text = "Izena:";
                    if (this.kontrol.bideojokoakSortu(izena, prezioa, sortzailea, generoa, irudia, argitaratzeUrtea))
                    {
                        MessageBox.Show("Ondo sortu da");
                    }
                    else
                    {
                        MessageBox.Show("Akatsen bat gertatu da");
                    }
                    break;
            }
            txtJokoaGehitu.Text = "";
        }
    }
}
