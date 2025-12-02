using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneV1.Entity
{
    public class Kira
    {
        public int Id { get; set; }
        public int kitap_id { get; set; }
        public String musteri_ad { get; set; }
        public Decimal ucret { get; set; }
        public DateTime kt { get; set; }
        public String ky { get; set; }
        public DateTime verilis_tarihi { get; set; }
        public DateTime iade_tarihi { get; set; }

    }
}


//*
//*id
//* kitap_id
//* musteri_ad String
//* ucret Decimal
// * kt DateTime
// * ky String
// * verilis_tarihi DateTime
// * iade_tarihi DateTime

 