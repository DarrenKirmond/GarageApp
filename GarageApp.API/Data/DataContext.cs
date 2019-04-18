using Microsoft.EntityFrameworkCore;
using garageApp.API.Models;
using GarageApp.API.Models;

namespace garageApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}
        
        public DbSet<Value> Values { get; set; }
        public DbSet<User> Users { get; set; }
    }
}