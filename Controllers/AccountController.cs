using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using EMGBACAR.Models;
using Microsoft.Extensions.Logging;

namespace EMGBACAR.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<Utilisateur> _userManager;
        private readonly SignInManager<Utilisateur> _signInManager;
        private readonly ILogger<AccountController> _logger;

        // Garder un seul constructeur avec l'injection de dépendances
        public AccountController(ILogger<AccountController> logger, UserManager<Utilisateur> userManager, SignInManager<Utilisateur> signInManager)
        {
            _logger = logger;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        // Afficher la page d'inscription
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new Utilisateur
                {
                    UserName = model.Email,
                    Email = model.Email
                };
                
                // Création de l'utilisateur
                var result = await _userManager.CreateAsync(user, model.Password);
                
                if (result.Succeeded)
                {
                    // Assigner un rôle à l'utilisateur après sa création 
                    var roleResult = await _userManager.AddToRoleAsync(user, "User"); // "User" ou "Admin" en fonction de ton besoin
                    if (roleResult.Succeeded)
                    {
                        // Connexion automatique de l'utilisateur
                        await _signInManager.SignInAsync(user, isPersistent: false);
                        return RedirectToAction("Index", "Voiture");
                    }
                    else
                    {
                        // Si l'ajout du rôle échoue, on ajoute les erreurs
                        foreach (var error in roleResult.Errors)
                        {
                            ModelState.AddModelError(string.Empty, error.Description);
                        }
                    }
                }

                // Si la création de l'utilisateur échoue, on ajoute les erreurs
                foreach (var error in result.Errors)
                {
            ModelState.AddModelError(string.Empty, error.Description);
        }
            }
            return View(model);
        }


        // Afficher la page de connexion
        public IActionResult Login()
        {
            return View();
        }

        // Traitement de la connexion
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByEmailAsync(model.Email);
                if (user == null)
                {
                    _logger.LogWarning($"Utilisateur {model.Email} non trouvé.");
                    ModelState.AddModelError(string.Empty, "Email ou mot de passe incorrect.");
                    return View(model);
                }

                var result = await _signInManager.PasswordSignInAsync(user, model.Password, model.RememberMe, false);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Voiture");
                }
                
                ModelState.AddModelError(string.Empty, "Échec de la connexion.");
            }
            return View(model);
        }

        // Déconnexion
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Voiture");
        }
    }
}
