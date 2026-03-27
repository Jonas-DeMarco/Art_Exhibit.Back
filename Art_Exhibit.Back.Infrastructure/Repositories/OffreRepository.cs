using Art_Exhibit.Back.Application.Interfaces.Repositories;
using Art_Exhibit.Back.Domain.Entities;
using Art_Exhibit.Back.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Art_Exhibit.Back.Infrastructure.Repositories
{
    public class OffreRepository : IOffreRepository
    {
        private readonly ApplicationDBContext _context;

        public OffreRepository(ApplicationDBContext context)
        {
            _context = context;
        }

        public async Task<Offre?> AddAsync(Offre Offre)
        {
            _context.Attach(Offre.Bidder);
            _context.Attach(Offre.Enchere);
            await _context.Offres.AddAsync(Offre);
            await _context.SaveChangesAsync();
            return Offre;
        }

        public async Task DeleteAsync(int Id)
        {
            var offre = await _context.Offres.FindAsync(Id);
            if (offre != null)
            {
                _context.Remove(offre);
                await _context.SaveChangesAsync();
            }   
        }

        public async Task<IEnumerable<Offre>> GetAllAsync()
        {
            return await _context.Offres
                .Include(o => o.Bidder)
                .Include(o => o.Enchere)
                .AsNoTracking().ToListAsync();
        }

        public async Task<Offre?> GetByIdAsync(int id)
        {
            return await _context.Offres.AsNoTracking()
                .Include(o => o.Bidder)
                .Include(o => o.Enchere)
                .FirstOrDefaultAsync(o => o.Id == id);
        }

        public async Task<IEnumerable<Offre?>> GetBidsAsync(int enchereid)
        {
            return await _context.Offres.AsNoTracking()
                .Include(o => o.Bidder)
                .Include(o => o.Enchere)
                .Where(o => o.Enchere.Id == enchereid).OrderByDescending(o=> o.Price).ToListAsync();
        }


    }
}
