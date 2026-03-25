using Art_Exhibit.Back.Application.DTOs.Oeuvre;
using Art_Exhibit.Back.Application.Interfaces.Repositories;
using Art_Exhibit.Back.Application.Interfaces.Services;
using Art_Exhibit.Back.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Art_Exhibit.Back.Application.Services
{
    public class OeuvreServices:IOeuvreServices
    {
        private readonly IOeuvreRepository _repository;
        private readonly IUsersRepository _usersRepository;
        private readonly ICategoryRepository _categoryRepository;
        public OeuvreServices(IOeuvreRepository repository, IUsersRepository usersRepository, ICategoryRepository categoryRepository)
        {
            _repository = repository;
            _usersRepository = usersRepository;
            _categoryRepository = categoryRepository;
        }

        private OeuvreDTO MapToDTO(Oeuvre oeuvre)
        {
            return new OeuvreDTO
            {
                Id = oeuvre.Id,
                Auteur = oeuvre.Auteur,
                Categorie = oeuvre.Categorie,
                Exemplaire = oeuvre.Exemplaire,
                Nbre_exemplaire = oeuvre.Nbre_exemplaire,
                IsAuthentified = oeuvre.IsAuthentified,
                Titre = oeuvre.Titre,
                Description = oeuvre.Description,
                Longueur = oeuvre.Longueur,
                Largeur = oeuvre.Largeur,
                Profondeur = oeuvre.Profondeur,
                Statut = oeuvre.Statut
            };
        }

        
        public async Task<OeuvreDTO?> AddOeuvreAsync(CreateOeuvreDTO OeuvreDTO)
        {
            var auteur = await _usersRepository.GetByIdAsync(OeuvreDTO.Auteur.Id);
            if (auteur == null) throw new Exception("Author not found");
                
            var categorie = await _categoryRepository.GetAsync(OeuvreDTO.Categorie);
            if (categorie == null) throw new Exception("category not found");

            var oeuvre = new Oeuvre
            {
                Id = OeuvreDTO.Id,
                Auteur = auteur,
                Categorie = categorie,
                Exemplaire = OeuvreDTO.Exemplaire,
                Nbre_exemplaire = OeuvreDTO.Nbre_exemplaire,
                IsAuthentified = false,
                Titre = OeuvreDTO.Titre,
                Description = OeuvreDTO.Description,
                Longueur = OeuvreDTO.Longueur,
                Largeur = OeuvreDTO.Largeur,
                Profondeur = OeuvreDTO.Profondeur,
                Statut = new Statut { Stat = "Waiting"}
            };
            var newoeuvre = await _repository.AddAsync(oeuvre);
            if (newoeuvre != null) return MapToDTO(newoeuvre);
            return null;
        }

        public async Task DeleteOeuvreAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }

        public async Task<IEnumerable<OeuvreDTO>> GetAllOeuvresAsync()
        {
            var oeuvre = await _repository.GetAllAsync();
            var dtos = new List<OeuvreDTO>();
            foreach (var o in oeuvre)
            {
                dtos.Add(MapToDTO(o));
            }
            return dtos;
        }

        public async Task<OeuvreDTO?> GetOeuvreByIdAsync(int id)
        {
            var oeuvre = await _repository.GetByIdAsync(id);
            if (oeuvre == null) return null;
            return MapToDTO(oeuvre);
        }

        public async Task UpdateOeuvreAsync(OeuvreDTO OeuvreDTO)
        {
            var oeuvre = await _repository.GetByIdAsync(OeuvreDTO.Id);
            if (oeuvre == null) throw new Exception("Work not found");
            oeuvre.Id = OeuvreDTO.Id;
            oeuvre.Auteur = OeuvreDTO.Auteur;
            oeuvre.Categorie = OeuvreDTO.Categorie;
            oeuvre.Exemplaire = OeuvreDTO.Exemplaire;
            oeuvre.Nbre_exemplaire = OeuvreDTO.Nbre_exemplaire;
            oeuvre.IsAuthentified = OeuvreDTO.IsAuthentified;
            oeuvre.Titre = OeuvreDTO.Titre;
            oeuvre.Description = OeuvreDTO.Description;
            oeuvre.Longueur = OeuvreDTO.Longueur;
            oeuvre.Largeur = OeuvreDTO.Largeur;
            oeuvre.Profondeur = OeuvreDTO.Profondeur;
            oeuvre.Statut = OeuvreDTO.Statut;

            await _repository.UpdateAsync(oeuvre);
        }
    }
}
