using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace WebAppSAT.Models
{
    public class Receptor
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string RFC { get; set; }

        [Required]
        public string UsoCFDI { get; set; }

        public int? DireccionReceptorId { get; set; } 
        public DireccionReceptor DireccionReceptor { get; set; }
    }
}

