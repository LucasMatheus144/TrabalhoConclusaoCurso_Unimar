namespace Unimar.Dominio.Repositorio.Base
{
    public interface IRepositorioBase<TEntity>
    {
        Task<IEnumerable<TEntity>> ObterTodosAsync();
        Task<TEntity> AdicionarAsync(TEntity entity);
        Task<TEntity> AtualizarAsync(TEntity entity);
        Task<bool> ExcluirAsync(Guid id);
    }
}