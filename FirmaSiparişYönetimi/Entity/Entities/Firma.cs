using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Entities
{
    public class Firma
    {
        public Firma()
        {

        }
        public Firma( string firmaAdi, bool onay, TimeSpan satısBaslangicSaati, TimeSpan satısBitisSaati)
        {
         
            FirmaAdi = firmaAdi;
            Onay = onay;
            SatısBaslangicSaati = satısBaslangicSaati;
            SatısBitisSaati = satısBitisSaati;
        }

        public int FirmaID { get; set; }
        public string FirmaAdi { get; set; }
        public bool Onay { get; set; }

        [Column(TypeName = ("time"))]
        [Required]
        public TimeSpan SatısBaslangicSaati { get; set; }
        [Column(TypeName = ("time"))]
        [Required]
        public TimeSpan SatısBitisSaati { get; set; }
        public IEnumerable<Urun> Uruns { get; set; }
        public IEnumerable<Siparis> Siparis { get; set; }
    }
}
