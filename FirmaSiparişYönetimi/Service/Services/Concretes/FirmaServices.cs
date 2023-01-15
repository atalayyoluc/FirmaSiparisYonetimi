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
    public class FirmaServices : IFirmaServices
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public FirmaServices(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public async Task CreateFirma(FirmaAddDTO firma)
        {
                
            var firmas = new Firma(firma.FirmaAdi, firma.Onay, TimeSpan.Parse(firma.SatısBaslangicSaati.ToString("HH:mm")), TimeSpan.Parse(firma.SatısBitisSaati.ToString("HH:mm")));
            await unitOfWork.GetRepository<Firma>().AddAsync(firmas);
            await unitOfWork.SaveAsync();
        }

        public async Task<Firma> GetFirmaById(int id)
        {
            var firma = await unitOfWork.GetRepository<Firma>().GetByID(id);
            return firma;
        }

        public async Task<List<FirmaDTO>> GetFirmas()
        {
            var firmalar = await unitOfWork.GetRepository<Firma>().GetAllAsync();
            var map = mapper.Map<List<FirmaDTO>>(firmalar);
            return map;
        }

        public async Task<string> UpdateFirmaAsync(FirmaUpdateDTO firmaUpdateDTO)
        {
            var firma = await unitOfWork.GetRepository<Firma>().GetAsync(x => x.FirmaID == firmaUpdateDTO.FirmaID);
            firma.SatısBaslangicSaati = TimeSpan.Parse(firmaUpdateDTO.SatısBaslangicSaati.ToString("HH:mm"));
            firma.SatısBitisSaati = TimeSpan.Parse(firmaUpdateDTO.SatısBitisSaati.ToString("HH:mm"));
            firma.Onay = firmaUpdateDTO.Onay;
            await unitOfWork.GetRepository<Firma>().UpdateAsync(firma);
            await unitOfWork.SaveAsync();
            return firma.FirmaAdi;
        }
    }
}
