using Art_Exhibit.Back.Application.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Art_Exhibit.Back.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TypeUserController : ControllerBase
    {
        private readonly ITypeUserServices _TypeUserServices;

        public TypeUserController(ITypeUserServices typeUserServices)
        {
            _TypeUserServices = typeUserServices;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllTypeUserASync()
        {
            return Ok(await _TypeUserServices.GetAllTypeUsersAsync());
        }
    }
}
