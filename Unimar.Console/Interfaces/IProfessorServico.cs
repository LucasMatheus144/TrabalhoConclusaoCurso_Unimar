using System.Collections.Generic;
using System.Threading.Tasks;
using Unimar.Console.Entidade;
using Unimar.Dominio.ViewModel;

namespace Unimar.Dominio.Interfaces
{
    public interface IProfessorServico
    {
        Task<IEnumerable<Professor>> Listar();
        Task<IEnumerable<Professor>> Buscar(string? disciplina = null, bool? ativo = null, bool ordenarPorNome = false, int? limite = null);
        Task<ResponseModel<Professor>> Adicionar(Professor professor);
        Task<ResponseModel<Professor>> Atualizar(Professor professor);
        Task<bool> Excluir(Guid id);
        Task<Professor> GerPorId(Guid id);
    }
}