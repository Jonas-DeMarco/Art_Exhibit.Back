using Art_Exhibit.Back.Application.DTOs.Offre;
using Art_Exhibit.Back.Application.Interfaces.Repositories;
using Art_Exhibit.Back.Application.Interfaces.Services;
using Art_Exhibit.Back.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Art_Exhibit.Back.Application.Services
{
    public class OffreServices : IOffreServices
    {
        private readonly IOffreRepository _repository;
        private readonly IEnchereRepository _enchereRepository;
        private readonly IUsersRepository _usersRepository;

        public OffreServices (IOffreRepository repository,IEnchereRepository enchereRepository, IUsersRepository usersrepository)
        {
            _repository = repository;
            _enchereRepository = enchereRepository;
            _usersRepository = usersrepository;
        }

        public OffreDTO MaptoDTO(Offre offre) {


            return new OffreDTO
            {
                Id = offre.Id,
                Bidder = offre.Bidder,
                Enchere = offre.Enchere,
                Price = offre.Price,
                Timestamp = offre.Timestamp
            };
        }

        public async Task<OffreDTO?> AddOffreAsync(CreateOffreDTO OffreDTO)
        {
            var bidder = await _usersRepository.GetByIdAsync(OffreDTO.Bidder_Id);
            if (bidder == null) throw new Exception("User not found");

            var enchere = await _enchereRepository.GetByIdAsync(OffreDTO.Enchere_Id);
            if (enchere == null) throw new Exception("Auction not found");

            var offre = new Offre
            {
                Id = OffreDTO.Id,
                Bidder = bidder,
                Enchere = enchere,
                Timestamp = OffreDTO.Timestamp,
                Price = OffreDTO.Price
            };
            var newOffre = await _repository.AddAsync(offre);
            if (newOffre != null) return MaptoDTO(newOffre);
            return null;
        }

        public async Task DeleteOffreAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }

        public async Task<IEnumerable<OffreDTO>> GetAllOffresAsync()
        {
            var offre = await _repository.GetAllAsync();
            var dtos = new List<OffreDTO>();
            foreach (var o in offre) dtos.Add(MaptoDTO(o));
            return dtos;
        }

        public async Task<OffreDTO?> GetOffreByIdAsync(int id)
        {
            var offre = await _repository.GetByIdAsync(id);
            if (offre == null) return null;
            return MaptoDTO(offre);
        }
    }
}
