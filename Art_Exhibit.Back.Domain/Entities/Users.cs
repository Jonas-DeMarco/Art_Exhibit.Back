using System;
using System.Collections.Generic;
using System.Text;

namespace Art_Exhibit.Back.Domain.Entities
{
    public class Users
    {
        public int Id { get; set; }
        public TypeUser Type { get; set; }

        public string Username { get; set; }
        public string Password { get; set; }

        public string Email { get; set; }

    }
}
