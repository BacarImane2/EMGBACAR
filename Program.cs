<<<<<<< HEAD
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
=======
using EMGBACAR.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Ajouter le contexte de base de données avec SQLite
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

// Ajouter les services pour les contrôleurs avec vues
>>>>>>> 388a0fd ( migration avec la base de donner sqllite)
builder.Services.AddControllersWithViews();

var app = builder.Build();

<<<<<<< HEAD
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
=======
// Configure le pipeline HTTP
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts(); // Utilisation du HSTS pour la production
}

app.UseHttpsRedirection();
app.UseStaticFiles(); // Assure que les fichiers statiques (CSS, JS, images) sont servis correctement

>>>>>>> 388a0fd ( migration avec la base de donner sqllite)
app.UseRouting();

app.UseAuthorization();

<<<<<<< HEAD
app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();

=======
// Configure la route par défaut pour les contrôleurs
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
>>>>>>> 388a0fd ( migration avec la base de donner sqllite)

app.Run();
