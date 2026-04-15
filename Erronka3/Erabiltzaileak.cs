using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Erronka3
{
    public class Erabiltzaileak
    {
        private int id;
        private String izena;
        private String email;
        private String pasahitza;
        private Boolean blokeoa;
        private int denuntziaKop;
        public Erabiltzaileak(int id, String ize, String ema, String pas)
        {
            this.id = id;
            this.izena = ize;
            this.email = ema;
            this.pasahitza = pas;
        }
        public Erabiltzaileak(int id, String izena, Boolean blokeoa, int denuntziaKop)
        {
            this.id = id;
            this.izena = izena;
            this.blokeoa = blokeoa;
            this.denuntziaKop = denuntziaKop;
        }
        public static List<Erabiltzaileak> blokeoEgoeraIkusi(DatuBaseKonexioa conn)
        {
            MySqlConnection konexioa = conn.getKonexioa();
            konexioa.Open();
            List<Erabiltzaileak> lista = new List<Erabiltzaileak>();
            try
            {
                MySqlCommand blokeoBeharDutenak = new MySqlCommand("select e.id,e.izena,e.blokeoa,count(i.denuntzia) as denuntziaKop from erabiltzaileak e inner join iritziak i on e.id=i.erabiltzaile_id group by e.id having denuntziaKop>=2 and e.blokeoa=0;", konexioa);
                MySqlDataReader blokeatutak = blokeoBeharDutenak.ExecuteReader();
                while (blokeatutak.Read())
                {
                    Erabiltzaileak e = new Erabiltzaileak(Convert.ToInt16(blokeatutak[0]), Convert.ToString(blokeatutak[1]), Convert.ToBoolean(blokeatutak[2]), Convert.ToInt16(blokeatutak[3]));
                    lista.Add(e);
                }
                return lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public static List<Erabiltzaileak> informazioaIkusi(DatuBaseKonexioa conn)
        {
            MySqlConnection konexioa = conn.getKonexioa();
            konexioa.Open();
            List<Erabiltzaileak> lista = new List<Erabiltzaileak>();
            try
            {
                MySqlCommand erabiltzaileak = new MySqlCommand("select id,izena,email,pasahitza from erabiltzaileak where blokeoa=0;", konexioa);
                MySqlDataReader era = erabiltzaileak.ExecuteReader();
                while (era.Read())
                {
                    Erabiltzaileak e = new Erabiltzaileak(Convert.ToInt16(era[0]), Convert.ToString(era[1]), Convert.ToString(era[2]), Convert.ToString(era[3]));
                    lista.Add(e);
                }
                return lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public Boolean informazioaAldatu(DatuBaseKonexioa conn)
        {
            MySqlConnection konexioa = conn.getKonexioa();
            Boolean aldaketa = false;
            konexioa.Open();
            try
            {
                MySqlCommand igo = new MySqlCommand("update erabiltzaileak set izena=@izena, email=@email, pasahitza=@pasahitza where id=@id;", konexioa);
                igo.Parameters.AddWithValue("@izena", this.izena);
                igo.Parameters.AddWithValue("@email", this.email);
                igo.Parameters.AddWithValue("@pasahitza", this.pasahitza);
                igo.Parameters.AddWithValue("@id", this.id);
                igo.ExecuteNonQuery();
                return aldaketa = true;
            }
            catch (Exception e)
            {
                MessageBox.Show(Convert.ToString(e));
                return aldaketa;
            }
        }
        public Boolean blokeoaAldatu(DatuBaseKonexioa conn)
        {
            MySqlConnection konexioa = conn.getKonexioa();
            konexioa.Open();
            Boolean aldaketa = false;
            try
            {
                MySqlCommand blokeatu = new MySqlCommand("update erabiltzaileak set blokeoa=1 where id=@id", konexioa);
                blokeatu.Parameters.AddWithValue("@id", this.id);
                blokeatu.ExecuteNonQuery();
                return aldaketa = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return aldaketa;
            }
        }
        //Getter
        public int getId()
        {
            return this.id;
        }
        public String getIzena()
        {
            return this.izena;
        }
        public String getEmail()
        {
            return this.email;
        }
        public String getPasahitza()
        {
            return this.pasahitza;
        }
        public Boolean getBlokeoa()
        {
            return this.blokeoa;
        }
        public int getDenuntziaKop()
        {
            return this.denuntziaKop;
        }
        //Setter
        public void setIzena(String izena)
        {
            this.izena = izena;
        }
        public void setEmail(String email)
        {
            this.email = email;
        }
        public void setPasahitza(String pasahitza)
        {
            this.pasahitza = pasahitza;
        }
    }
}
