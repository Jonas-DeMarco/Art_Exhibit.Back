using Art_Exhibit.Back.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Art_Exhibit.Back.Application.Interfaces.Repositories
{
    public interface IOffreRepository
    {
        Task<IEnumerable<Offre>> GetAllAsync();

        Task<Offre?> GetByIdAsync(int id);

        Task<Offre?> AddAsync(Offre Offre);

        Task DeleteAsync(int Id);

        Task<IEnumerable<Offre?>> GetBidsAsync(int enchereid);
    }
}
