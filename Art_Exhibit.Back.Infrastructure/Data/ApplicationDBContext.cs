using System;
using System.Collections.Generic;
using System.Text;
using Art_Exhibit.Back.Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace Art_Exhibit.Back.Infrastructure.Data
{
    public class ApplicationDBContext : IdentityDbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
            : base (options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


        }

        public DbSet<Users> Users { get; set; } = null!;
        public DbSet<TypeUser> TypeUsers { get; set; } = null!;

        public DbSet<Statut> Statuts { get; set; } = null!;
        public DbSet<Categorie> Categories { get; set; } = null!;
        public DbSet<Oeuvre> Oeuvres { get; set; } = null!;
    }
}
