using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PessoasDesaparecidas.Interfaces;
using PessoasDesaparecidas.Models;

namespace PessoasDesaparecidas.Controllers
{
    [ApiController]
    [Route("api/desaparecimentos")]
    public class DesaparecimentosController : ControllerBase
    {
        private readonly IDesaparecimentoService _service;

        public DesaparecimentosController(IDesaparecimentoService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<ActionResult<Desaparecimento>> RegistrarDesaparecimento(Desaparecimento desaparecimento)
        {
            var result = await _service.RegistrarDesaparecimentoAsync(desaparecimento);
            return CreatedAtAction(nameof(RegistrarDesaparecimento), new { id = result.Id }, result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> AlterarStatusPessoaEncontrada(int id, [FromBody] bool status)
        {
            var result = await _service.AlterarStatusPessoaEncontradaAsync(id, status);
            if (!result)
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletarDesaparecimento(int id)
        {
            var result = await _service.DeletarDesaparecimentoAsync(id);
            if (!result)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}
