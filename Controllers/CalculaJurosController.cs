using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using api.Models;
using api.Utils;
using Microsoft.OpenApi.Exceptions;

namespace api.Controllers
{
    [Route("ApiCalculos")]
    public class CalculaJurosController : Controller
    {
        [HttpPost("calculaJuros")]
        public string CalcularJuros(decimal valorInicial, int tempo)
        {
            try
            {
                var MensagemDeValidacao = CalculoDeJuros.ValidarValorInicialETempo(valorInicial, tempo);
                if (MensagemDeValidacao != string.Empty)
                    throw new Exception(MensagemDeValidacao);

                var valorFinal = CalculoDeJuros.RetornaValorComJurosComposto(valorInicial, tempo);

                return decimal.Round(valorFinal, 2, MidpointRounding.AwayFromZero).ToString();
            }
            catch (Exception e)
            {

                throw new OpenApiException($"Erro Ao Calcular Juros: {e.Message}");
            }
        }

        

        [HttpGet("showmethecode")]
        public string ShowMeTheCode()
        {
            return "https://github.com/ViniciusNicoceli/ApiJuros";
        }
    }
}
