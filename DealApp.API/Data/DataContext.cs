using DealApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DealApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}
        
        public DbSet<Value> Values { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Quarter> Quarters { get; set; }
        public DbSet<Category> Categories  { get; set; }
        public DbSet<PropertyType> PropertyTypes { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Block> Blocks { get; set; }
        public DbSet<Tower> Towers  { get; set; }
        public DbSet<Floor> Floors { get; set; }
        public DbSet<Area> Areas { get; set; }
        public DbSet<Property> Properties { get; set; }
        public DbSet<Interface> Interfaces { get; set; }
        public DbSet<Renter> Renters { get; set; }
        public DbSet<Photo> Photos { get; set; }

    }
}