namespace Yajat.Digitalizer.DynamicCalculator.DataAccess.EfCore
{
    using Microsoft.EntityFrameworkCore;
    using Yajat.Digitalizer.DynamicCalculator.Domain.Entities;

    public class ApplicationContext : DbContext, IApplicationContext
    {
        public ApplicationContext(DbContextOptions options) : base(options) { }

        public DbSet<Variable> Variables { get; set; }       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Variable>().ToTable(nameof(Variable)).HasKey(p => p.Id);
            modelBuilder.Entity<Variable>().Property(g => g.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<Variable>().Property(g => g.Name).IsRequired();
        }
    }
}
