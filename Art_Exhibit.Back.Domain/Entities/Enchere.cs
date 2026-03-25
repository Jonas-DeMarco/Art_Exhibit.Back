using System;
using System.Collections.Generic;
using System.Text;

namespace Art_Exhibit.Back.Domain.Entities
{
    public class Enchere
    {
        public int Id { get; set; }
        public DateTime Date_debut { get; set; }
        public DateTime Date_fin { get; set; }

        public Oeuvre Oeuvre { get; set; }
        public float Prix_reserve { get; set; }
        public float Incr_mini { get; set; }
        public int Duree_antisniping { get; set; }

    }
}
