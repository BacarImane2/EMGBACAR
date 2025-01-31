using System.Linq;
using EMGBACAR.Controllers;
using EMGBACAR.Data;
using EMGBACAR.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace EMGBACAR.Tests
{
    public class VoitureControllerTests
    {
        [Fact]
        public async Task Index_ReturnsView_WithListOfVoitures()
        {
            // Arrange
            // Configuration d'une base de données en mémoire pour le test avec un nom unique
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString()) // Utilisation d'un nom de base de données unique pour chaque test
                .Options;

            // Création du contexte et ajout des données de test
            using (var context = new ApplicationDbContext(options))
            {
                // Création et ajout d'une marque de test
                var marque = new Marque { Id = 1, Nom = "Test Marque" };
                context.Marques.Add(marque);
                await context.SaveChangesAsync();

                // Ajout de voitures de test
                context.Voitures.AddRange(
                    new Voiture 
                    { 
                        Id = 1,
                        Nom = "Voiture 1", 
                        Annee = 2020, 
                        Prix = 10000, 
                        EstVendue = false, 
                        EstIndisponible = false, 
                        Description = "Description voiture 1", 
                        MarqueId = marque.Id,
                        Marque = marque
                    },
                    new Voiture 
                    { 
                        Id = 2,
                        Nom = "Voiture 2", 
                        Annee = 2021, 
                        Prix = 20000, 
                        EstVendue = false, 
                        EstIndisponible = false, 
                        Description = "Description voiture 2", 
                        MarqueId = marque.Id,
                        Marque = marque
                    }
                );
                await context.SaveChangesAsync();
            }

            // Act - Utilisation d'une nouvelle instance du contexte pour vérifier la persistance des données
            using (var context = new ApplicationDbContext(options))
            {
                var controller = new VoitureController(context);
                var result = await controller.Index();

                // Assert
                var viewResult = Assert.IsType<ViewResult>(result); // Vérification que le résultat est de type ViewResult
                var model = Assert.IsAssignableFrom<IEnumerable<Voiture>>(viewResult.Model); // Vérification que le modèle est de type IEnumerable<Voiture>
                Assert.True(model.Any(), "La liste des voitures ne doit pas être vide"); // Vérification que la liste des voitures n'est pas vide
                Assert.Equal(2, model.Count()); // Vérification que le nombre de voitures est correct

                // Assertions supplémentaires pour vérifier les données
                var voitures = model.ToList();
                Assert.Equal("Voiture 1", voitures[0].Nom); // Vérification du nom de la première voiture
                Assert.Equal("Voiture 2", voitures[1].Nom); // Vérification du nom de la deuxième voiture
                Assert.NotNull(voitures[0].Marque); // Vérification que la marque de la première voiture n'est pas nulle
                Assert.NotNull(voitures[1].Marque); // Vérification que la marque de la deuxième voiture n'est pas nulle
            }
        }
    }
}
