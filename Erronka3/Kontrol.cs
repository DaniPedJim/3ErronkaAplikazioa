using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;

namespace Erronka3
{
    public class Kontrol
    {
        private DatuBaseKonexioa conn;
        public Kontrol(DatuBaseKonexioa konexioa)
        {
            this.conn = konexioa;
        }
        public List<Erabiltzaileak> erabiltzailearenBlokeoEgoeraIkusi(DataGridView dgv)
        {
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.ColumnCount = 4;
            dgv.Columns[0].HeaderText = "ID";
            dgv.Columns[1].HeaderText = "IZENA";
            dgv.Columns[2].HeaderText = "BLOKEOA";
            dgv.Columns[3].HeaderText = "DENUNTZIA KOPURUA";
            List<Erabiltzaileak> lista = Erabiltzaileak.blokeoEgoeraIkusi(this.conn);
            for (int i = 0; i < lista.Count(); i++)
            {
                dgv.Rows.Add(lista[i].getId(), lista[i].getIzena(), lista[i].getBlokeoa(), lista[i].getDenuntziaKop());
            }
            return lista;
        }
        public Boolean erabiltzaileBlokeatzekoEgoeraAldatu(int id, List<Erabiltzaileak> lista)
        {
            Erabiltzaileak e = lista.Find(era => era.getId() == id);
            return e.blokeoaAldatu(this.conn);
        }
        public List<Iritziak> denuntziatutakoIritziakIkusi(DataGridView dgv)
        {
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.ColumnCount = 2;
            dgv.Columns[0].HeaderText = "ID";
            dgv.Columns[1].HeaderText = "IRITZIA";
            List<Iritziak> lista = Iritziak.denuntziatutaDaudenakIkusi(this.conn);
            for (int i = 0; i < lista.Count(); i++)
            {
                dgv.Rows.Add(lista[i].getId(), lista[i].getIritzia());
            }
            return lista;
        }
        public Boolean iritziakIkusgaiEz(int id, List<Iritziak> lista)
        {
            Iritziak i = lista.Find(iri => iri.getId() == id);
            return i.ikusgaiKendu(this.conn);
        }
        public Boolean iritziakIkusgai(int id, List<Iritziak> lista)
        {
            Iritziak i = lista.Find(iri => iri.getId() == id);
            return i.denuntziaKendu(this.conn);
        }
        public List<Erabiltzaileak> erabibltzaileakIkusi(DataGridView dgv)
        {
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.ColumnCount = 5;
            dgv.Columns[0].HeaderText = "ID";
            dgv.Columns[1].HeaderText = "IZENA";
            dgv.Columns[2].HeaderText = "EMAIL";
            dgv.Columns[3].HeaderText = "PASAHITZA";
            dgv.Columns[4].HeaderText = "EDITATU";
            List<Erabiltzaileak> lista = Erabiltzaileak.informazioaIkusi(this.conn);
            for (int i = 0; i < lista.Count(); i++)
            {
                dgv.Rows.Add(lista[i].getId(), lista[i].getIzena(), lista[i].getEmail(), lista[i].getPasahitza(), "X");
            }
            return lista;
        }
        public Boolean erabiltzaileaAldatu(Erabiltzaileak e)
        {
            return e.informazioaAldatu(this.conn);
        }
        public List<Bideojokoak> bideojokorenGaraiaIkusi(DataGridView dgv)
        {
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.ColumnCount = 3;
            dgv.Columns[0].HeaderText = "ID";
            dgv.Columns[1].HeaderText = "IZENA";
            dgv.Columns[2].HeaderText = "DESTAKATUA";
            List<Bideojokoak> lista = Bideojokoak.destakatuaIkusi(this.conn);
            for (int i = 0; i < lista.Count(); i++)
            {
                dgv.Rows.Add(lista[i].getId(), lista[i].getIzena(), lista[i].getDestakatua());
            }
            return lista;
        }
        public int indexeanAgertuJokoak(ArrayList jokoakAgertu, List<Bideojokoak> lista)
        {
            int aldaketa = 0;
            for (int i = 0; i < jokoakAgertu.Count; i++)
            {
                Bideojokoak b = lista.Find(bid => bid.getId() == Convert.ToInt16(jokoakAgertu[i]));
                b.setDestakatua(true);
                if (b.destakatuaAldatu(this.conn))
                {
                    aldaketa++;
                }
            }
            if (aldaketa != jokoakAgertu.Count)
            {
                aldaketa = -1;
            }
            return aldaketa;
        }
        public int indexeanDesagertuJokoak(ArrayList jokoakDesagertu, List<Bideojokoak> lista)
        {
            int aldaketa = 0;
            for (int i = 0; i < jokoakDesagertu.Count; i++)
            {
                Bideojokoak b = lista.Find(bid => bid.getId() == Convert.ToInt16(jokoakDesagertu[i]));
                b.setDestakatua(false);
                if (b.destakatuaAldatu(this.conn))
                {
                    aldaketa++;
                }
            }
            if (aldaketa != jokoakDesagertu.Count)
            {
                aldaketa = -1;
            }
            return aldaketa;
        }
        public List<Bideojokoak> bideojokoakIkusi(DataGridView dgv)
        {
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv.ColumnCount = 9;
            dgv.Columns[0].HeaderText = "ID";
            dgv.Columns[1].HeaderText = "IZENA";
            dgv.Columns[2].HeaderText = "PREZIOA";
            dgv.Columns[3].HeaderText = "SORTZAILEA";
            dgv.Columns[4].HeaderText = "GENEROA";
            dgv.Columns[5].HeaderText = "DESTAKATUA";
            dgv.Columns[6].HeaderText = "IRUDIA";
            dgv.Columns[7].HeaderText = "ARGITARATZE URTEA";
            dgv.Columns[8].HeaderText = "EDITATU";
            List<Bideojokoak> lista = Bideojokoak.informazioaIkusi(this.conn);
            for (int i = 0; i < lista.Count(); i++)
            {
                dgv.Rows.Add(lista[i].getId(), lista[i].getIzena(), lista[i].getPrezioa(), lista[i].getSortzailea(), lista[i].getGeneroa(), lista[i].getDestakatua(), lista[i].getIrudia(), lista[i].getArgitaratzeUrtea(), "X");
            }
            return lista;
        }
        public Boolean bideojokoakAldatu(Bideojokoak b)
        {
            return b.atributuaAldatu(this.conn);
        }
        public Boolean bideojokoakSortu(String izena, double prezioa, String sortzailea, String generoa, String irudia, int argitaratze)
        {
            Bideojokoak b = new Bideojokoak(izena, prezioa, sortzailea, generoa, irudia, argitaratze);
            return b.igo(this.conn);
        }

