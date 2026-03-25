using Art_Exhibit.Back.Application.DTOs.Users;
using Art_Exhibit.Back.Application.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace Art_Exhibit.Back.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUsersServices _usersServices;

        public UserController(IUsersServices usersServices)
        {
            _usersServices = usersServices;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllUsersAsync()
        {
            return Ok(await _usersServices.GetAllUsersAsync());
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult>GetUserByIdAsync(int id)
        {
            return Ok(await _usersServices.GetUserByIdAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> Post(CreateUsersDTO userDTO)
        {
            var user = await _usersServices.AddUserAsync(userDTO);
            return Ok(user);
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> Put(UpdateUsersDTO userDTO)
        {
            await _usersServices.UpdateUserAsync(userDTO);
            return Ok(userDTO);
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _usersServices.DeleteUserAsync(id);
            return Ok();
        }

        [Route("/api/gettypes")]
        [HttpGet]
        public async Task<IActionResult> GetTypes()
        {
           var typelist =  await _usersServices.GetTypeListAsync();
            return Ok(typelist);
        }

        /*
       
        Task UpdateUserAsync(UpdateUsersDTO usersDTO);
        Task DeleteTypeUserAsync(int id);
         */
    }
}
