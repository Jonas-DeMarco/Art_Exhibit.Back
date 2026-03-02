using Art_Exhibit.Back.Application.Interfaces.Repositories;
using Art_Exhibit.Back.Application.Interfaces.Services;
using Art_Exhibit.Back.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Art_Exhibit.Back.Application.Services
{
    public class StatutServices : IStatutServices
    {
        private readonly IStatutRepository _repository;

        public StatutServices(IStatutRepository repository)
        {
            _repository = repository;
        }
        public async Task<IEnumerable<Statut>> GetAllStatutsAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Statut?> GetStatutByStatAsync(string Stat)
        {
            var statut = await _repository.GetByStatAsync(Stat);
            if (statut == null) return null;
            return statut;
        }
    }
}
