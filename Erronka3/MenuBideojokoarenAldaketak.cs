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
    public partial class MenuBideojokoarenAldaketak : Form
    {
        private Kontrol kontrol;
        private Bideojokoak bideojokoa;
        public MenuBideojokoarenAldaketak(Bideojokoak b, Kontrol k)
        {
            InitializeComponent();
            this.bideojokoa = b;
            this.kontrol = k;
            txtIzena.Text = this.bideojokoa.getIzena();
            txtPrezioa.Text = this.bideojokoa.getPrezioa().ToString();
            txtSortzailea.Text = this.bideojokoa.getSortzailea();
            txtGeneroa.Text = this.bideojokoa.getGeneroa();
            txtIrudia.Text = this.bideojokoa.getIrudia();
            txtUrtea.Text = this.bideojokoa.getArgitaratzeUrtea().ToString();
        }

        private void btnAldatu_Click(object sender, EventArgs e)
        {
            this.bideojokoa.setIzena(txtIzena.Text);
            this.bideojokoa.setPrezioa(Convert.ToInt32(txtPrezioa.Text));
            this.bideojokoa.setSortzailea(txtSortzailea.Text);
            this.bideojokoa.setGeneroa(txtGeneroa.Text);
            this.bideojokoa.setIrudia(txtIrudia.Text);
            this.bideojokoa.setArgitaratzeUrtea(Convert.ToInt16(txtUrtea.Text));
            if (this.kontrol.bideojokoakAldatu(this.bideojokoa))
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
