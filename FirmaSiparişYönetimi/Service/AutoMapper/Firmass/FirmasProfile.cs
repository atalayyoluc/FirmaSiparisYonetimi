using AutoMapper;
using Entity.DTO;
using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.AutoMapper.Firmass
{
    public class FirmasProfile:Profile
    {
        public FirmasProfile()
        {
            CreateMap<FirmaDTO, Firma>().ReverseMap();
            CreateMap<FirmaUpdateDTO, Firma>().ReverseMap();
            CreateMap<FirmaAddDTO, Firma>().ReverseMap();   

        }
    }
}
