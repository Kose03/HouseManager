using HouseManager.Models;
using Microsoft.EntityFrameworkCore;

namespace HouseManager.Data
{
    public class HouseManagerDbContext : DbContext
    {
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Cashier> Cashiers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost\\SQLEXPRESS;Initial Catalog=HouseholdManager;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            optionsBuilder.UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cashier>()
                            .HasOne(o => o.ClientId)
                            .WithMany(p => p.Users)
                            .HasForeignKey(o => o.UserId);
            modelBuilder.Entity<User>()
                .HasMany(p => p.Users)
                .WithOne(o => o.ClientId)
                .HasForeignKey(o => o.UserId);
        }
    }
}
