using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Erronka3
{
    public class Langileak
    {
        private int id;
        private String izena;
        private String abizena;
        private String email;
        private String pasahitza;
        private String kargua;
        public Langileak(int id, String ize, String abi, String ema, String pass, String kar)
        {
            this.id = id;
            this.izena = ize;
            this.abizena = abi;
            this.email = ema;
            this.pasahitza = pass;
            this.kargua = kar;
        }
        public static Langileak login(String email, String pass, DatuBaseKonexioa conn)
        {
            MySqlConnection konexioa = conn.getKonexioa();
            konexioa.Open();
            try
            {
                MySqlCommand login = new MySqlCommand("select * from langileak where email=@email and pasahitza=@pass;", konexioa);
                login.Parameters.AddWithValue("@email", email);
                login.Parameters.AddWithValue("@pass", pass);
                MySqlDataReader pertsona = login.ExecuteReader();
                if (pertsona.Read())
                {
                    Langileak l;
                    if (Convert.ToString(pertsona["kargua"]) == "Langilea")
                    {
                        l = new Langileak(Convert.ToInt16(pertsona["id"]), Convert.ToString(pertsona["izena"]), Convert.ToString(pertsona["abizena"]), Convert.ToString(pertsona["email"]), Convert.ToString(pertsona["pasahitza"]), Convert.ToString(pertsona["kargua"]));
                    }
                    else
                    {
                        l = new LangileBuruak(Convert.ToInt16(pertsona["id"]), Convert.ToString(pertsona["izena"]), Convert.ToString(pertsona["abizena"]), Convert.ToString(pertsona["email"]), Convert.ToString(pertsona["pasahitza"]), Convert.ToString(pertsona["kargua"]));
                    }
                    return l;
                }
                else
                {
                    MessageBox.Show("Ez da aurkitu langilerik");
                    return null;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(Convert.ToString(e));
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
                MySqlCommand igo = new MySqlCommand("update langileak set izena=@izena, abizena=@abizena, email=@email, pasahitza=@pasahitza where id=@id;", konexioa);
                igo.Parameters.AddWithValue("@izena", this.izena);
                igo.Parameters.AddWithValue("@abizena", this.abizena);
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
        //Getter
        public int getId()
        {
            return this.id;
        }
        public String getIzena()
        {
            return this.izena;
        }
        public String getAbizena()
        {
            return this.abizena;
        }
        public String getEmail()
        {
            return this.email;
        }
        public String getPasahitza()
        {
            return this.pasahitza;
        }
        public String getKargua()
        {
            return this.kargua;
        }
        //Setter
        public void setIzena(String izena)
        {
            this.izena = izena;
        }
        public void setAbizena(String abizena)
        {
            this.abizena = abizena;
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
