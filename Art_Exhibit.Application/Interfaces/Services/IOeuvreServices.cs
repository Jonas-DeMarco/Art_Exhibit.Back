using Art_Exhibit.Back.Application.DTOs.Oeuvre;
using System;
using System.Collections.Generic;
using System.Text;

namespace Art_Exhibit.Back.Application.Interfaces.Services
{
    public interface IOeuvreServices
    {
        Task<IEnumerable<OeuvreDTO>> GetAllOeuvresAsync();

        Task<OeuvreDTO?> GetOeuvreByIdAsync(int id);

        Task<OeuvreDTO?> AddOeuvreAsync(CreateOeuvreDTO OeuvreDTO);
        Task UpdateOeuvreAsync(OeuvreDTO OeuvreDTO);
        Task DeleteOeuvreAsync(int id);


        Task<IEnumerable<string>> GetCategoriesAsync();
    }
}
