using Art_Exhibit.Back.Application.DTOs.Offre;
using Art_Exhibit.Back.Application.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace Art_Exhibit.Back.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OffreController : ControllerBase
    {
        public readonly IOffreServices _offreServices;

        public OffreController(IOffreServices offreServices)
        {
            _offreServices = offreServices;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllOffresAsync()
        {
            return Ok(await _offreServices.GetAllOffresAsync());
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetOffreByIdAsync(int id)
        {
            return Ok(await _offreServices.GetOffreByIdAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> Post(CreateOffreDTO offreDTO)
        {
            var offre = await _offreServices.AddOffreAsync(offreDTO) ;
            return Ok(offreDTO);
        }

        

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _offreServices.DeleteOffreAsync(id);
            return Ok();
        }


        [Route("lastbid/{id:int}")]
        [HttpGet]
        public async Task<IActionResult> GetLastBid(int id)
        {
            var result = await _offreServices.GetLastBidAsync(id);
            if(result == null) result = new OffreDTO();
            return Ok(result);
        }

        [Route("bids/{id:int}")]
        [HttpGet]
        public async Task<IActionResult> GetBids(int id)
        {
            var result = await _offreServices.GetBidsAsync(id);
            if (result == null) result = Array.Empty<OffreDTO>();
            return Ok(result);
        }
    }
}
