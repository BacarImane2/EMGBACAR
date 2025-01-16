using Microsoft.EntityFrameworkCore;
using EMGBACAR.Models;
namespace EMGBACAR.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Voiture> Voitures { get; set; }
        public DbSet<Marque> Marques { get; set; }
    

    protected override void OnModelCreating(ModelBuilder modelBuilder){

        base.OnModelCreating(modelBuilder);

        // Données de test pour les marques
        modelBuilder.Entity<Marque>().HasData(
            new Marque { Id = 1, Nom = "Toyota" },
            new Marque { Id = 2, Nom = "Honda" }
        );
        modelBuilder.Entity<Voiture>().HasData(
            new Voiture { Id = 1, Nom = "Corolla", Annee = 2022, Prix = 15000, Description = "Voiture fiable", EstVendue = false, EstIndisponible = false, MarqueId = 1 },
            new Voiture { Id = 2, Nom = "Civic", Annee = 2023, Prix = 18000, Description = "Compact moderne", EstVendue = false, EstIndisponible = false, MarqueId = 2 }
        );
     }

    }
}
