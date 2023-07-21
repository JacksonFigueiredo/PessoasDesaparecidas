using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PessoasDesaparecidas.Interfaces;
using PessoasDesaparecidas.Models;

namespace PessoasDesaparecidas.Controllers
{
  
    [ApiController]
    [Route("api/[controller]")]
    public class RelatoriosController : ControllerBase
    {
        private readonly IRelatorioService _service;

        public RelatoriosController(IRelatorioService service)
        {
            _service = service;
        }

        [HttpGet("nao-encontrados")]
        public async Task<ActionResult<IEnumerable<Desaparecimento>>> ObterDesaparecidosNaoEncontrados()
        {
            var result = await _service.ObterDesaparecidosNaoEncontradosAsync();
            return Ok(result);
        }

        [HttpGet("encontrados")]
        public async Task<ActionResult<IEnumerable<Desaparecimento>>> ObterDesaparecidosEncontrados()
        {
            var result = await _service.ObterDesaparecidosEncontradosAsync();
            return Ok(result);
        }
    }
}
