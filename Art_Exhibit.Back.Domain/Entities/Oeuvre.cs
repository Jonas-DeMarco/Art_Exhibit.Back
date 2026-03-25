using System;
using System.Collections.Generic;
using System.Text;

namespace Art_Exhibit.Back.Domain.Entities
{
    public class Oeuvre
    {
        public int Id { get; set; }
        public Users Auteur { get; set; }

        public Categorie Categorie { get; set; }
        public bool IsAuthentified { get; set; } = false;

        public string Titre { get; set; }
        public string Description { get; set; }
        public float Longueur { get; set; }
        public float Largeur { get; set; }
        public float Profondeur { get; set; }
        public Statut Statut { get; set; }


    }
}
