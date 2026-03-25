using Art_Exhibit.Back.Application.DTOs.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace Art_Exhibit.Back.Application.Interfaces.Services
{
    public interface IUsersServices
    {
        Task<IEnumerable<UsersDTO>> GetAllUsersAsync();

        Task<UsersDTO ?> GetUserByIdAsync(int id);

        Task<UsersDTO?> GetUserByUsernameAsync(string username);

        Task<UsersDTO?> AddUserAsync(CreateUsersDTO usersDTO);
        Task UpdateUserAsync(UsersDTO usersDTO);
        Task DeleteUserAsync(int id);

        Task<IEnumerable<string>> GetTypeListAsync();

        Task<IEnumerable<string>> GetArtistsListAsync();


    }
}
