using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AulaaspViewControl.Data;
var builder = WebApplication.CreateBuilder(args);
/*builder.Services.AddDbContext<AulaaspViewControlContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("AulaaspViewControlContext") ?? throw new InvalidOperationException("Connection string 'AulaaspViewControlContext' not found.")));
*/

builder.Services.AddEntityFrameworkNpgsql().AddDbContext<AulaaspViewControlContext>(options =>
options.UseNpgsql("Host = pgsql.projetoscti.com.br;" +
                  "Port = 5432;" +
                  "Pooling = true;" +
                  "Database = projetoscti14; " +
                  "User id = projetoscti14; " +
                  "Password = eq273c782; ")) ;
// Add services to the container.
builder.Services.AddControllersWithViews();

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
    pattern: "{controller=Home}/{action=Index}/{nome=Maria}/{idade=12}");

app.Run();
