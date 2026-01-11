using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KutuphaneV1.Entity;
using MySql.Data.MySqlClient;

namespace KutuphaneV1.DataAccess
{
    public class KullaniciDAL
    {
        KutuphaneContext _context = new KutuphaneContext();

        public void Ekle(Kullanici kullanici)
        {
            MySqlCommand kullaniciVarmi = new MySqlCommand("SELECT COUNT(*) FROM kullanici WHERE adi=@adi", _context.conn());
            kullaniciVarmi.Parameters.AddWithValue("@adi", kullanici.adi);
            int sayi = Convert.ToInt32(kullaniciVarmi.ExecuteScalar());
           // _context.conn().Close();
            if (sayi > 0)
            {
                MessageBox.Show("Bu kullanıcı adı zaten mevcut!");
                _context.conn().Close();
                return;
            }
            else
            {
                String sorgu = "INSERT INTO Kullanici (adi, soyadi, sifre, rol, kt) " +
                              "VALUES (@adi, @soyadi, @sifre, @rol, @kt)";
                MySqlCommand komut = new MySqlCommand(sorgu, _context.conn());
                komut.Parameters.AddWithValue("@adi", kullanici.adi);
                komut.Parameters.AddWithValue("@soyadi", kullanici.soyadi);
                komut.Parameters.AddWithValue("@sifre", kullanici.sifre);
                komut.Parameters.AddWithValue("@rol", kullanici.rol);
                komut.Parameters.AddWithValue("@kt", DateTime.Now);
                komut.ExecuteNonQuery();
                _context.conn().Close();
            }
                        
        }

        public void Guncelle(Kullanici kullanici)
        {
            String sorgu = "UPDATE Kullanici SET adi=@adi, soyadi=@soyadi, sifre=@sifre, rol=@rol WHERE id=@Id";
            MySqlCommand komut = new MySqlCommand(sorgu, _context.conn());
            komut.Parameters.AddWithValue("@adi", kullanici.adi);
            komut.Parameters.AddWithValue("@soyadi", kullanici.soyadi);
            komut.Parameters.AddWithValue("@sifre", kullanici.sifre);
            komut.Parameters.AddWithValue("@rol", kullanici.rol);
            komut.Parameters.AddWithValue("@Id", kullanici.Id);
            komut.ExecuteNonQuery();
            _context.conn().Close();
        }

        public void Sil(int id)
        {
            String sorgu = "DELETE FROM Kullanici WHERE Id=@Id";
            MySqlCommand komut = new MySqlCommand(sorgu, _context.conn());
            komut.Parameters.AddWithValue("@Id", id);
            komut.ExecuteNonQuery();
            _context.conn().Close();
        }

        public DataTable KullaniciListele()
        {
            String sorgu = "SELECT * FROM Kullanici";
            MySqlCommand komut = new MySqlCommand(sorgu, _context.conn());
            MySqlDataAdapter da = new MySqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            _context.conn().Close();
            return dt;
        }

        public Kullanici KullaniciGetir(String kullaniciAdi, String sifre)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM kullanici WHERE adi=@adi and sifre=@sifre", _context.conn());
            cmd.Parameters.AddWithValue("@adi", kullaniciAdi);
            cmd.Parameters.AddWithValue("@sifre", sifre);
            var reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                return new Kullanici
                {
                    Id = Convert.ToInt32(reader["id"]),
                    adi = reader["adi"].ToString(),
                    soyadi = reader["soyadi"].ToString(),
                    sifre = reader["sifre"].ToString(),
                    rol = reader["rol"].ToString(),
                    kt = Convert.ToDateTime(reader["kt"])
                };
            }

            return null;
        }
    }
}
