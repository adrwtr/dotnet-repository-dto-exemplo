using Microsoft.EntityFrameworkCore;

using teste_mysql_do_zero.Services;
using teste_mysql_do_zero.Services.Interfaces;

using teste_mysql_do_zero.Repositories;
using teste_mysql_do_zero.Repositories.Interfaces;

using teste_mysql_do_zero.Contexts;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var connectionString = builder.Configuration.GetConnectionString("MysqlDataSourceName");
var serverVersion = new MySqlServerVersion(new Version(5, 7, 37));

// adiciona o contexto em DI
// buscando as configuracoes do banco lá do appsettings
builder.Services.AddDbContext<BancoAnimeContext>(
    options => {
        options.UseMySql(
            connectionString,
            serverVersion
        );
    }
);

builder.Services.AddScoped<IAnimeService, AnimeService>();

// adiciona no DI
// pode ser usado uma FACTORY para não sujar o código
if (!builder.Environment.IsDevelopment())
{
    builder.Services.AddScoped<IAnimeRepository, AnimeMemoryRepository>();
}
else
{
    builder.Services.AddScoped<IAnimeRepository, AnimeRepository>();
}



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
