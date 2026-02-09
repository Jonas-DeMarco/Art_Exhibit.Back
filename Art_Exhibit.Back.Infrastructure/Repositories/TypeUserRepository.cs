using Art_Exhibit.Back.Application.Interfaces.Repositories;
using Art_Exhibit.Back.Domain.Entities;
using Art_Exhibit.Back.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Art_Exhibit.Back.Infrastructure.Repositories
{
    public class TypeUserRepository : ITypeUserRepository
    {

        private readonly ApplicationDBContext _context;

        public TypeUserRepository(ApplicationDBContext context)
        {
            _context = context;
        }

        public async Task<TypeUser?> AddAsync(TypeUser TypeUser)
        {
            await _context.AddAsync(TypeUser);
            await _context.SaveChangesAsync();
            return TypeUser;
        }

        public async Task DeleteAsync(int Id)
        {
            var typeuser = await _context.TypeUsers.FindAsync(Id);
            if (typeuser != null)
            {
                _context.TypeUsers.Remove(typeuser);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<TypeUser>> GetAllAsync()
        {
            return await _context.TypeUsers.AsNoTracking().ToListAsync();
        }

        public Task<TypeUser?> GetByIdAsync(int id)
        {
            return _context.TypeUsers.AsNoTracking().FirstOrDefaultAsync(tusr => tusr.ID == id);
        }

        public Task UpdateAsync(TypeUser TypeUser)
        {
            throw new NotImplementedException();
        }
    }
}
