using PessoasDesaparecidas.Models;
using WebApplication1.Enums;

namespace WebApplication1.Models
{
    public class Pessoa
    {
        public Pessoa()
        {
                
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public Sexo SexoPessoa { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public CorDosOlhos CorDosOlhosPessoa { get; set; }

        public Desaparecimento Desaparecimento { get; set; }

        public Pessoa(string nome, Sexo sexo, DateTime dataDeNascimento, CorDosOlhos corDosOlhos)
        {
            Nome = nome;
            SexoPessoa = sexo;
            DataDeNascimento = dataDeNascimento;
            CorDosOlhosPessoa = corDosOlhos;
        }
    }
}
