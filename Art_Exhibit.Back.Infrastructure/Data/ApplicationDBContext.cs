using System;
using System.Collections.Generic;
using System.Globalization;
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

            modelBuilder.Entity<Users>().HasData(
                new
                {
                    Id = 1,
                    Username = "Userman1",
                    Email = "Userman1@Userman.vom",
                    Password = "Userman1",
                    TypeID = 1

                },
                new
                {
                    Id = 2,
                    Username = "Artisteman1",
                    Email = "Artisteman1@Artisteman.com",
                    Password = "Artisteman1",
                    TypeID = 2

                },
                new
                {
                    Id = 3,
                    Username = "Artisteman2",
                    Email = "Artisteman2@Artisteman.com",
                    Password = "Artisteman2",
                    TypeID = 2

                },
               new
               {
                   Id = 4,
                   Username = "Artisteman3",
                   Email = "Artisteman3@Artisteman.com",
                   Password = "Artisteman3",
                   TypeID = 2

               },
                new
                {
                    Id = 5,
                    Username = "Amdinman",
                    Email = "adminman@admin.com",
                    Password = "adminman",
                    TypeID = 3

                },
                new
                {
                    Id = 6,
                    Username = "BannedMan",
                    Email = "BannedMan@Badman.evil",
                    Password = "Spooky",
                    TypeID = 4

                }
            );

            modelBuilder.Entity<Oeuvre>().HasData(
                new {
                    Id = 1,
                    Titre = "Blue sky",
                    Description = "A painting of a blue sky",
                    IsAuthentified = false,
                    Longueur = (float)12,
                    Largeur = (float)13,
                    Profondeur = (float)2,
                    AuteurId = 2,
                    CategorieCat = "Painting",
                    StatutStat = "Waiting"
                },
                new
                {
                    Id = 2,
                    Titre = "red sky",
                    Description = "a painting of a red sky",
                    IsAuthentified = false,
                    Longueur = (float)25,
                    Largeur = (float)32,
                    Profondeur = (float)2,
                    AuteurId = 2,
                    CategorieCat = "Painting",
                    StatutStat = "Waiting"
                },
                new
                {
                    Id = 3,
                    Titre = "The Man",
                    Description = "A sculpture of a man with a Hat",
                    IsAuthentified = false,
                    Longueur = (float)60,
                    Largeur = (float)150,
                    Profondeur = (float)45,
                    AuteurId = 3,
                    CategorieCat = "Sculpture",
                    StatutStat = "Waiting"
                },
                new
                {
                    Id = 4,
                    Titre = "The Machine",
                    Description = "A sculpture of a robot with a Hat",
                    IsAuthentified = false,
                    Longueur = (float)150,
                    Largeur = (float)45,
                    Profondeur = (float)60,
                    AuteurId = 3,
                    CategorieCat = "Sculpture",
                    StatutStat = "Waiting"
                },
                new
                {
                    Id = 5,
                    Titre = "Love of my life",
                    Description = "A printed copy of a digital art of my wife",
                    IsAuthentified = false,
                    Longueur = (float)24,
                    Largeur = (float)24,
                    Profondeur = (float)1,
                    AuteurId = 4,
                    CategorieCat = "Print",
                    StatutStat = "Waiting"
                },
                new
                {
                    Id = 6,
                    Titre = "A smile with a pretty face",
                    Description = "A smile with a pretty face",
                    IsAuthentified = false,
                    Longueur = (float)24,
                    Largeur = (float)234,
                    Profondeur = (float)1222,
                    AuteurId =4,
                    CategorieCat ="Other",
                    StatutStat = "Waiting"
                }
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
