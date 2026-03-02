using Art_Exhibit.Back.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Art_Exhibit.Back.Application.DTOs.Oeuvre
{
    public class CreateOeuvreDTO
    {
        public int Id { get; set; }
        public Domain.Entities.Users Auteur { get; set; }

        public Categorie Categorie { get; set; }

        public int Exemplaire { get; set; } = 1;
        public int Nbre_exemplaire { get; set; } = 1;
        public string Titre { get; set; }
        public string Description { get; set; }
        public float Longueur { get; set; }
        public float Largeur { get; set; }
        public float Profondeur { get; set; }
    }
}
