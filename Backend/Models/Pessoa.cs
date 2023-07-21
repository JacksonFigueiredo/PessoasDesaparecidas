using WebApplication1.Enums;

namespace WebApplication1.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public Sexo SexoPessoa { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public CorDosOlhos CorDosOlhosPessoa { get; set; }

        public Pessoa(string nome, Sexo sexo, DateTime dataDeNascimento, CorDosOlhos corDosOlhos)
        {
            Nome = nome;
            SexoPessoa = sexo;
            DataDeNascimento = dataDeNascimento;
            CorDosOlhosPessoa = corDosOlhos;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}, Sexo: {SexoPessoa}, Data de Nascimento: {DataDeNascimento.ToShortDateString()}, Cor dos Olhos: {CorDosOlhosPessoa}";
        }
    }
}
