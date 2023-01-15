using AutoMapper;
using Entity.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.Services.Abstractions;

namespace FirmaSiparişYönetimi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UrunController : ControllerBase
    {
        private readonly IUrunServices urunServices;
        private readonly IMapper mapper;

        public UrunController(IUrunServices urunServices, IMapper mapper)
        {
            this.urunServices = urunServices;
            this.mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetUrun()
        {
            var urun = await urunServices.GetAllUrun();

            if(urun.Count==0)
            {
                return NotFound("Veri Tabanında ürün bulunamadı");
            }
            return Ok(urun);
        }
        [HttpPost]
        public async Task<IActionResult> Add(UrunAddDTO urun)
        {
            await urunServices.CreateUrun(urun);
            return Ok("Ürün Ekleme İşlemi Başarılı");
        }
    }
}
