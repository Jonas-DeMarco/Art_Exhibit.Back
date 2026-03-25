using Art_Exhibit.Back.Application.DTOs.Enchere;
using Art_Exhibit.Back.Application.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace Art_Exhibit.Back.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnchereController : ControllerBase
    {
        private readonly IEnchereServices _enchereServices;

        public EnchereController(IEnchereServices enchereServices)
        {
            _enchereServices = enchereServices;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllEncheresAsync()
        {
            return Ok(await _enchereServices.GetAllEncheresAsync());
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetOeuvreByIdAsync(int id)
        {
            return Ok(await _enchereServices.GetEnchereByIdAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> Post(CreateEnchereDTO enchereDTO)
        {
            var enchere = await _enchereServices.AddEnchereAsync(enchereDTO);
            return Ok(enchere);
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> Put(CreateEnchereDTO enchereDTO)
        {
            await _enchereServices.UpdateEnchereAsync(enchereDTO);
            return Ok(enchereDTO);
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _enchereServices.DeleteEnchereAsync(id);
            return Ok();
        }
    }
}
