using Google.Cloud.Firestore;

namespace Unimar.Dominio.Entidade.Base
{
    public class EntidadeBase
    {
        public Guid Id { get; set; }      

        [FirestoreProperty("datacadastro")]
        public DateTime? DataCadastro { get; set; }
    }
}
