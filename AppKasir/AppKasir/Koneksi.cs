using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AppKasir
{
    internal class Koneksi
    {
        public SqlConnection GetConn()
        {
            SqlConnection Conn = new SqlConnection();
            Conn.ConnectionString = "Data source=DESKTOP-E7O6LST;initial catalog=DB_APPKASIR;integrated security=true";
            return Conn;
        }
    }
}
