using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Entities
{
    public class Siparis
    {
        public int SiparisID { get; set; }
        public int ?FirmaID { get; set; }
        public int UrunID { get; set; }
        public string SiparisVeren { get; set; }
        public DateTime SiparisSaati { get; set; } = DateTime.Now;
        public Firma Firma { get; set; }
        public Urun Urun { get; set; }
    }
}
