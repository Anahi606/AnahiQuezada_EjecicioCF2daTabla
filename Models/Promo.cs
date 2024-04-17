using System.ComponentModel.DataAnnotations;

namespace AnahiQuezada_EjecicioCF.Models
{
    public class Promo
    {
        public int PromoId { get; set; }
        [Required]
        public string? Descripcion { get; set; }
     
        public DateTime FechaPromo { get; set; }

        public int Id { get; set; }
        public Burger? Burger { get; set; }
    }
}
