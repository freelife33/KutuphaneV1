using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneV1.Entity
{
    public class Kullanici
    {
        public int Id { get; set; }
        public String adi { get; set; }
        public String sayadi { get; set; }
        public String sifre { get; set; }
        public String rol { get; set; }
        public DateTime kt { get; set; }
        public String ky { get; set; }
    }
}
