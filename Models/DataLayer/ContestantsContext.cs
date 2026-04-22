using Microsoft.EntityFrameworkCore;

namespace FinalProject_ABBOTT.Models
{
    public class ContestantsContext : DbContext
    {
        public ContestantsContext(DbContextOptions<ContestantsContext> options)
        : base(options)
        { }

        public DbSet<School> Schools { get; set; } = null!;
        public DbSet<Division> Divisions { get; set; } = null!;
        public DbSet<Contestant> Contestants { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Config entities
            modelBuilder.ApplyConfiguration(new ConfigureSchools());
            modelBuilder.ApplyConfiguration(new ConfigureDivisions());
            modelBuilder.ApplyConfiguration(new ConfigureContestants());
        }
    }
}
