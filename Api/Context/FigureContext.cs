using Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Api.Context;

public class StorageContext : DbContext
{
    public DbSet<Figure> Figures { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

        optionsBuilder.UseSqlite("Data Source=./data/database.db");
    }
}