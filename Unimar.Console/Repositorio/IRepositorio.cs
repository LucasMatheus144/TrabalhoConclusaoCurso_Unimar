using Unimar.Dominio.Repositorio.Base;

namespace Unimar.Dominio.Repositorio
{
    public interface IRepositorio<T> : IRepositorioBase<T>
    {
        Task<T> ObterPorIdAsync(long id);
    }
}
