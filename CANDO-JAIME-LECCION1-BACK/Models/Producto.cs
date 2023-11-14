using System.ComponentModel.DataAnnotations;

namespace CANDO_JAIME_LECCION1_BACK.Models
{
    public class Producto
    {
        [Key]
        [Required]
        public string Codigo { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Tipo { get; set; }
        [Required]
        public Double Precio { get; set; }
        [Required]
        public int Cantidad { get; set; }
    }
}
