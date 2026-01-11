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
    
    public class YayinEviDAL
    {
        KutuphaneContext _context = new KutuphaneContext();

        public void Ekle(Yayin_Evi yayinEvi)
        {
            String sorgu = "INSERT INTO yayin_evi (ev_adi) VALUES (@ev_adi)";
            MySqlCommand cmd = new MySqlCommand(sorgu,_context.conn());
            cmd.Parameters.AddWithValue("@ev_adi", yayinEvi.ev_adi);
            cmd.ExecuteNonQuery();
            _context.conn().Close();
        }

        public DataTable Listele()
        {
            var cmd = _context.conn().CreateCommand();
            cmd.CommandText = "SELECT * FROM yayin_evi";
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            _context.conn().Close();
            return dt;
        }

        public void Guncelle(Yayin_Evi yayinEvi)
        {
            var cmd = _context.conn().CreateCommand();
            cmd.CommandText = "UPDATE yayin_evi SET yayin_evi_adi = @yayin_evi_adi WHERE id = @id";
            cmd.Parameters.AddWithValue("@yayin_evi_adi", yayinEvi.ev_adi);
            cmd.Parameters.AddWithValue("@id", yayinEvi.Id);
            cmd.ExecuteNonQuery();
            _context.conn().Close();
        }
        public void Sil(int id)
        {
            var cmd = _context.conn().CreateCommand();
            cmd.CommandText = "DELETE FROM yayin_evi WHERE id = @id";
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            _context.conn().Close();
        }
    }
}
