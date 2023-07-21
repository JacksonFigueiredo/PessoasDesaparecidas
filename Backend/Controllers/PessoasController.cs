using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PessoasDesaparecidas.Interfaces;
using WebApplication1.Enums;
using WebApplication1.Models;

namespace PessoasDesaparecidas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoasController : ControllerBase
    {
        private readonly IPessoaService _pessoaService;

        public PessoasController(IPessoaService pessoaService)
        {
            _pessoaService = pessoaService;
        }

        // POST: api/Pessoas
        [HttpPost]
        public async Task<ActionResult<Pessoa>> CriarPessoa(string nome, Sexo sexo, DateTime dataDeNascimento, CorDosOlhos corDosOlhos)
        {
            var pessoa = await _pessoaService.CriarPessoaAsync(nome, sexo, dataDeNascimento, corDosOlhos);
            return CreatedAtAction("CriarPessoa", new { id = pessoa.Nome }, pessoa);
        }

        // GET: api/Pessoas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pessoa>>> ObterTodasPessoas()
        {
            return await _pessoaService.ObterTodasPessoasAsync();
        }
    }
}
