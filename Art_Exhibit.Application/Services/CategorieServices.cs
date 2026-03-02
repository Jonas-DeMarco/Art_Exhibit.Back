using Art_Exhibit.Back.Application.Interfaces.Repositories;
using Art_Exhibit.Back.Application.Interfaces.Services;
using Art_Exhibit.Back.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Art_Exhibit.Back.Application.Services
{
    public class CategorieServices : ICategorieServices
    {
        private readonly ICategorieRepository _repository;
        public CategorieServices(ICategorieRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Categorie>> GetAllCategorieAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Categorie?> GetCategorieByCatAsync(string Cat)
        {
            var categorie = await _repository.GetByCatAsync(Cat);
            if (categorie == null) return null;
            return categorie;
        }
    }
}
