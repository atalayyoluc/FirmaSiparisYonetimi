using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DTO
{
    public class UrunAddDTO
    {
        [MinLength(3)]
        [Required]
        public string UrunAdi { get; set; }
        public short Stok { get; set; }
        public decimal Fiyat { get; set; }
        public int FirmaID { get; set; }
    }
}
