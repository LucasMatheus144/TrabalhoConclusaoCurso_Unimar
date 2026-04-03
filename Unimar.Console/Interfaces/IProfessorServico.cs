using System.Collections.Generic;
using System.Threading.Tasks;
using Unimar.Console.Entidade;
using Unimar.Dominio.ViewModel;

namespace Unimar.Dominio.Interfaces
{
    public interface IProfessorServico
    {
        Task<IEnumerable<Professor>> Listar();
        Task<ResponseModel<Professor>> Adicionar(Professor professor);
        Task<ResponseModel<Professor>> Atualizar(Professor professor);
        Task<bool> Excluir(Guid id);
        Task<Professor> GerPorId(Guid id);
    }
}