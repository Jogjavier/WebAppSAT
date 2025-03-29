using System.Web;
using System.Data.Entity;

namespace WebAppSAT.Models
{
    public class Receptor
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string RFC { get; set; }
    }

    public class ReceptorDBContext : DbContext 
    {
        public ReceptorDBContext()
        { }
        public DbSet<Receptor> Receptores { get; set; }
    }
}

