using PessoasDesaparecidas.Models;

namespace PessoasDesaparecidas.Interfaces
{
    public interface IDesaparecimentoService
    {
        Task<Desaparecimento> RegistrarDesaparecimentoAsync(Desaparecimento desaparecimento);
        Task<bool> AlterarStatusPessoaEncontradaAsync(int id, bool status);
        Task<bool> DeletarDesaparecimentoAsync(int id);
    }
}
