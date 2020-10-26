using System.ComponentModel.DataAnnotations;


namespace api.Models
{
    public class TaxaJuros
    {
        public decimal Valor{get; set;}

        public TaxaJuros()
        {
            Valor = new decimal(0.01);
        }

    }
}