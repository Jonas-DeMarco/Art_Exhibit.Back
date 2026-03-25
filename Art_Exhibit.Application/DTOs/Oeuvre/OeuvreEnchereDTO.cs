using System;
using System.Collections.Generic;
using System.Text;

namespace Art_Exhibit.Back.Application.DTOs.Oeuvre
{
    public class OeuvreEnchereDTO
    {
        public string Auteur_Username { get; set; }
        public string Categorie_Cat { get; set; }

        public int Exemplaire { get; set; } = 1;

        public int Nbre_exemplaire { get; set; } = 1;

        public bool IsAuthentified { get; set; } = false;

        public string Titre { get; set; }
        public string Description { get; set; }
        public float Longueur { get; set; }
        public float Largeur { get; set; }
        public float Profondeur { get; set; }
    }
}
