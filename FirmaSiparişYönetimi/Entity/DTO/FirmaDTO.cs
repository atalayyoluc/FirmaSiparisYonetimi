using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DTO
{
    public class FirmaDTO
    {
        public FirmaDTO()
        {
        }
        public FirmaDTO(string firmaAdi,bool Onay, TimeSpan satisBaslangic,TimeSpan satisBitis)
        {
            FirmaAdi = firmaAdi;
            this.Onay = Onay;
            SatısBaslangicSaati = satisBaslangic;
            SatısBitisSaati = satisBitis;
        }

        public int FirmaID { get; set; }
        public string FirmaAdi { get; set; }
        public bool Onay { get; set; }

        [Column(TypeName = ("time"))]
        public TimeSpan SatısBaslangicSaati { get; set; }
        [Column(TypeName = ("time"))]
        public TimeSpan SatısBitisSaati { get; set; }

    }
}
