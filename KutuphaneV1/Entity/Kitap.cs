using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneV1.Entity
{
    public class Kitap
    {
        public int Id { get; set; }
        public string Isim { get; set; }
        public int yazar_id { get; set; }
        public int tur_id { get; set; }
        public int sayfa { get; set; }
        public int raf_no { get; set; }
        public int yayin_evi_id { get; set; }
        public DateTime basim_yili { get; set; }
        public DateTime kt { get; set; }
        public string ky { get; set; }
    }
}
