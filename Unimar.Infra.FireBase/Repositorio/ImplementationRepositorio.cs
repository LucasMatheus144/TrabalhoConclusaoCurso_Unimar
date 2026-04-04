using Google.Cloud.Firestore;
using System.Security.Cryptography;
using Unimar.Console.Entidade;
using Unimar.Dominio.Repositorio;

namespace Unimar.Infra.FireBase.Repositorio
{
    public class ProfessorRepositorio(FirestoreDb db) : IRepositorioProfessor
    {
        private const string Collection = "professores";

        public async Task<Professor> AdicionarAsync(Professor entity)
        {
            try
            {
                var professor = await db.Collection(Collection).Document(entity.Id.ToString("D")).SetAsync(new
                {
                    id = entity.Id.ToString("D"),
                    ativo = entity.Ativo,
                    nome = entity.Nome,
                    disciplina = entity.Disciplina,
                    email = entity.Email,
                    datacadastro = entity.DataCadastro ?? DateTime.UtcNow
                });

                if (professor != null)
                {
                    return entity;
                }

                return null;
            }
            catch (Exception)
            {
                return null;
            }         
        }
        public async Task<Professor> AtualizarAsync(Professor entity)
        {
            try
            {
                //caso o documento não encontre o ID , ele da um UPSERT
                var professor = await db.Collection(Collection).Document(entity.Id.ToString()).SetAsync(new
                {
                    ativo = entity.Ativo,
                    nome = entity.Nome,
                    disciplina = entity.Disciplina,
                    email = entity.Email
                }, SetOptions.MergeAll);


                if (professor != null)
                {
                    return entity;
                }

                return null;

            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<bool> ExcluirAsync(Guid id)
        {
            try
            {
                var deletar = await db.Collection(Collection).Document(id.ToString()).DeleteAsync();

                if (deletar != null)
                {
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;

            }
        }

        public async Task<Professor> ObterPorIdAsync(Guid id)
        {
            try
            {
                var professor = await db.Collection(Collection).Document(id.ToString()).GetSnapshotAsync();
                if (professor.Exists)
                {
                    return professor.ConvertTo<Professor>();
                }
                return null;

            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<IEnumerable<Professor>> ObterTodosAsync()
        {
            try
            {
                var professores = await db.Collection(Collection).GetSnapshotAsync();
                if (professores != null && professores.Count() > 0)
                {
                    return professores.Documents.Select(doc => doc.ConvertTo<Professor>()).ToList();
                }
                return null;

            }
            catch (Exception)
            {
                return null;
            }
        }       
    }
}
