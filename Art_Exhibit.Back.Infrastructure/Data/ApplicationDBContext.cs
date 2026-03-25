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

            //set unique constraint
            modelBuilder.Entity<Users>()
                .HasIndex(u => u.Username).IsUnique();

            //seed DB
            modelBuilder.Entity<TypeUser>().HasData(
                new TypeUser { ID = 1, Description = "User"},
                new TypeUser { ID = 2, Description = "Artiste" },
                new TypeUser { ID = 3, Description = "Admin" },
                new TypeUser { ID = 4, Description = "Banned" }
           );

            modelBuilder.Entity<Statut>().HasData(
                new Statut { Stat = "Waiting"},
                new Statut { Stat = "Refused" },
                new Statut { Stat = "Accepted" },
                new Statut { Stat = "Up for Auction" },
                new Statut { Stat = "Sold" }
            );

            modelBuilder.Entity<Categorie>().HasData(
                new Categorie { Cat = "Painting" },
                new Categorie { Cat = "Sculpture" },
                new Categorie { Cat = "Print" },
                new Categorie { Cat = "Other" }
                
            );
            


        }

        public DbSet<Users> Users { get; set; } = null!;
        public DbSet<TypeUser> TypeUsers { get; set; } = null!;

        public DbSet<Statut> Status { get; set; } = null!;
        public DbSet<Categorie> Categories { get; set; } = null!;
        public DbSet<Oeuvre> Oeuvres { get; set; } = null!;

        public DbSet<Enchere> Encheres { get; set; } = null!;
        public DbSet<Offre> Offres { get; set; } = null!; 
    }
}
