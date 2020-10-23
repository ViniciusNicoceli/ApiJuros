using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using testeef.Models;


namespace testeef.Controllers
{
    [Route("ApiCalculos")]
    public class CalculaJurosController : Controller
    {
        [HttpGet("calculaJuros")]
        public decimal CalcularJuros(decimal valorInicial, int tempo)
        {
            var valorFinal = RetornaValorComJurosComposto(valorInicial, tempo);

            return decimal.Round(valorFinal, 2, MidpointRounding.AwayFromZero);
        }

        public decimal RetornaValorComJurosComposto(decimal valorInicial, int Tempo )
        {
            var TaxaJuros = new TaxaJuros().Valor;
            var valor = valorInicial;
            for(int meses=0;meses<Tempo;meses++){
                valor += valor * TaxaJuros;
            }

            return valor;
        }

        [HttpGet("showmethecode")]
        public string ShowMeTheCode()
        {
            return "teste";
        }
    }
}