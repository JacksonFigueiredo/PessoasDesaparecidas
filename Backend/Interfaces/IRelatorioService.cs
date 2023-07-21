using PessoasDesaparecidas.Models;

namespace PessoasDesaparecidas.Interfaces
{
    public interface IRelatorioService
    {
        Task<IEnumerable<Desaparecimento>> ObterDesaparecidosNaoEncontradosAsync();
        Task<IEnumerable<Desaparecimento>> ObterDesaparecidosEncontradosAsync();
    }
}
