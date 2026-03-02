using Art_Exhibit.Back.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Art_Exhibit.Back.Application.Interfaces.Repositories
{
    public interface IStatutRepository
    {
        Task<IEnumerable<Statut>> GetAllAsync();
        Task<Statut?> GetByStatAsync(string Stat);
    }
}
