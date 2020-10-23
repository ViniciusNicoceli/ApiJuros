using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using testeef.Models;


namespace testeef.Controllers
{
    [Route("ApiJuros")]
    public class TaxaJurosController : Controller
    {
        [HttpGet("taxaJuros")]
        public decimal get()
        {
            return new TaxaJuros().Valor;
        }
    }
}