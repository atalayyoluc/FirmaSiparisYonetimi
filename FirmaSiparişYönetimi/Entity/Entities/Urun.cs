using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Entities
{
    public class Urun
    {
        public Urun()
        {

        }
        public Urun(string urunAdi, short stok, decimal fiyat, int firmaID)
        {

            UrunAdi = urunAdi;
            Stok = stok;
            Fiyat = fiyat;
            FirmaID = firmaID;

        }

        public int UrunID { get; set; }
        public string UrunAdi { get; set; }
        public short Stok { get; set; }
        public decimal Fiyat { get; set; }
        public int FirmaID { get; set; }
        public Firma Firma { get; set; }

    }
}
