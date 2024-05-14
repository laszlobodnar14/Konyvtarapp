using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

namespace Konyvtar2
{
    internal class DBConnection
    {
        private SqlConnection conn;

        public DBConnection()
        {
            // Az adatbázis kapcsolódás létrehozása
            conn = new SqlConnection("Data Source=BODNAR-LASZLO\\SQLEXPRESS;Initial Catalog=Library_Management_System;Integrated Security=True;");

           
        }

        public SqlConnection connection()
        {
            return conn;
        }
    }
}