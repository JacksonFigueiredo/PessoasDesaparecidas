using Microsoft.EntityFrameworkCore;
using PessoasDesaparecidas.Data;
using PessoasDesaparecidas.Interfaces;
using PessoasDesaparecidas.Models;

namespace PessoasDesaparecidas.Services
{
    public class DesaparecimentoService : IDesaparecimentoService
    {
        private readonly DataContext _context;

        public DesaparecimentoService(DataContext context)
        {
            _context = context;
        }

        public async Task<Desaparecimento> RegistrarDesaparecimentoAsync(Desaparecimento desaparecimento)
        {
            _context.Desaparecimentos.Add(desaparecimento);
            await _context.SaveChangesAsync();
            return desaparecimento;
        }

        public async Task<bool> AlterarStatusPessoaEncontradaAsync(int id, bool status)
        {
            var desaparecimento = await _context.Desaparecimentos.FindAsync(id);
            if (desaparecimento == null)
            {
                return false;
            }

            desaparecimento.PessoaEncontrada = status;
            _context.Entry(desaparecimento).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeletarDesaparecimentoAsync(int id)
        {
            var desaparecimento = await _context.Desaparecimentos.FindAsync(id);
            if (desaparecimento == null)
            {
                return false;
            }

            _context.Desaparecimentos.Remove(desaparecimento);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
