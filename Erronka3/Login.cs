using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Erronka3
{
    public partial class Login : Form
    {
        private DatuBaseKonexioa konexioa = new DatuBaseKonexioa();
        public Login()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Kontrol k = new Kontrol(this.konexioa);
            Langileak l = k.loginEgin(txtEmail.Text, txtPasahitza.Text);
            if (l is LangileBuruak)
            {
                Form LangileBurua = new MenuLangileBurua(k, l);
                this.Hide();
                LangileBurua.ShowDialog();
            }
            else if (l is Langileak)
            {
                Form Langilea = new MenuLangilea(k, l);
                this.Hide();
                Langilea.ShowDialog();
            }
            else
            {
                MessageBox.Show("Emaila edo pasahitza gaizki idatzi duzu");
            }
        }
    }
}
