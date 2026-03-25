using Art_Exhibit.Back.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Art_Exhibit.Back.Application.DTOs.Oeuvre
{
    public class OeuvreDTO
    {
        public int Id { get; set; }
        public string Auteur { get; set; }

        public string Categorie { get; set; }

        public int Exemplaire { get; set; } = 1;

        public int Nbre_exemplaire { get; set; } = 1;

        public bool IsAuthentified { get; set; } = false;

        public string Titre { get; set; }
        public string Description { get; set; }
        public float Longueur { get; set; }
        public float Largeur { get; set; }
        public float Profondeur { get; set; }
        public string Statut { get; set; }
    }
}
