using Art_Exhibit.Back.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Art_Exhibit.Back.Application.DTOs.Offre
{
    public class OffreDTO
    {
        public int Id { get; set; }
        public int BidderId { get; set; }
        public int EnchereId{ get; set; }
        public DateTime Timestamp { get; set; }
        public float Price { get; set; }
    }
}
