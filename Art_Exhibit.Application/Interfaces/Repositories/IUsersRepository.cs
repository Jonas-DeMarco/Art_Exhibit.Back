using Art_Exhibit.Back.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Art_Exhibit.Back.Application.Interfaces.Repositories
{
    public interface IUsersRepository
    {
        Task<IEnumerable<Users>> GetAllAsync();

        Task<Users?> GetByIdAsync(int id);

        Task<Users?> AddAsync(Users user);

        Task UpdateAsync (Users user);

        Task DeleteAsync(int Id);

        Task<TypeUser> GetTypeAsync(string type);

        Task<IEnumerable<TypeUser>> GetAllTypeAsync();

    }
}
