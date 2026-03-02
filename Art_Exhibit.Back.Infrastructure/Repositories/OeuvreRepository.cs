using Art_Exhibit.Back.Application.Interfaces.Repositories;
using Art_Exhibit.Back.Domain.Entities;
using Art_Exhibit.Back.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Art_Exhibit.Back.Infrastructure.Repositories
{
    public class OeuvreRepository : IOeuvreRepository
    {
        private readonly ApplicationDBContext _context;

        public OeuvreRepository(ApplicationDBContext context)
        {
                _context = context;
        }

        public async Task<Oeuvre?> AddAsync(Oeuvre Oeuvre)
        {
            await _context.AddAsync(Oeuvre);
            await _context.SaveChangesAsync();
            return Oeuvre;
        }

        public async Task DeleteAsync(int Id)
        {
            var Oeuvre = await _context.Oeuvres.FindAsync(Id);
            if (Oeuvre != null)
            {
                _context.Remove(Oeuvre);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Oeuvre>> GetAllAsync()
        {
            return await _context.Oeuvres.AsNoTracking().ToListAsync();
        }

        public async Task<Oeuvre?> GetByIdAsync(int id)
        {
            return await _context.Oeuvres.AsNoTracking().FirstOrDefaultAsync(oe => oe.Id == id);
        }

        public async Task UpdateAsync(Oeuvre Oeuvre)
        {
            _context.Oeuvres.Update(Oeuvre);
            await _context.SaveChangesAsync();
        }
    }
}
