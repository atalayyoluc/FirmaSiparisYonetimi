using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DTO
{
    public class FirmaUpdateDTO
    {
        public int FirmaID { get; set; }

        public DateTime SatısBaslangicSaati { get; set; }

        public DateTime SatısBitisSaati { get; set; }
        public bool Onay { get; set; }

    }
}