        public List<Langileak> langileakIkusi(DataGridView dgv)
        {
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.ColumnCount = 6;
            dgv.Columns[0].HeaderText = "ID";
            dgv.Columns[1].HeaderText = "IZENA";
            dgv.Columns[2].HeaderText = "ABIZENA";
            dgv.Columns[3].HeaderText = "EMAIL";
            dgv.Columns[4].HeaderText = "PASAHITZA";
            dgv.Columns[5].HeaderText = "EDITATU";
            List<Langileak> lista = LangileBuruak.langileakIkusi(this.conn);
            for (int i = 0; i < lista.Count(); i++)
            {
                dgv.Rows.Add(lista[i].getId(), lista[i].getIzena(), lista[i].getAbizena(), lista[i].getEmail(), lista[i].getPasahitza(), "X");
            }
            return lista;
        }
        public Boolean langileakAldatu(Langileak l)
        {
            return l.informazioaAldatu(this.conn);
        }
        public Langileak loginEgin(String email, String pass)
        {
            Langileak l = Langileak.login(email, pass, this.conn);
            return l;
        }
        //-----Zuzentzen daudenak-----\\
        public void webgunekoInformazioaIkusi(DataGridView balorazioa, DataGridView iritziak)
        {
            balorazioa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            balorazioa.ColumnCount = 2;
            balorazioa.Columns[0].HeaderText = "IZENA";
            balorazioa.Columns[1].HeaderText = "BALORAZIO GEHIEN/GUTXIEN";
            List<Balorazioak> balorazioOnak = Balorazioak.webgunekoBalorazioak(1, this.conn);
            List<Balorazioak> balorazioTxarrak = Balorazioak.webgunekoBalorazioak(0, this.conn);
            for (int i = 0; i < balorazioOnak.Count; i++)
            {
                balorazioa.Rows.Add(balorazioOnak[i].getIzena(), balorazioOnak[i].getPuntuazioa());
            }
            for (int i = 0; i < balorazioTxarrak.Count(); i++)
            {
                balorazioa.Rows.Add(balorazioTxarrak[i].getIzena(), balorazioTxarrak[i].getPuntuazioa());
            }
            iritziak.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            iritziak.ColumnCount = 2;
            iritziak.Columns[0].HeaderText = "IZENA";
            iritziak.Columns[1].HeaderText = "IRITZI KOPURUA";
            List<Iritziak> iritziAsko = Iritziak.webgunekoIritziak(1, this.conn);
            List<Iritziak> iritziGutxi = Iritziak.webgunekoIritziak(0, this.conn);
            for (int i = 0; i < iritziAsko.Count(); i++)
            {
                iritziak.Rows.Add(iritziAsko[i].getIzena(), iritziAsko[i].getKopurua());
            }
            for (int i = 0; i < iritziGutxi.Count; i++)
            {
                iritziak.Rows.Add(iritziGutxi[i].getIzena(), iritziGutxi[i].getKopurua());
            }
        }
        public void webgunekoInformazioarenPdfSortu(Langileak l)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.FileName = "SteelWaves informazioa.pdf";

