using Microsoft.EntityFrameworkCore;
using garageApp.API.Models;

namespace garageApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}
        
        public DbSet<Value> Values { get; set; }
    }
}