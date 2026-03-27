using Art_Exhibit.Back.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Art_Exhibit.Back.Application.Interfaces.Repositories
{
    public interface IEnchereRepository
    {
        Task<IEnumerable<Enchere>> GetAllAsync();

        Task<Enchere?> GetByIdAsync(int id);

        Task<Enchere?> AddAsync(Enchere Enchere);

        Task UpdateAsync(Enchere Enchere);

        Task DeleteAsync(int Id);

        Task<Enchere?> GetByArtworkIdAsync(int id);
    }
}
