using Br.Com.FiapInvestiments.Domain.Entities;
using Br.Com.FiapInvestiments.Domain.Enums;
using Microsoft.EntityFrameworkCore;

namespace Br.Com.FiapInvestiments.Infrastructure.Data
{
    public class ApiContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("InMemoryDb");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                    new User { Id = Guid.NewGuid(), Name = "Thiago Heraclides", Email = "thiagoheraclides@gmail.com", Username = "thiago.heraclides", Password = "30041983", Role = Role.Administrator },
                    new User { Id = Guid.NewGuid(), Name = "Gesner Zarabatana", Email = "gesnerzarabatana@gmail.com", Username = "gesner.zarabatana", Password = "02022002", Role = Role.Operator }
                );
        }

        public DbSet<User> Users { get; set; }

    }
}
