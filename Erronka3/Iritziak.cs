using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Erronka3
{
    public class Iritziak
    {
        private int id;
        private String iritzia;
        private String izena;
        private int kopurua;
        public Iritziak(int id, String iritzia)
        {
            this.id = id;
            this.iritzia = iritzia;
        }
        public Iritziak(String izena, int kopurua)
        {
            this.izena = izena;
            this.kopurua = kopurua;
        }
        public static List<Iritziak> denuntziatutaDaudenakIkusi(DatuBaseKonexioa conn)
        {
            MySqlConnection konexioa = conn.getKonexioa();
            konexioa.Open();
            List<Iritziak> lista = new List<Iritziak>();
            try
            {
                MySqlCommand denuntzia = new MySqlCommand("SELECT id,iritzia FROM iritziak where denuntzia!=0 and ikusgai=1 order by denuntzia desc;", konexioa);
                MySqlDataReader denuntziaDutenak = denuntzia.ExecuteReader();
                while (denuntziaDutenak.Read())
                {
                    Iritziak i = new Iritziak(Convert.ToInt16(denuntziaDutenak[0]), Convert.ToString(denuntziaDutenak[1]));
                    lista.Add(i);
                }
                return lista;
            }
            catch (Exception e)
            {
                MessageBox.Show(Convert.ToString(e));
                return null;
            }
        }
        public Boolean ikusgaiKendu(DatuBaseKonexioa conn)
        {
            Boolean ikusgaiKenduDa = false;
            MySqlConnection konexioa = conn.getKonexioa();
            konexioa.Open();
            try
            {
                MySqlCommand ikusgaiKendu = new MySqlCommand("update iritziak set ikusgai=0 where id=@id;", konexioa);
                ikusgaiKendu.Parameters.AddWithValue("@id", this.id);
                ikusgaiKendu.ExecuteNonQuery();
                return ikusgaiKenduDa = true;
            }
            catch (Exception e)
            {
                MessageBox.Show(Convert.ToString(e));
                return ikusgaiKenduDa;
            }
        }
        public Boolean denuntziaKendu(DatuBaseKonexioa conn)
        {
            Boolean denuntziaKenduDa = false;
            MySqlConnection konexioa = conn.getKonexioa();
            konexioa.Open();
            try
            {
                MySqlCommand denuntziaKendu = new MySqlCommand("update iritziak set denuntzia=0 where id=@id;", konexioa);
                denuntziaKendu.Parameters.AddWithValue("@id", this.id);
                denuntziaKendu.ExecuteNonQuery();
                return denuntziaKenduDa = true;
            }
            catch (Exception e)
            {
                MessageBox.Show(Convert.ToString(e));
                return denuntziaKenduDa;
            }
        }
        public static List<Iritziak> webgunekoIritziak(int modua, DatuBaseKonexioa conn)
        {
            MySqlConnection konexioa = conn.getKonexioa();
            konexioa.Open();
            try
            {
                String ordenatu;
                List<Iritziak> lista = new List<Iritziak>();
                if (modua == 1)
                {
                    ordenatu = "V_Iritzi_Gehienak";
                }
                else
                {
                    ordenatu = "V_Iritzi_Gutxienak";
                }
                MySqlCommand iritziak = new MySqlCommand("select * from " + ordenatu + " order by iritziKop desc;", konexioa);
                MySqlDataReader asko = iritziak.ExecuteReader();
                while (asko.Read())
                {
                    Iritziak i = new Iritziak(Convert.ToString(asko[0]), Convert.ToInt16(asko[1]));
                    lista.Add(i);
                }
                return lista;
            }
            catch (Exception e)
            {
                MessageBox.Show(Convert.ToString(e));
                return null;
            }
        }
        //Getter
        public int getId()
        {
            return this.id;
        }
        public String getIritzia()
        {
            return this.iritzia;
        }
        public String getIzena()
        {
            return this.izena;
        }
        public int getKopurua()
        {
            return this.kopurua;
        }
    }
}
