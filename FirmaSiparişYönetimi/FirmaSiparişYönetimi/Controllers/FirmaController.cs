using AutoMapper;
using Entity.DTO;
using Entity.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.Services.Abstractions;
using Service.Services.Concretes;

namespace FirmaSiparişYönetimi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FirmaController : ControllerBase
    {
        private readonly IFirmaServices firmaServices;
        private readonly IMapper mapper;

        public FirmaController(IFirmaServices firmaServices, IMapper mapper)
        {
            this.firmaServices = firmaServices;
            this.mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var firma = await firmaServices.GetFirmas();
            if (firma.Count == 0)
            {
                return NotFound("Veri Tabanında ürün bulunamadı");
            }
            return Ok(firma);
        }
        [HttpPost]
        public async Task<IActionResult> Add(FirmaAddDTO firma)
        {
             await firmaServices.CreateFirma(firma);

            return Ok("Firma Ekleme İşlemi Başarılı");
        }

        [HttpPatch]
        public async Task<IActionResult> UpdateFirma(FirmaUpdateDTO firmaUpdate)
        {
            var firma = await firmaServices.UpdateFirmaAsync(firmaUpdate);
            return Ok("Firma Başarılı Bir Şekilde Güncellendi");

                  }


    }
}
