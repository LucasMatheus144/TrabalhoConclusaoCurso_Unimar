using Unimar.Console.Entidade;
using Unimar.Dominio.Repositorio;
using Google.Cloud.Firestore;

namespace Unimar.Infra.FireBase.Repositorio
{
    public class ProfessorRepositorio(FirestoreDb db) : IRepositorioProfessor
    {
        private const string Collection = "professores";

        public async Task<Professor> AdicionarAsync(Professor entity)
        {
            try
            {
                var professor = await db.Collection(Collection).AddAsync(entity);

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
                var professor = await db.Collection(Collection).Document(entity.Id.ToString()).SetAsync(entity);
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

        public async Task<bool> ExcluirAsync(long id)
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

        public async Task<Professor> ObterPorIdAsync(long id)
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
                if (professores != null)
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
