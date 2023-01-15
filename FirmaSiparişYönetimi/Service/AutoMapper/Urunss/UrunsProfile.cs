using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Entity.DTO;
using Entity.Entities;

namespace Service.AutoMapper.Urunss
{
    public class UrunsProfile:Profile
    {
        public UrunsProfile()
        {
            CreateMap<UrunDTO, Urun>().ReverseMap();
        }
    }
}
