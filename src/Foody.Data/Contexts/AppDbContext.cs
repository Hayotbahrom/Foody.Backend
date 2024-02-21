using Foody.Domain.Entities.Restaurants;
using Foody.Domain.Entities.Addresses;
using Foody.Domain.Entities.Payments;
using Foody.Domain.Entities.Products;
using Microsoft.EntityFrameworkCore;
using Foody.Domain.Entities.Orders;
using Foody.Domain.Entities.Saved;
using Foody.Domain.Entities.Carts;
using Foody.Domain.Entities.Users;

namespace Foody.Data.DbContexts;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {

    }
    public DbSet<User> Users { get; set; }
    public DbSet<Address> Addresses { get; set; }
    public DbSet<Country> Countries { get; set; }
    public DbSet<District> Districts { get; set; }
    public DbSet<Region> Regions { get; set; }
    public DbSet<Cart> Carts { get; set; }
    public DbSet<CartProduct> CartProducts { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderItem> OrderItems { get; set; }
    public DbSet<Payment> Payments { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Restaurant> Restaurants { get; set; }
    public DbSet<RestaurantProduct> RestaurantProducts { get; set; }
    public DbSet<Saved> Saveds { get; set; }
    public DbSet<SavedProduct> SavedProducts { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        
    }
}
