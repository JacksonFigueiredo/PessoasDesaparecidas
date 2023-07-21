using WebApplication1.Enums;
using WebApplication1.Models;

namespace PessoasDesaparecidas.Interfaces
{
    public interface IPessoaService
    {
        Task<Pessoa> CriarPessoaAsync(string nome, Sexo sexo, DateTime dataDeNascimento, CorDosOlhos corDosOlhos);
        Task<List<Pessoa>> ObterTodasPessoasAsync();
    }
}
