using Microsoft.EntityFrameworkCore;
using PizzaBox.Domain.Models;

namespace PizzaBox.Data
{
  public class PizzaBoxDbContext : DbContext
  {
    public DbSet<Crust> Crusts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
      builder.UseSqlServer("server=localhost;initial catalog=PizzaPlanetDb;user id=sa;password=Password12345;");
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Crust>().HasKey(c => c.Id);
      builder.Entity<Crust>().HasIndex(c => c.Name).IsUnique();
    }
  }
}