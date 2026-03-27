using System;
using System.Collections.Generic;
using System.Text;

namespace Art_Exhibit.Back.Application.DTOs.Offre
{
    public class CreateOffreDTO
    {

        
        public int Bidder_Id { get; set; }
        public int Enchere_Id { get; set; }
        public DateTime Timestamp { get; set; }
        public float Price { get; set; }
    }
}
