using Art_Exhibit.Back.Application.DTOs.TypeUsers;
using Art_Exhibit.Back.Application.DTOs.Users;
using Art_Exhibit.Back.Application.Interfaces.Repositories;
using Art_Exhibit.Back.Application.Interfaces.Services;
using Art_Exhibit.Back.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Art_Exhibit.Back.Application.Services
{
    public class TypeUserServices : ITypeUserServices
    {
        private readonly ITypeUserRepository _repository;

        public TypeUserServices(ITypeUserRepository repository)
        {
            _repository = repository;
        }

        private TypeUsersDTO MapToDTO(TypeUser TypeUser)
        {
            return new TypeUsersDTO
            {
                ID = TypeUser.ID,
                Description = TypeUser.Description
            };
        }


        public async Task<TypeUsersDTO?> AddTypeUserAsync(TypeUsersDTO typeUsersDTO)
        {
            var typeUsers = new TypeUser
            {
                ID = typeUsersDTO.ID,
                Description = typeUsersDTO.Description
            };
            var newtypeUsers = await _repository.AddAsync(typeUsers);
            if (newtypeUsers != null) return MapToDTO(newtypeUsers);
            return null;
        }

        public async Task DeleteTypeUserAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }

        public async Task<IEnumerable<TypeUsersDTO>> GetAllTypeUsersAsync()
        {
            var types = await _repository.GetAllAsync();
            var dtos = new List<TypeUsersDTO>();
            foreach (var typeUser in types)
            {
                dtos.Add(MapToDTO(typeUser));
            }
            return dtos;
        }

        public async Task<TypeUsersDTO?> GetTypeUserByIdAsync(int id)
        {
            var type = await _repository.GetByIdAsync(id);
            if (type != null) return MapToDTO(type);
            return null;
        }

        public async Task UpdateTypeUserAsync(TypeUsersDTO typeUsersDTO)
        {
            var type = await _repository.GetByIdAsync(typeUsersDTO.ID);
            if (type == null) throw new Exception("Type not found");
            type.ID = typeUsersDTO.ID;
            type.Description = typeUsersDTO.Description;
            await _repository.UpdateAsync(type);
        }
    }
}
