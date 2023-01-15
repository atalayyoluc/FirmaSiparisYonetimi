using AutoMapper;
using Data.UnitOfWorks;
using Entity.DTO;
using Entity.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.Services.Abstractions;

namespace FirmaSiparişYönetimi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SiparisOlusturmaController : ControllerBase
    {

        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;
        private readonly IFirmaServices firmaServices;

        public SiparisOlusturmaController( IMapper mapper, IUnitOfWork unitOfWork, IFirmaServices firmaServices)
        {
       
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
            this.firmaServices = firmaServices;
        }
        [HttpPost]
        public async Task<IActionResult> AddSiparis(SiparisAddDTO siparis)
        {
            var SiparisEkleme = new Siparis();
            SiparisEkleme.SiparisSaati = DateTime.Now;
            var firma = await firmaServices.GetFirmaById(siparis.FirmaID);
            if (firma == null)
            {
                return NotFound("Böyle Bir Firma Bulunamadı");
            }
            else
            {
                if (firma.Onay == true)
                {
                    if (firma.SatısBaslangicSaati <= TimeSpan.Parse(SiparisEkleme.SiparisSaati.ToString("HH:mm")))
                    {
                        if (TimeSpan.Parse(SiparisEkleme.SiparisSaati.ToString("HH:mm")) <= firma.SatısBitisSaati)
                        {
                            
                            SiparisEkleme.FirmaID = siparis.FirmaID;
                            
                            SiparisEkleme.SiparisVeren = siparis.SiparisVeren;
                            SiparisEkleme.UrunID = siparis.UrunID;
                            await unitOfWork.GetRepository<Siparis>().AddAsync(SiparisEkleme);
                            await unitOfWork.SaveAsync();
                            return Ok("Sipariş Başarılı Bir Şekilde Oluşmuştur");
                        }
                        else
                        {
                            return Ok($"Firmamız Kapalıdır. Firmamızın Çalışma Saatleri {firma.SatısBaslangicSaati}-{firma.SatısBitisSaati}dur Lütfen Bu Saat Aralığında Siparişinizi Tekrar Veriniz.");
                        }
                    }
                    else
                    {
                        return Ok($"Firmamız Kapalıdır. Firmamızın Çalışma Saatleri {firma.SatısBaslangicSaati}-{firma.SatısBitisSaati}dur Lütfen Bu Saat Aralığında Siparişinizi Tekrar Veriniz.");
                    }
                }
                else
                {
                    return Ok("Firma Onaylı Bir Firma Değil Sipariş Başarısız Oldu");
                }

            }




        }
    }
}
