using Microsoft.EntityFrameworkCore;
using PizzaBox.Domain.Models;

namespace PizzaBox.Data
{
  public class PizzaBoxDbContext : DbContext
  {
    public DbSet<Crust> Crusts { get; set; }
    public DbSet<Size> Sizes { get; set; }
    public DbSet<Topping> Toppings { get; set; }
    public DbSet<PizzaSubmitForm> Pizzas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
      builder.UseSqlServer("server=localhost;initial catalog=PizzaPlanetDb;user id=sa;password=Password12345;");
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Crust>().HasKey(c => c.Id);
      builder.Entity<Crust>().HasIndex(c => c.Name).IsUnique();

      builder.Entity<Size>().HasKey(s => s.Id);
      builder.Entity<Size>().HasIndex(s => s.Name).IsUnique();

      builder.Entity<Topping>().HasKey(t => t.Id);
      builder.Entity<Topping>().HasIndex(t => t.Name).IsUnique();

      builder.Entity<PizzaSubmitForm>().HasKey(p => p.Id);
 
    }

  }
}