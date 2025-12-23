using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data;

namespace KutuphaneV1.DataAccess
{
    public class KutuphaneContext
    {
        public MySqlConnection conn()
        {
            MySqlConnection baglanti= new MySqlConnection("Server=localhost;Database=kutuphanev1;Uid=root;Pwd='';");

            if(baglanti.State==ConnectionState.Closed)
            {
                baglanti.Open();
            }

            return baglanti;
        }
    }
}
