using Data.Entities;
using LifeHacksThatMakesItWorseAPI.Data.Entities;
using Microsoft.EntityFrameworkCore;


namespace LifeHacksThatMakesItWorseAPI.Data.Context
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<LifeHackEntity> LifeHacks { get; set; }

        public DbSet<Categories> Category { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Categories>()
                        .HasMany<LifeHackEntity>()
                        .WithOne(lh => lh.Category);
        }
        
    }
}
