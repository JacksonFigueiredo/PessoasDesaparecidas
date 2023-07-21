using Microsoft.EntityFrameworkCore;
using PessoasDesaparecidas.Data;
using PessoasDesaparecidas.Interfaces;
using WebApplication1.Enums;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class PessoaService : IPessoaService
    {
        private readonly DataContext _context;

        public PessoaService(DataContext context)
        {
            _context = context;
        }

        public async Task<Pessoa> CriarPessoaAsync(string nome, Sexo sexo, DateTime dataDeNascimento, CorDosOlhos corDosOlhos)
        {
            var pessoa = new Pessoa(nome, sexo, dataDeNascimento, corDosOlhos);
            _context.Pessoas.Add(pessoa);
            await _context.SaveChangesAsync();
            return pessoa;
        }

        public async Task<bool> DeletarPessoaAsync(int id)
        {
            var pessoa = await _context.Pessoas.FindAsync(id);
            if (pessoa == null)
            {
                return false;
            }

            _context.Pessoas.Remove(pessoa);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<List<Pessoa>> ObterTodasPessoasAsync()
        {
            return await _context.Pessoas.ToListAsync();
        }
    }
}
