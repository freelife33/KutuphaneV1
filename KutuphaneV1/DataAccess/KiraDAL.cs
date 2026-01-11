using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KutuphaneV1.Entity;
using MySql.Data.MySqlClient;

namespace KutuphaneV1.DataAccess
{
    public class KiraDAL
    {
        KutuphaneContext _context = new KutuphaneContext();

        public void Ekle(Kira kira)
        {
            String sorgu = "INSERT INTO Kira (uyeId, kitapId, kiraTarihi, teslimTarihi) " +
                          "VALUES (@uyeId, @kitapId, @kiraTarihi, @teslimTarihi)";
            MySqlCommand komut= new MySqlCommand(sorgu, _context.conn());
            komut.Parameters.AddWithValue("@kitapId", kira.kitap_id);
            komut.Parameters.AddWithValue("@kiraTarihi", kira.musteri_ad);
            komut.Parameters.AddWithValue("@ucret", kira.ucret);


        }
    }
}
