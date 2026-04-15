using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Erronka3
{
    public class LangileBuruak : Langileak
    {
        public LangileBuruak(int id, String ize, String abi, String ema, String pass, String kar) : base(id, ize, abi, ema, pass, kar)
        {

        }
        public static List<Langileak> langileakIkusi(DatuBaseKonexioa conn)
        {
            MySqlConnection konexioa = conn.getKonexioa();
            konexioa.Open();
            List<Langileak> lista = new List<Langileak>();
            try
            {
                MySqlCommand langileak = new MySqlCommand("select * from langileak;", konexioa);
                MySqlDataReader lan = langileak.ExecuteReader();
                while (lan.Read())
                {
                    Langileak l = new Langileak(Convert.ToInt16(lan[0]), Convert.ToString(lan[1]), Convert.ToString(lan[2]), Convert.ToString(lan[3]), Convert.ToString(lan[4]), Convert.ToString(lan[5]));
                    lista.Add(l);
                }
                return lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}
