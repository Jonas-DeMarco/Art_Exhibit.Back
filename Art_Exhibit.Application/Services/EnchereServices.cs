using Art_Exhibit.Back.Application.DTOs.Enchere;
using Art_Exhibit.Back.Application.DTOs.Oeuvre;
using Art_Exhibit.Back.Application.Interfaces.Repositories;
using Art_Exhibit.Back.Application.Interfaces.Services;
using Art_Exhibit.Back.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Art_Exhibit.Back.Application.Services
{
    public class EnchereServices : IEnchereServices
    {
        private readonly IEnchereRepository _repository;
        private readonly IOeuvreRepository _oeuvreRepository;

        public EnchereServices(IEnchereRepository repository, IOeuvreRepository oeuvreRepository)
        {
            _repository = repository;
            _oeuvreRepository = oeuvreRepository;
        }

        private EnchereDTO MapToDTO(Enchere enchere)
        {
            var oeuvre = new OeuvreEnchereDTO
            {
                Auteur_Username = enchere.Oeuvre.Auteur.Username,
                Categorie_Cat = enchere.Oeuvre.Categorie.Cat,
                Exemplaire = enchere.Oeuvre.Exemplaire,
                Nbre_exemplaire = enchere.Oeuvre.Nbre_exemplaire,
                IsAuthentified = enchere.Oeuvre.IsAuthentified,
                Titre = enchere.Oeuvre.Titre,
                Description = enchere.Oeuvre.Description,
                Longueur = enchere.Oeuvre.Longueur,
                Largeur = enchere.Oeuvre.Largeur,
                Profondeur = enchere.Oeuvre.Profondeur
            };
            return new EnchereDTO 
            { 
                Id = enchere.Id,
                Date_debut = enchere.Date_debut,
                Date_fin = enchere.Date_fin,
                OeuvreDTO = oeuvre,
                Prix_reserve = enchere.Prix_reserve,
                Incr_mini = enchere.Incr_mini,
                Duree_antisniping = enchere.Duree_antisniping
            };
        }
        public async Task<EnchereDTO?> AddEnchereAsync(CreateEnchereDTO EnchereDTO)
        {
            var Oeuvre = await _oeuvreRepository.GetByIdAsync(EnchereDTO.Oeuvreid);
            if (Oeuvre == null) throw new Exception("Work not found");

            var Enchere = new Enchere
            {
                Id = EnchereDTO.Id,
                Date_debut = EnchereDTO.Date_debut,
                Date_fin = EnchereDTO.Date_fin,
                Oeuvre = Oeuvre,
                Prix_reserve = EnchereDTO.Prix_reserve,
                Incr_mini = EnchereDTO.Incr_mini,
                Duree_antisniping = EnchereDTO.Duree_antisniping
            };
            var newEnchere = await _repository.AddAsync(Enchere);
            if (newEnchere != null) return MapToDTO(newEnchere);
            return null;
        }

        public async Task DeleteEnchereAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }

        public async Task<IEnumerable<EnchereDTO>> GetAllEncheresAsync()
        {
            var Enchere = await _repository.GetAllAsync();
            var dtos = new List<EnchereDTO>();
            foreach (var e in Enchere) dtos.Add(MapToDTO(e));
            return dtos;
        }

        public async Task<EnchereDTO?> GetEnchereByIdAsync(int id)
        {
            var enchere = await _repository.GetByIdAsync(id);
            if (enchere == null) return null;
            return MapToDTO(enchere);
        }

        public async Task UpdateEnchereAsync(CreateEnchereDTO EnchereDTO)
        {
            var enchere = await _repository.GetByIdAsync(EnchereDTO.Id);
            if (enchere == null) throw new Exception("Auction not found");
            var Oeuvre = await _oeuvreRepository.GetByIdAsync(EnchereDTO.Oeuvreid);
            if (Oeuvre == null) throw new Exception("Work not found");
            enchere.Id = EnchereDTO.Id;
            enchere.Date_debut = EnchereDTO.Date_debut;
            enchere.Date_fin = EnchereDTO.Date_fin;
            enchere.Oeuvre = Oeuvre;
            enchere.Prix_reserve = EnchereDTO.Prix_reserve;
            enchere.Incr_mini = EnchereDTO.Incr_mini;
            enchere.Duree_antisniping = EnchereDTO.Duree_antisniping;
            await _repository.UpdateAsync(enchere);
        }
    }
}
