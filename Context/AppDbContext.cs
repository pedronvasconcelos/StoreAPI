using Microsoft.EntityFrameworkCore;
using StoreAPI.Models;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace StoreAPI.Context;
public class AppDbContext : DbContext
{
    protected readonly IConfiguration Configuration;

    public AppDbContext(DbContextOptions<AppDbContext> options, IConfiguration configuration) : base(options)
    {
        Configuration = configuration;
    }
    public AppDbContext()
    { }
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }



    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        if (!options.IsConfigured)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json")
               .Build();
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }
    }
}
