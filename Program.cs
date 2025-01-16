using EMGBACAR.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Ajouter le contexte de base de données avec SQLite
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

// Ajouter les services pour les contrôleurs avec vues
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure le pipeline HTTP
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts(); // Utilisation du HSTS pour la production
}

app.UseHttpsRedirection();
app.UseStaticFiles(); // Assure que les fichiers statiques (CSS, JS, images) sont servis correctement

app.UseRouting();

app.UseAuthorization();

// Configure la route par défaut pour les contrôleurs
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
