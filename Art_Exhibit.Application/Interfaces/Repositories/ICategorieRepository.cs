using Art_Exhibit.Back.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Art_Exhibit.Back.Application.Interfaces.Repositories
{
    public interface ICategorieRepository
    {
        Task<IEnumerable<Categorie>> GetAllAsync();
        Task<Categorie?> GetByCatAsync(string Cat);
    }
}
