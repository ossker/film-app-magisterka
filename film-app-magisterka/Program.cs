using film_app_magisterka.DAL;
using film_app_magisterka.Models.Users;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<FilmsContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("LocalDb")));
builder.Services.AddDbContext<IdentityAppContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("LocalDb")));
builder.Services.AddSession();
builder.Services.AddIdentity<AppUser, AppRole>(options =>
{
    options.Password.RequireDigit = false;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequiredLength = 4;
}).AddEntityFrameworkStores<IdentityAppContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();
app.UseAuthentication();

app.UseSession();

app.MapControllerRoute(
    name: "AddFilm",
    pattern: "/dodaj",
    defaults: new { controller = "Films", action = "AddFilm" }
    );

app.MapControllerRoute(
    name: "FilmsPosters",
    pattern: "/wszystkie",
    defaults: new { controller = "Films", action = "FilmsPosters" }
    );

app.MapControllerRoute(
    name: "Details",
    pattern: "{action}/{filmId}",
    defaults: new { controller = "Films", action = "Details" }
    );

app.MapControllerRoute(
    name: "Categories",
    pattern: "{categoryName}",
    defaults: new { controller = "Films", action="FilmsList"}
    );


app.MapControllerRoute(
    name: "StaticSites",
    pattern: "Info/{viewName}",
    defaults: new { controller = "Home", action = "footerSites" }
    );


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "Categories",
    pattern: "{categoryName}",
    defaults: new { controller = "Films", action = "FilmsList" }
    );

app.Run();
