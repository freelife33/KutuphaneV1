using System;
using System.Data;
using KutuphaneV1.Entity;
using MySql.Data.MySqlClient;

namespace KutuphaneV1.DataAccess
{
    public class YazarDAL
    {
        KutuphaneContext _context=new KutuphaneContext();

       public void Ekle( Yazar yazar) {     
            
            String sorgu="INSERT INTO yazarlar (Adi,Soyadi) VALUES(@Adi,@Soyadi)";

            MySqlCommand komut=new MySqlCommand(sorgu, _context.conn());

            komut.Parameters.AddWithValue("@Adi", yazar.Adi);
            komut.Parameters.AddWithValue("@Soyadi", yazar.Soyadi);

            komut.ExecuteNonQuery();

            _context.conn().Close();

        }

        public DataTable YazarListele()
        {
            String sorgu = "SELECT * FROM yazarlar";
            MySqlCommand komut = new MySqlCommand(sorgu, _context.conn());
            MySqlDataAdapter da = new MySqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            _context.conn().Close();
            return dt;
        }

        public DataTable YazarListe()
        {
            string sorgu = @"SELECT Id,CONCAT(adi, ' ', soyadi) AS YazarAdi FROM yazarlar";

            MySqlCommand komut = new MySqlCommand(sorgu, _context.conn());
            MySqlDataAdapter da = new MySqlDataAdapter(komut);

            DataTable dt = new DataTable();
            da.Fill(dt);

            _context.conn().Close();
            return dt;
        }


        public void Update(Yazar yazar)
        {
            String sorgu = "UPDATE yazarlar SET Adi=@Adi, Soyadi=@Soyadi WHERE Id=@Id";
            MySqlCommand komut = new MySqlCommand(sorgu, _context.conn());
            komut.Parameters.AddWithValue("@Adi", yazar.Adi);
            komut.Parameters.AddWithValue("@Soyadi", yazar.Soyadi);
            komut.Parameters.AddWithValue("@Id", yazar.Id);
            komut.ExecuteNonQuery();
            _context.conn().Close();
        }

        public void Delete(int id)
        {
            String sorgu = "DELETE FROM yazarlar WHERE Id=@Id";
            MySqlCommand komut = new MySqlCommand(sorgu, _context.conn());
            komut.Parameters.AddWithValue("@Id", id);
            komut.ExecuteNonQuery();
            _context.conn().Close();
        }
    }
}
