using Art_Exhibit.Back.Application.Interfaces.Repositories;
using Art_Exhibit.Back.Domain.Entities;
using Art_Exhibit.Back.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Art_Exhibit.Back.Infrastructure.Repositories
{
    public class CategorieRepository : ICategorieRepository
    {
        private readonly ApplicationDBContext _context;

        public CategorieRepository(ApplicationDBContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Categorie>> GetAllAsync()
        {
            return await _context.Categories.AsNoTracking().ToListAsync();
        }

        public async Task<Categorie?> GetByCatAsync(string Cat)
        {
            return await _context.Categories.AsNoTracking().FirstOrDefaultAsync(c => c.Cat == Cat);
        }
    }
}
