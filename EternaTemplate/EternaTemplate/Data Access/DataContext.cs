using EternaTemplate.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace EternaTemplate.Data_Access
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Service> Service {get; set;}
        public DbSet<Feature> Feature { get; set;}
        public DbSet<Slider> Slider { get; set;}
    }
}
