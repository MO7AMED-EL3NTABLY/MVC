using Microsoft.EntityFrameworkCore;
using MVC.Models;

namespace MVC.Dbcontext
{
    public class GYMDbcontext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer($"Server=(localdb)\\MSSQLLocalDB;Database=GYMDb;Trusted_Connection=True;trustservercertificate=true;");
            
        }
        public DbSet<Plan> Plans { get; set; }
        public object Plan { get; internal set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Plan>(new configration.planconfigration());
        }
    }
}
