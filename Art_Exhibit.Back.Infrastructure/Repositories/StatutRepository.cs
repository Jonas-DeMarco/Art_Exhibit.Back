using Art_Exhibit.Back.Application.Interfaces.Repositories;
using Art_Exhibit.Back.Domain.Entities;
using Art_Exhibit.Back.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Art_Exhibit.Back.Infrastructure.Repositories
{
    public class StatutRepository : IStatutRepository
    {
        private readonly ApplicationDBContext _context;

        public StatutRepository(ApplicationDBContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Statut>> GetAllAsync()
        {
           return await _context.Statuts.AsNoTracking().ToListAsync();
        }

        public async Task<Statut?> GetByStatAsync(string Stat)
        {
            return await _context.Statuts.AsNoTracking().FirstOrDefaultAsync(St => St.Stat == Stat);
        }
    }
}
