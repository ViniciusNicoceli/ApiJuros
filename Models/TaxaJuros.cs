using System.ComponentModel.DataAnnotations;


namespace testeef.Models
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