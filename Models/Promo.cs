using System.ComponentModel.DataAnnotations;

namespace AnahiQuezada_EjecicioCF.Models
{
    public class Promo
    {
        public int PromoId { get; set; }
        public string? PromoDescripcion { get; set; }
        public DateTime FechaPromocion { get; set; }

        public int BurgerId { get; set; }
        public Burger? Burger { get; set; }
    }
}
