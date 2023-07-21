namespace PessoasDesaparecidas.DTOs
{
    public class DesaparecimentoDTO
    {
        public int Id { get; set; }
        public string LocalDesaparecimento { get; set; }
        public DateTime DataHoraDesaparecimento { get; set; }
        public string InformacoesAdicionais { get; set; }
        public bool PessoaEncontrada { get; set; }
        public int PessoaId { get; set; }
    }
}
