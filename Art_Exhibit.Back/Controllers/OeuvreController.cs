using Art_Exhibit.Back.Application.DTOs.Oeuvre;
using Art_Exhibit.Back.Application.DTOs.Users;
using Art_Exhibit.Back.Application.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Art_Exhibit.Back.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OeuvreController:ControllerBase
    {
        private readonly IOeuvreServices _oeuvresServices;

        public OeuvreController(IOeuvreServices oeuvresServices)
        {
            _oeuvresServices = oeuvresServices;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllOeuvresAsync()
        {
            return Ok(await _oeuvresServices.GetAllOeuvresAsync());
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetOeuvreByIdAsync(int id)
        {
            return Ok(await _oeuvresServices.GetOeuvreByIdAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> Post(CreateOeuvreDTO oeuvreDTO)
        {
            var oeuvre = await _oeuvresServices.AddOeuvreAsync(oeuvreDTO);
            return Ok(oeuvre);
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> Put(OeuvreDTO oeuvreDTO)
        {
            await _oeuvresServices.UpdateOeuvreAsync(oeuvreDTO);
            return Ok(oeuvreDTO);
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _oeuvresServices.DeleteOeuvreAsync(id);
            return Ok();
        }

        [Route("/api/getcategories")]
        [HttpGet]
        public async Task<IActionResult> GetCategories()
        {
            return Ok(await _oeuvresServices.GetCategoriesAsync());
        }

        
    }
}
