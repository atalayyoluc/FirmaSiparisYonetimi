using AutoMapper;
using Data.UnitOfWorks;
using Entity.DTO;
using Entity.Entities;
using Service.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.Concretes
{
    public class UrunServices : IUrunServices
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public UrunServices(IUnitOfWork unitOfWork,IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
      
            public async Task<List<UrunDTO>> GetAllUrun()
             {
            var Uruns = await unitOfWork.GetRepository<Urun>().GetAllAsync();

            var map=mapper.Map<List<UrunDTO>>(Uruns);

            return map;
        }

        public async Task CreateUrun(UrunAddDTO urun)
        {
            var uruns = new Urun(urun.UrunAdi, urun.Stok, urun.Fiyat, urun.FirmaID);
            
                await unitOfWork.GetRepository<Urun>().AddAsync(uruns);
                await unitOfWork.SaveAsync();  
        }
            
    }

    
}
