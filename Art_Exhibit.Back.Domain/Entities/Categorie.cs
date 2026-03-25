using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Art_Exhibit.Back.Domain.Entities
{
    public class Categorie
    {
        [Key]
        public required string Cat {  get; set; }
    }
}
