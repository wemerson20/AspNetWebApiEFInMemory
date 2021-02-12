using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Web_api_EF_in_memory.Models;
using Web_api_EF_in_memory.Models.Interfaces;

namespace Web_api_EF_in_memory.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VendasController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IVendaServiceInterface _vendasService;

        public VendasController(ILogger<WeatherForecastController> logger, IVendaServiceInterface vendasService)
        {
            _logger = logger;
            _vendasService = vendasService;
        }

        [HttpGet("{codigo}")]
        public Venda ObterVenda(int codigo)
        {
            return _vendasService.ObterVenda(codigo);
        }

        [HttpPatch]
        public ActionResult AtualizaStatusVenda()
        {
            try
            {
                _vendasService.AtualizaStatusVenda();                
            }
            catch(Exception ex) 
            {
                _logger.LogDebug("Erro ao atualizar status", ex.Message);
            }
            return Ok("Venda atualizada");
        }
    }
}