            String html = Properties.Resources.PDFoinarria.ToString();
            html = html.Replace("@LANGILEA", l.getIzena() + " " + l.getAbizena());
            html = html.Replace("@EGUNA", DateTime.Today.ToString("dd/MM/yyyy"));

            List<Iritziak> iritziAsko = Iritziak.webgunekoIritziak(1, this.conn);
            List<Iritziak> iritziGutxi = Iritziak.webgunekoIritziak(0, this.conn);
            String iritziak = "", balorazioa = "";
            for (int i = 0; i < iritziAsko.Count(); i++)
            {
                iritziak += "<tr>";
                iritziak += "<td>" + iritziAsko[i].getIzena() + "</td>";
                iritziak += "<td>" + iritziAsko[i].getKopurua() + "</td>";
                iritziak += "</tr>";
            }
            for (int i = 0; i < iritziGutxi.Count; i++)
            {
                iritziak += "<tr>";
                iritziak += "<td>" + iritziGutxi[i].getIzena() + "</td>";
                iritziak += "<td>" + iritziGutxi[i].getKopurua() + "</td>";
                iritziak += "</tr>";
            }
            html = html.Replace("@IRITZIA", iritziak);

            List<Balorazioak> balorazioOnak = Balorazioak.webgunekoBalorazioak(1, this.conn);
            List<Balorazioak> balorazioTxarrak = Balorazioak.webgunekoBalorazioak(0, this.conn);
            for (int i = 0; i < balorazioOnak.Count; i++)
            {
                balorazioa += "<tr>";
                balorazioa += "<td>" + balorazioOnak[i].getIzena() + "</td>";
                balorazioa += "<td>" + balorazioOnak[i].getPuntuazioa() + "</td>";
                balorazioa += "</tr>";
            }
            for (int i = 0; i < balorazioTxarrak.Count(); i++)
            {
                balorazioa += "<tr>";
                balorazioa += "<td>" + balorazioTxarrak[i].getIzena() + "</td>";
                balorazioa += "<td>" + balorazioTxarrak[i].getPuntuazioa() + "</td>";
                balorazioa += "</tr>";
            }
            html = html.Replace("@BALORAZIOA", balorazioa);

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(saveFile.FileName, FileMode.Create))
                {
                    Document doc = new Document(PageSize.A4, 50, 50, 35, 50);
                    PdfWriter writer = PdfWriter.GetInstance(doc, stream);

                    doc.Open();

                    iTextSharp.text.Image logoa = iTextSharp.text.Image.GetInstance(Properties.Resources.SteelWaveLogo, System.Drawing.Imaging.ImageFormat.Png);
                    logoa.ScaleToFit(140, 120);
                    logoa.Alignment = iTextSharp.text.Image.ALIGN_CENTER;
                    doc.Add(logoa);

                    using (StringReader sr = new StringReader(html))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, doc, sr);
                    }

                    doc.Close();
                    stream.Close();
                }
            }
        }
    }
}
