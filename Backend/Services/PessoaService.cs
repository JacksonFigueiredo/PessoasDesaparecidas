using WebApplication1.Enums;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class PessoaService
    {
        public Pessoa CriarPessoa(string nome, Sexo sexo, DateTime dataDeNascimento, CorDosOlhos corDosOlhos)
        {
            return new Pessoa(nome, sexo, dataDeNascimento, corDosOlhos);
        }
    }
}
