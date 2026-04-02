using System.Collections.Generic;
using System.Threading.Tasks;
using Unimar.Console.Entidade;
using Unimar.Dominio.ViewModel;

namespace Unimar.Dominio.Servicos
{
    public interface IProfessorServico
    {
        Task<IEnumerable<Professor>> Listar();
        Task<ResponseModel<Professor>> Adicionar(Professor professor);
        Task<ResponseModel<Professor>> Atualizar(Professor professor);
        Task<bool> Excluir(long id);
        Task<Professor> GerPorId(long id);
    }
}