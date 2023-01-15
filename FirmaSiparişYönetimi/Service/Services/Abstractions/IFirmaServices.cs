using Entity.DTO;
using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.Abstractions
{
    public interface IFirmaServices
    {
        Task<List<FirmaDTO>> GetFirmas();
        Task CreateFirma(FirmaAddDTO firma);
        Task<Firma> GetFirmaById(int id);
        Task<string> UpdateFirmaAsync(FirmaUpdateDTO firmaUpdateDTO);
    }
}
