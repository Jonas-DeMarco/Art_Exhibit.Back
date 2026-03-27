using Art_Exhibit.Back.Application.DTOs.Offre;
using Art_Exhibit.Back.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Art_Exhibit.Back.Application.Interfaces.Services
{
    public interface IOffreServices
    {
        Task<IEnumerable<OffreDTO>> GetAllOffresAsync();

        Task<OffreDTO?> GetOffreByIdAsync(int id);

        Task<OffreDTO?> AddOffreAsync(CreateOffreDTO OffreDTO);
        Task DeleteOffreAsync(int id);


        Task<OffreDTO?> GetLastBidAsync(int enchereid);
        Task<IEnumerable<OffreDTO?>> GetBidsAsync(int enchereid);
    }
}
