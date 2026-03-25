using System;
using System.Collections.Generic;
using System.Text;

namespace Art_Exhibit.Back.Domain.Entities
{
    public class Offre
    {
        public int Id { get; set; }
        public Users Bidder { get; set; }
        public Enchere Enchere { get; set; }
        public DateTime Timestamp { get; set; }
        public float Price { get; set; }
    }
}
