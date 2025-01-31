using EMGBACAR.Data;
using EMGBACAR.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Configuration de la base de données avec SQLite
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Configuration des services d'ASP.NET Identity
builder.Services.AddIdentity<Utilisateur, IdentityRole>(options =>
{
    // Configuration des options de mot de passe
    options.Password.RequireDigit = true;
    options.Password.RequiredLength = 6;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireUppercase = true;
    options.Password.RequireLowercase = true;
})
.AddEntityFrameworkStores<ApplicationDbContext>()  // Utilisation du contexte de données pour Identity
.AddDefaultTokenProviders();  // Ajout des fournisseurs de tokens pour la validation

// Ajout des services pour les contrôleurs avec vues
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Initialisation de l'administrateur et des rôles
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    try
    {
        var userManager = services.GetRequiredService<UserManager<Utilisateur>>();
        var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();

        // Créer les rôles Admin et User s'ils n'existent pas
        if (!await roleManager.RoleExistsAsync("Admin"))
        {
            await roleManager.CreateAsync(new IdentityRole("Admin"));
        }

        if (!await roleManager.RoleExistsAsync("User"))
        {
            await roleManager.CreateAsync(new IdentityRole("User"));
        }

        // Créer l'utilisateur admin s'il n'existe pas
        var adminUser = await userManager.FindByEmailAsync("admin@emgb.com");
        if (adminUser == null)
        {
            adminUser = new Utilisateur
            {
                UserName = "admin@emgb.com",
                Email = "admin@emgb.com",
                EmailConfirmed = true,
            };
            var result = await userManager.CreateAsync(adminUser, "Admin@123");
            if (result.Succeeded)
            {
                // Attribuer le rôle Admin à l'utilisateur
                await userManager.AddToRoleAsync(adminUser, "Admin");
            }
        }
    }
    catch (Exception ex)
    {
        var logger = services.GetRequiredService<ILogger<Program>>();
        logger.LogError(ex, "Une erreur s'est produite lors de la création des rôles et de l'utilisateur admin.");
    }
}

// Configuration du pipeline HTTP
if (!app.Environment.IsDevelopment())
{
    // Gestion des erreurs en production
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts(); // Activation de HSTS pour la production
}

app.UseHttpsRedirection();  // Redirection vers HTTPS
app.UseStaticFiles();  // Serveur les fichiers statiques (CSS, JS, images)

app.UseRouting();  // Utilisation du routage

// Authentification avant autorisation
app.UseAuthentication();
app.UseAuthorization();  // Gestion de l'autorisation

// Configuration de la route par défaut
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Voiture}/{action=Index}/{id?}");

app.Run();  // Démarre l'application
