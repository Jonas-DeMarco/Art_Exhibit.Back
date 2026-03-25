using Art_Exhibit.Back.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Art_Exhibit.Back.Application.DTOs.Oeuvre
{
    public class CreateOeuvreDTO
    {
        public string Auteur_username { get; set; }

        public string Categorie { get; set; }
        public string Titre { get; set; }
        public string Description { get; set; }
        public float Longueur { get; set; }
        public float Largeur { get; set; }
        public float Profondeur { get; set; }
    }
}
