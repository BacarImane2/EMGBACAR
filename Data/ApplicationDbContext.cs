using Microsoft.EntityFrameworkCore;
using EMGBACAR.Models;
namespace EMGBACAR.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Voiture> Voitures { get; set; }
        public DbSet<Marque> Marques { get; set; }
        
         public DbSet<Utilisateur> Utilisateurs { get; set; }

    

    protected override void OnModelCreating(ModelBuilder modelBuilder){

        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Marque>().HasData(
            new Marque { Id = 1, Nom = "Toyota" },
            new Marque { Id = 2, Nom = "Honda" },
            new Marque { Id = 3, Nom = "Ford" },
            new Marque { Id = 4, Nom = "Chevrolet" },
            new Marque { Id = 5, Nom = "Nissan" },
            new Marque { Id = 6, Nom = "BMW" },
            new Marque { Id = 7, Nom = "Mercedes-Benz" },
            new Marque { Id = 8, Nom = "Hyundai" },
            new Marque { Id = 9, Nom = "Kia" },
            new Marque { Id = 10, Nom = "Volkswagen" }
        );

        modelBuilder.Entity<Voiture>().HasData(
            new Voiture { Id = 1, Nom = "Corolla", Annee = 2022, Prix = 15000, Description = "Voiture fiable", EstVendue = false, EstIndisponible = false, MarqueId = 1 },
            new Voiture { Id = 2, Nom = "Civic", Annee = 2023, Prix = 18000, Description = "Compact moderne", EstVendue = false, EstIndisponible = false, MarqueId = 2 }
        );
     }

    }
}
