using Microsoft.EntityFrameworkCore;
using WebAppSAT.Models;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<Receptor> Receptores { get; set; }
    public DbSet<DireccionReceptor> DireccionesReceptores { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Receptor>()
            .HasOne(r => r.DireccionReceptor)
            .WithOne(d => d.Receptor)
            .HasForeignKey<DireccionReceptor>(d => d.ReceptorId);

        base.OnModelCreating(modelBuilder);
    }
}

