using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KutuphaneV1.Entity;
using MySql.Data.MySqlClient;

namespace KutuphaneV1.DataAccess
{
    public class TurDAL
    {
        KutuphaneContext _context = new KutuphaneContext();


        public void Ekle(Tur tur)
        {
            string sorgu= "Insert into tur (adi) values (@adi)";
            MySqlCommand komut= new MySqlCommand(sorgu,_context.conn());
            komut.Parameters.AddWithValue("@adi",tur.adi);
            komut.ExecuteNonQuery();
            _context.conn().Close();
        }

        public DataTable TurListele() 
        { 
        
            String sorgu ="Select * from tur";

            MySqlCommand komut = new MySqlCommand(sorgu,_context.conn());
            MySqlDataAdapter da= new MySqlDataAdapter(komut);
            DataTable dt= new DataTable();
            da.Fill(dt);
            _context.conn().Close();
            return dt;

        }

        public void guncelle(Tur tur)
        {
            string sorgu= "Update tur set adi=@adi where id=@id";
            MySqlCommand komut= new MySqlCommand(sorgu,_context.conn());
            komut.Parameters.AddWithValue("@adi",tur.adi);
            komut.Parameters.AddWithValue("@id",tur.Id);
            komut.ExecuteNonQuery();
            _context.conn().Close();
        }

        public void sil(int id)
        {
            string sorgu= "Delete from tur where id=@id";
            MySqlCommand komut= new MySqlCommand(sorgu,_context.conn());
            komut.Parameters.AddWithValue("@id",id);
            komut.ExecuteNonQuery();
            _context.conn().Close();
        }
    }
}
