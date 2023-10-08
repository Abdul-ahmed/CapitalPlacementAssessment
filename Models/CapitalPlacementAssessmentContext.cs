
using Microsoft.EntityFrameworkCore;

namespace CapitalPlacementAssessment.Models // Note: actual namespace depends on the project name.
{
    public class CapitalPlacementAssessmentContext : DbContext
    {
        public DbSet<ProgramDetail>? ProgramDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseCosmos(
                "https://localhost:8081",
                "C2y6yDjf5/R+ob0N8A7Cgv30VRDJIWEHLM+4QDU5DE2nQ9nDuVTqobD4b8mGGyPMbIZnqyMsEcaGQy67XIw/Jw==",
                "CapitalPlacementAssessmentDB"
            );
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ProgramDetail>().ToContainer("ProgramDetails").HasPartitionKey(c => c.Id);

            // modelBuilder.Entity<ProgramDetail>().OwnsMany(p => p.ApplicationForm); remember to change orders table
        }
    }
}