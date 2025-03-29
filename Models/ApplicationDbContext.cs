using Microsoft.EntityFrameworkCore;
using WebAppSAT.Models;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<Receptor> Receptores { get; set; }
}

