using Art_Exhibit.Back.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Art_Exhibit.Back.Application.DTOs.Offre
{
    public class OffreDTO
    {
        public int Id { get; set; }
        public Domain.Entities.Users Bidder { get; set; }
        public Domain.Entities.Enchere Enchere{ get; set; }
        public DateTime Timestamp { get; set; }
        public float Price { get; set; }
    }
}
