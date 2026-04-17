using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Erronka3
{
    public partial class MenuIndex : Form
    {
        private ArrayList jokoakAgertu = new ArrayList();
        private ArrayList jokoakDesagertu = new ArrayList();
        private Kontrol kontrol;
        private List<Bideojokoak> lista;
        private Langileak erabiltzailea;
        public MenuIndex(Kontrol k, Langileak l)
        {
            InitializeComponent();
            this.kontrol = k;
            this.erabiltzailea = l;
            lista = this.kontrol.bideojokorenGaraiaIkusi(dgvIndexekoJokoak);
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
        private void btnAurreraAgertu_Click(object sender, EventArgs e)
        {
            jokoakAgertu.Add(txtIdAgertu.Text);
            txtIdAgertu.Text = String.Empty;
        }
        private void btnAurreraDesagertu_Click(object sender, EventArgs e)
        {
            jokoakDesagertu.Add(txtIdDesagertu.Text);
            txtIdDesagertu.Text = String.Empty;
        }
        private void btnBidali_Click(object sender, EventArgs e)
        {
            int agertzekoJarri = this.kontrol.indexeanAgertuJokoak(jokoakAgertu, lista);
            int desagertzekoJarri = this.kontrol.indexeanDesagertuJokoak(jokoakDesagertu, lista);
            if (agertzekoJarri == 0 && desagertzekoJarri == 0)
            {
                MessageBox.Show("Ez dira aldaketak egin");
            }
            else if (agertzekoJarri == 0 && desagertzekoJarri != 0 && desagertzekoJarri != -1)
            {
                MessageBox.Show("Ez da ezer agertzeko esan, baina ondo desagertu dira");
            }
            else if (desagertzekoJarri == 0 && agertzekoJarri != 0 && agertzekoJarri != -1)
            {
                MessageBox.Show("Ez da ezer desagertzeko esan, baina ondo agertu dira");
            }
            else if (agertzekoJarri == -1 && desagertzekoJarri != 0 && desagertzekoJarri != -1)
            {
                MessageBox.Show("Agertzerakoan denak ez dira ondo azaldu, baina ondo desagertu dira");
            }
            else if (desagertzekoJarri == -1 && agertzekoJarri != 0 && agertzekoJarri != -1)
            {
                MessageBox.Show("Desagertzerakoan denak ez dira ondo azaldu, baina ondo agertu dira");
            }
            else if (agertzekoJarri == -1 && desagertzekoJarri == -1)
            {
                MessageBox.Show("Hasi dira aldaketak egiten, baina batzuk ez dira aldatu");
            }
            else
            {
                MessageBox.Show("Ondo egin dira aldaketak");
            }
            jokoakAgertu.Clear();
            jokoakDesagertu.Clear();
        }
    }
}
