using Art_Exhibit.Back.Application.DTOs.Users;
using Art_Exhibit.Back.Application.Interfaces.Services;
using Art_Exhibit.Back.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace Art_Exhibit.Back.API.Controllers
{
    public class StatutController :ControllerBase
    {
        private readonly IStatutServices _statutsservices;

        public StatutController(IStatutServices statutsservices)
        {
            _statutsservices = statutsservices;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllStatutsAsync()
        {
            return Ok(await _statutsservices.GetAllStatutsAsync());
        }

        [HttpGet("{strign:stat}")]
        public async Task<IActionResult> GetUserByIdAsync(string stat)
        {
            return Ok(await _statutsservices.GetStatutByStatAsync(stat));
        }

    }
}
