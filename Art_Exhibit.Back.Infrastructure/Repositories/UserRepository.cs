using Art_Exhibit.Back.Application.Interfaces.Repositories;
using Art_Exhibit.Back.Domain.Entities;
using Art_Exhibit.Back.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Art_Exhibit.Back.Infrastructure.Repositories
{
    public class UserRepository:IUsersRepository
    {
        private readonly ApplicationDBContext _context;

        public UserRepository(ApplicationDBContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Users>> GetAllAsync()
        {

            return await _context.Users.Include(u => u.Type).AsNoTracking().ToListAsync();
        }

        public async Task<Users?> GetByIdAsync(int id)
        {
            return await _context.Users.Include(u => u.Type).AsNoTracking().FirstOrDefaultAsync(usr => usr.Id == id);
        }

        public async Task<Users?> AddAsync(Users user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
            return user;
        }

        public async Task UpdateAsync(Users user)
        {
            _context.Users.Update(user);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int Id)
        {
            var user = await _context.Users.FindAsync(Id);
            if (user != null)
            {
                _context.Users.Remove(user);
                await _context.SaveChangesAsync();
            }
        }
    }
}
