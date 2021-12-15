using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

namespace model.modelEF
{
    public partial class dbmutantContext : DbContext
    {
        private IConfiguration Configuration;
        public dbmutantContext()
        {
        }

        public dbmutantContext(DbContextOptions<dbmutantContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Mutant> Mutant { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var builder = new ConfigurationBuilder().AddJsonFile("appsettings.json");
                Configuration = builder.Build();
                optionsBuilder.UseSqlServer(Configuration["ConnectionStrings:DefaultConnection"]);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Mutant>(entity =>
            {
                entity.ToTable("mutant");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Dna)
                    .HasColumnName("dna")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mutant1).HasColumnName("mutant");
            });
        }
    }
}
