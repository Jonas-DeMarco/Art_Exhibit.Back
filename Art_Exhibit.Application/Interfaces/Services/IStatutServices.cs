using Art_Exhibit.Back.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Art_Exhibit.Back.Application.Interfaces.Services
{
    public interface IStatutServices
    {
        Task<IEnumerable<Statut>> GetAllStatutsAsync();

        Task<Statut?> GetStatutByStatAsync(string Stat);
    }
}
