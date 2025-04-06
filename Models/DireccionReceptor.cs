using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppSAT.Models
{
    public class DireccionReceptor
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Calle { get; set; }

        public int? NumExt { get; set; }  
        public int? NumInt { get; set; }  

        [Required]
        public string Colonia { get; set; }

        [Required]
        public string Municipio { get; set; }

        [Required]
        public string Estado { get; set; }

        public int? CodigoPostal { get; set; } 

        [ForeignKey("Receptor")]
        public int ReceptorId { get; set; }
        public Receptor Receptor { get; set; }
    }
}
