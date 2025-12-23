using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KutuphaneV1.Entity;
using MySql.Data.MySqlClient;

namespace KutuphaneV1.DataAccess
{
    public class YazarDAL
    {
        KutuphaneContext _context=new KutuphaneContext();

       public void Ekle( Yazar yazar) {     
            
            String sorgu="INSERT INTO yazarlar (Adi,Soyadi) VALUES(@Adi,@Soyadi)";

            MySqlCommand komut=new MySqlCommand(sorgu,_context.conn());

        }
    }
}
