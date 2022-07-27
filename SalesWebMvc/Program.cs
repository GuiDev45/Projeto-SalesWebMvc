using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SalesWebMvc.Data;
using SalesWebMvc.Models;
using SalesWebMvc.Services;

var builder = WebApplication.CreateBuilder(args);

//Build do banco de dados Sql
builder.Services.AddDbContext<SalesWebMvcContext>(options => options.UseSqlServer(
    builder.Configuration.GetConnectionString("SalesWebMvcContext")
    ));

// Add services to the container.
builder.Services.AddControllersWithViews();

// Scope do SellerService.
builder.Services.AddScoped<SellerService>();

var app = builder.Build();

// Bloco para popular o banco de dados.
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    SeedingService.Seed(services);
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
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
