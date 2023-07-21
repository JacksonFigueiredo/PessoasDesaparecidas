using WebApplication1.Models;

namespace PessoasDesaparecidas.Models
{
    public class Desaparecimento
    {
        public int Id { get; set; }
        public string LocalDesaparecimento { get; set; }
        public DateTime DataHoraDesaparecimento { get; set; }
        public string InformacoesAdicionais { get; set; }
        public bool PessoaEncontrada { get; set; } = false;
        public int PessoaId { get; set; }
        public virtual Pessoa Pessoa { get; set; }
    }
}
