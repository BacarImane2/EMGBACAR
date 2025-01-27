using Microsoft.EntityFrameworkCore;
using EMGBACAR.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace EMGBACAR.Data
{
    public class ApplicationDbContext : IdentityDbContext<Utilisateur>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Voiture> Voitures { get; set; }
        public DbSet<Marque> Marques { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Créer des rôles par défaut avec des noms fixes
            var roleAdmin = new IdentityRole { Id = "1", Name = "Admin", NormalizedName = "ADMIN" };
            var roleUser = new IdentityRole { Id = "2", Name = "User", NormalizedName = "USER" };

            modelBuilder.Entity<IdentityRole>().HasData(roleAdmin, roleUser);

            // Créer des marques de voitures avec des Ids fixes
            modelBuilder.Entity<Marque>().HasData(
                new Marque { Id = 1, Nom = "Toyota" },
                new Marque { Id = 2, Nom = "Honda" },
                new Marque { Id = 3, Nom = "Ford" },
                new Marque { Id = 4, Nom = "Chevrolet" },
                new Marque { Id = 5, Nom = "BMW" },
                new Marque { Id = 6, Nom = "Mercedes-Benz" },
                new Marque { Id = 7, Nom = "Audi" },
                new Marque { Id = 8, Nom = "Volkswagen" },
                new Marque { Id = 9, Nom = "Hyundai" },
                new Marque { Id = 10, Nom = "Nissan" },
                new Marque { Id = 11, Nom = "Kia" },
                new Marque { Id = 12, Nom = "Mazda" },
                new Marque { Id = 13, Nom = "Subaru" },
                new Marque { Id = 14, Nom = "Porsche" },
                new Marque { Id = 15, Nom = "Tesla" }
            );


            // Créer des voitures avec des Ids fixes et des données statiques
            modelBuilder.Entity<Voiture>().HasData(
                new Voiture { Id = 1, Nom = "Corolla", Annee = 2022, Prix = 15000, Description = "Voiture fiable", EstVendue = false, EstIndisponible = false, MarqueId = 1 },
                new Voiture { Id = 2, Nom = "Civic", Annee = 2023, Prix = 18000, Description = "Compact moderne", EstVendue = false, EstIndisponible = false, MarqueId = 2 }
            );
    }

    }
}
