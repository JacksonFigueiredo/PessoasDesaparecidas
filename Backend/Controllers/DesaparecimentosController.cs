﻿using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PessoasDesaparecidas.DTOs;
using PessoasDesaparecidas.Interfaces;
using PessoasDesaparecidas.Models;

namespace PessoasDesaparecidas.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DesaparecimentosController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IDesaparecimentoService _service;

        public DesaparecimentosController(IMapper mapper, IDesaparecimentoService service)
        {
            _mapper = mapper;
            _service = service;
        }

        [HttpPost]
        public async Task<ActionResult<DesaparecimentoDTO>> RegistrarDesaparecimento(DesaparecimentoDTO desaparecimentoDto)
        {
            var desaparecimento = _mapper.Map<Desaparecimento>(desaparecimentoDto);
            var result = await _service.RegistrarDesaparecimentoAsync(desaparecimento);
            return CreatedAtAction(nameof(RegistrarDesaparecimento), new { id = result.Id }, _mapper.Map<DesaparecimentoDTO>(result));
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
