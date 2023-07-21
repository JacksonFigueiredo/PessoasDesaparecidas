using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PessoasDesaparecidas.DTOs;
using PessoasDesaparecidas.Interfaces;
using WebApplication1.Enums;
using WebApplication1.Models;

namespace PessoasDesaparecidas.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PessoasController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IPessoaService _pessoaService;

        public PessoasController(IMapper mapper, IPessoaService pessoaService)
        {
            _mapper = mapper;
            _pessoaService = pessoaService;
        }

        [HttpPost]
        public async Task<ActionResult<PessoaDTO>> CriarPessoa(string nome, Sexo sexo, DateTime dataDeNascimento, CorDosOlhos corDosOlhos)
        {
            var pessoa = await _pessoaService.CriarPessoaAsync(nome, sexo, dataDeNascimento, corDosOlhos);
            return CreatedAtAction("CriarPessoa", new { id = pessoa.Nome }, _mapper.Map<PessoaDTO>(pessoa));
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PessoaDTO>>> ObterTodasPessoas()
        {
            var pessoas = await _pessoaService.ObterTodasPessoasAsync();
            return Ok(_mapper.Map<IEnumerable<PessoaDTO>>(pessoas));
        }

        [HttpDelete]
        public async Task<ActionResult<bool>> DeletarPessoa(int id)
        {
            return await _pessoaService.DeletarPessoaAsync(id);
        }
    }
}
