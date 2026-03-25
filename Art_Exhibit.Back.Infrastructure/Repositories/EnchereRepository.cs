using Art_Exhibit.Back.Application.Interfaces.Repositories;
using Art_Exhibit.Back.Domain.Entities;
using Art_Exhibit.Back.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Art_Exhibit.Back.Infrastructure.Repositories
{
    public class EnchereRepository : IEnchereRepository
    {

        private readonly ApplicationDBContext _context;
        public EnchereRepository(ApplicationDBContext context)
        {
            _context = context;
        }

        public async Task<Enchere?> AddAsync(Enchere Enchere)
        {
            _context.Attach(Enchere.Oeuvre);
            await _context.AddAsync(Enchere);
            await _context.SaveChangesAsync();
            return Enchere;
        }

        public async Task DeleteAsync(int Id)
        {
            var Enchere = await _context.Encheres.FindAsync(Id);
            if (Enchere != null)
            {
                _context.Remove(Enchere);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Enchere>> GetAllAsync()
        {
            return await _context.Encheres
                .Include(o  => o.Oeuvre)
                .Include(o => o.Oeuvre.Auteur)
                .Include(o => o.Oeuvre.Categorie)
                .AsNoTracking().ToListAsync();
        }

        public async Task<Enchere?> GetByIdAsync(int id)
        {
            return await _context.Encheres.AsNoTracking().FirstOrDefaultAsync(e  => e.Id == id);
        }

        public Task UpdateAsync(Enchere Enchere)
        {
            _context.Encheres.Update(Enchere);
            return _context.SaveChangesAsync();
        }
    }
}
