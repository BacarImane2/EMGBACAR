using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using EMGBACAR.Controllers;
using EMGBACAR.Models;
using Xunit;

namespace EMGBACAR.Tests
{
    public class AccountControllerTests
    {
        // Déclaration des mocks nécessaires pour tester le contrôleur
        private readonly Mock<UserManager<Utilisateur>> _mockUserManager;
        private readonly Mock<SignInManager<Utilisateur>> _mockSignInManager;
        private readonly Mock<ILogger<AccountController>> _mockLogger;
        private readonly AccountController _controller;

        // Constructeur de la classe de tests : configure les mocks et initialise le contrôleur
        public AccountControllerTests()
        {
            // Création du mock pour UserManager
            var userStoreMock = new Mock<IUserStore<Utilisateur>>();
            _mockUserManager = new Mock<UserManager<Utilisateur>>(
                userStoreMock.Object,
                null, null, null, null, null, null, null, null
            );

            // Création du mock pour SignInManager
            _mockSignInManager = new Mock<SignInManager<Utilisateur>>(
                _mockUserManager.Object,
                Mock.Of<Microsoft.AspNetCore.Http.IHttpContextAccessor>(),
                Mock.Of<IUserClaimsPrincipalFactory<Utilisateur>>(),
                null, null, null, null
            );

            // Création du mock pour le logger
            _mockLogger = new Mock<ILogger<AccountController>>();

            // Initialisation du contrôleur avec les mocks
            _controller = new AccountController(
                _mockLogger.Object,
                _mockUserManager.Object,
                _mockSignInManager.Object
            );
        }

        // Test de la méthode GET Register, elle doit retourner une vue
        [Fact]
        public void Register_GET_ReturnsViewResult()
        {
            // Act : Appel de l'action Register
            var result = _controller.Register();

            // Assert : Vérification que la méthode retourne bien une vue
            Assert.IsType<ViewResult>(result);
        }

        // Test de la méthode POST Register avec des données valides
        [Fact]
        public async Task Register_POST_ValidModel_RedirectsToIndex()
        {
            // Arrange : Préparation du modèle de données valide
            var model = new RegisterViewModel
            {
                Email = "test@test.com",
                Password = "Password123!",
                ConfirmPassword = "Password123!"
            };

            var user = new Utilisateur();
            // Simulation des appels à UserManager pour la création d'un utilisateur et l'ajout de rôle
            _mockUserManager.Setup(x => x.CreateAsync(It.IsAny<Utilisateur>(), model.Password))
                .ReturnsAsync(IdentityResult.Success);
            _mockUserManager.Setup(x => x.AddToRoleAsync(It.IsAny<Utilisateur>(), "User"))
                .ReturnsAsync(IdentityResult.Success);

            // Act : Appel de l'action Register avec le modèle
            var result = await _controller.Register(model);

            // Assert : Vérification que l'utilisateur est redirigé vers l'index de Voiture
            var redirectResult = Assert.IsType<RedirectToActionResult>(result);
            Assert.Equal("Index", redirectResult.ActionName);
            Assert.Equal("Voiture", redirectResult.ControllerName);
        }

    }
}