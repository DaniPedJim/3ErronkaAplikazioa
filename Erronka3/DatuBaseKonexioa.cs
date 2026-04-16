using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Erronka3
{
    public class DatuBaseKonexioa
    {
        private String konexioa = "Server=192.168.115.159;Database=3erronka;User Id=admin;Password=1MG32025;";
        public MySqlConnection getKonexioa()
        {
            MySqlConnection con = new MySqlConnection(this.konexioa);
            return con;
        }
    }
}