using Art_Exhibit.Back.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Art_Exhibit.Back.Application.DTOs.Users
{
    public class UsersDTO
    {
        public int Id { get; set; }
        public TypeUser Type { get; set; } 

        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;
    }
}
