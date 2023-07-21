using Microsoft.EntityFrameworkCore;
using PessoasDesaparecidas.Data;
using PessoasDesaparecidas.Interfaces;
using PessoasDesaparecidas.Models;

namespace PessoasDesaparecidas.Services
{
    public class RelatorioService : IRelatorioService
    {
        private readonly DataContext _context;

        public RelatorioService(DataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Desaparecimento>> ObterDesaparecidosNaoEncontradosAsync()
        {
            return await _context.Desaparecimentos
                      .Include(d => d.Pessoa)
                      .Where(d => !d.PessoaEncontrada)
                      .ToListAsync();
        }

        public async Task<IEnumerable<Desaparecimento>> ObterDesaparecidosEncontradosAsync()
        {
            return await _context.Desaparecimentos
                     .Include(d => d.Pessoa)
                     .Where(d => d.PessoaEncontrada)
                     .ToListAsync();
        }
    }
}
