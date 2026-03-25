using Art_Exhibit.Back.Application.DTOs.Enchere;
using Art_Exhibit.Back.Application.DTOs.Oeuvre;
using System;
using System.Collections.Generic;
using System.Text;

namespace Art_Exhibit.Back.Application.Interfaces.Services
{
    public interface IEnchereServices
    {
        Task<IEnumerable<EnchereDTO>> GetAllEncheresAsync();

        Task<EnchereDTO?> GetEnchereByIdAsync(int id);

        Task<EnchereDTO?> AddEnchereAsync(CreateEnchereDTO EnchereDTO);
        Task UpdateEnchereAsync(EnchereDTO EnchereDTO);
        Task DeleteEnchereAsync(int id);
    }
}
