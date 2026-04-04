using Unimar.Console.Entidade;
using Unimar.Dominio.Interfaces;
using Unimar.Dominio.Repositorio;
using Unimar.Dominio.ViewModel;

namespace Unimar.Dominio.Servicos
{
    public class ProfessorServico : IProfessorServico
    {
        private IRepositorioProfessor _repositorio;

        public ProfessorServico(IRepositorioProfessor repositorio)
        {
            _repositorio = repositorio;
        }

        public Task<IEnumerable<Professor>> Listar()
        {
            return _repositorio.ObterTodosAsync();
        }

        public async Task<IEnumerable<Professor>> Buscar(string? disciplina = null, bool? ativo = null, bool ordenarPorNome = false, int? limite = null)
        {
            var professores = await Listar();

            if (professores == null)
            {
                return Enumerable.Empty<Professor>();
            }

            var query = professores.AsEnumerable();

            if (!string.IsNullOrWhiteSpace(disciplina))
            {
                query = query.Where(p => !string.IsNullOrWhiteSpace(p.Disciplina)
                    && p.Disciplina.Contains(disciplina, StringComparison.OrdinalIgnoreCase));
            }

            if (ativo.HasValue)
            {
                query = query.Where(p => p.Ativo == ativo.Value);
            }

            if (ordenarPorNome)
            {
                query = query.OrderBy(p => p.Nome);
            }

            if (limite.HasValue && limite.Value > 0)
            {
                query = query.Take(limite.Value);
            }

            return query.ToList();
        }

        public async Task<ResponseModel<Professor>> Adicionar(Professor professor)
        {
            try
            {
                var tentaIncluir = await _repositorio.AdicionarAsync(professor);

                if (tentaIncluir != null)
                {
                    return new ResponseModel<Professor>
                    {
                        StatusCode = 200,
                        Data = tentaIncluir
                    };
                }

                return new ResponseModel<Professor>
                {
                    StatusCode = 400,
                    Data = professor,
                    MensagensErro = new List<MensagemErro>()
                    {
                        new MensagemErro("Professor","Erro ao incluir")
                    }
                };

            }
            catch (Exception ex)
            {
                return new ResponseModel<Professor>
                {
                    StatusCode = 500,
                    Data = professor,
                    MensagensErro = new List<MensagemErro>()
                    {
                       new MensagemErro("Professor", $"Ocorreu um erro ao incluir o professor: {ex.Message}")

                    }
                };
            }    
        }

        public async Task<ResponseModel<Professor>> Atualizar(Professor professor)
        {
            try
            {
                var tentaEditar = await _repositorio.AtualizarAsync(professor);

                if (tentaEditar != null)
                {
                    return new ResponseModel<Professor>
                    {
                        StatusCode = 200,
                        Data = tentaEditar
                    };
                }

                return new ResponseModel<Professor>
                {
                    StatusCode = 400,
                    Data = tentaEditar,
                    MensagensErro = new List<MensagemErro>()
                    {
                        new MensagemErro("Professor","Erro ao editar")
                    }
                };
            }
            catch (Exception ex)
            {
                return new ResponseModel<Professor>
                {
                    StatusCode = 500,
                    Data = null,
                    MensagensErro = new List<MensagemErro>()
                    {
                       new MensagemErro("Professor", $"Ocorreu um erro ao editar o professor: {ex.Message}")

                    }
                };
            }
        }

        public async Task<bool> Excluir(Guid id)
        {
            return await _repositorio.ExcluirAsync(id);
        }

        public Task<Professor> GerPorId(Guid id)
        {
            return _repositorio.ObterPorIdAsync(id);
        }
    }
}
