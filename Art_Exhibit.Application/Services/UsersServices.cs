using Art_Exhibit.Back.Application.DTOs.Users;
using Art_Exhibit.Back.Application.Interfaces.Repositories;
using Art_Exhibit.Back.Application.Interfaces.Services;
using Art_Exhibit.Back.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Art_Exhibit.Back.Application.Services
{
    public class UsersServices : IUsersServices
    {
        private readonly IUsersRepository _repository;

        public UsersServices(IUsersRepository repository)
        {
            _repository = repository; 
        }

        private UsersDTO MapToDTO(Users user)
        {
            return new UsersDTO
            {
                Id = user.Id,
                Type = user.Type,
                Username = user.Username,
                Password = user.Password,
                Email = user.Email
            };
        }

        public async Task<IEnumerable<UsersDTO>> GetAllUsersAsync()
        {
            var users =await _repository.GetAllAsync();
            var dtos = new List<UsersDTO>();
            foreach (var user in users)
            {
                dtos.Add(MapToDTO(user));
            }
            return dtos;
        }

        public async Task<UsersDTO?> GetUserByIdAsync(int id)
        {
            var user = await _repository.GetByIdAsync(id);
            if (user == null) return null;
            return MapToDTO(user);
        }

        public async Task<UsersDTO?> AddUserAsync(CreateUsersDTO usersDTO)
        {
            var user = new Users
            {
                Id = usersDTO.Id,
                Type = usersDTO.Type,
                Username = usersDTO.Username,
                Password = usersDTO.Password,
                Email = usersDTO.Email
            };
            var newUser = await _repository.AddAsync(user);
            if (newUser != null) return MapToDTO(newUser);
            return null;
            
        }
        public async Task UpdateUserAsync(UpdateUsersDTO usersDTO)
        {
            var user = await _repository.GetByIdAsync(usersDTO.Id);
            if (user == null) throw new Exception("User not found");
            user.Id = usersDTO.Id;
            user.Type = usersDTO.Type;
            user.Username = usersDTO.Username;
            user.Password = usersDTO.Password;
            user.Email = usersDTO.Email;
            await _repository.UpdateAsync(user);
        }
        public async Task DeleteUserAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }
    }
}
