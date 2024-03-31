using harvesterRPG.Models;
using harvesterRPG.Repository;
using harvesterRPG.Repository.Interfaces;
using harvesterRPG.Services;
using harvesterRPG.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddTransient<IHomeRepository, HomeRepository>();
builder.Services.AddTransient<IHomeService, HomeService>();
builder.Services.AddDbContext<ApplicationDbContext>(options =>
       options.UseSqlServer("Server=GUSTAVO\\SQLEXPRESS;Database=rpgOnePiece;Trusted_Connection=True;TrustServerCertificate=True")); 


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

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
