using WebApplication1.Enums;

namespace PessoasDesaparecidas.DTOs
{
    public class PessoaDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Sexo SexoPessoa { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public CorDosOlhos CorDosOlhosPessoa { get; set; }
    }
}
