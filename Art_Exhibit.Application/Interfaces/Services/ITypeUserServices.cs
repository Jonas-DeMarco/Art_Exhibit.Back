using Art_Exhibit.Back.Application.DTOs.TypeUsers;
using Art_Exhibit.Back.Application.DTOs.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace Art_Exhibit.Back.Application.Interfaces.Services
{
    public interface ITypeUserServices
    {
        Task<IEnumerable<TypeUsersDTO>> GetAllTypeUsersAsync();

        Task<TypeUsersDTO?> GetTypeUserByIdAsync(int id);

        Task<TypeUsersDTO?> AddTypeUserAsync(TypeUsersDTO typeUsersDTO);
        Task UpdateTypeUserAsync(TypeUsersDTO typeUsersDTO);
        Task DeleteTypeUserAsync(int id);
    }
}
