using System.ComponentModel.DataAnnotations;

namespace AnahiQuezada_EjecicioCF.Models
{
    public class Burger
    {
        public int BurgerId { get; set; }
        [Required]
        public string? Name { get; set; }
        public bool WithCheese { get; set; }
        [VerificarRango]
        public decimal Precio { get; set; }

        public List<Promo>? Promo { get; set; }
    }

    public class VerificarRango : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            decimal valor = (decimal)value;
            if (valor < 20)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
