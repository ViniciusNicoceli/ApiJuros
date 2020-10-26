using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models;

namespace api.Utils
{
    public class CalculoDeJuros
    {
        public static decimal RetornaValorComJurosComposto(decimal valorInicial, int Tempo)
        {
            var TaxaJuros = new TaxaJuros().Valor;
            var valor = valorInicial;
            for (int meses = 0; meses < Tempo; meses++)
            {
                valor += valor * TaxaJuros;
            }

            return valor;
        }
        public static string ValidarValorInicialETempo(decimal valorInicial, int Tempo)
        {
            if (valorInicial <= 0)
                return "Valor não pode ser menor ou igual a zero";
            else if (Tempo <= 0)
                return "Tempo não pode ser menor ou igual a zero";

            return string.Empty;
        }
    }
}
