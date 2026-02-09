using System;
using System.Collections.Generic;
using System.Text;

namespace Art_Exhibit.Back.Domain.Entities
{
    public class Address
    {
        public int Id { get; set; } 
        public Users User { get; set; }

        public string Ville {  get; set; }

        public string Rue { get; set; }

        public string Numero { get; set; }

        public string Complement {  get; set; }

        public string Code_Postal { get; set; }

        public string Pays { get; set; }
    }
}
