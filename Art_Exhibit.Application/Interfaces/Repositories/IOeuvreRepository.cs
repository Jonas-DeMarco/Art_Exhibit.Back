using Art_Exhibit.Back.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Art_Exhibit.Back.Application.Interfaces.Repositories
{
    public interface IOeuvreRepository
    {
        Task<IEnumerable<Oeuvre>> GetAllAsync();

        Task<Oeuvre?> GetByIdAsync(int id);

        Task<Oeuvre?> AddAsync(Oeuvre Oeuvre);

        Task UpdateAsync(Oeuvre Oeuvre);

        Task DeleteAsync(int Id);

        Task<Statut> GetStatutAsync(string stat);
    }
}
