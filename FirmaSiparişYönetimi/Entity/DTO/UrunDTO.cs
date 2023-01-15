using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DTO
{
    public class UrunDTO
    {
        public int UrunID { get; set; }
        public string UrunAdi { get; set; }
        public short Stok { get; set; }
        public decimal Fiyat { get; set; }
        public int FirmaID { get; set; }
    }
}
