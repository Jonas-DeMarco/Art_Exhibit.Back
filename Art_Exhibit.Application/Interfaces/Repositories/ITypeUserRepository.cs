
using Art_Exhibit.Back.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Art_Exhibit.Back.Application.Interfaces.Repositories
{
    public interface ITypeUserRepository
    {
        Task<IEnumerable<TypeUser>> GetAllAsync();

        Task<TypeUser?> GetByIdAsync(int id);

        Task<TypeUser?> AddAsync(TypeUser TypeUser);

        Task UpdateAsync(TypeUser TypeUser);

        Task DeleteAsync(int Id);
    }
}
