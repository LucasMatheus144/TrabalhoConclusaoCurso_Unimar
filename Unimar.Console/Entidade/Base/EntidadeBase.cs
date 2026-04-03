using Google.Cloud.Firestore;

namespace Unimar.Dominio.Entidade.Base
{
    public class EntidadeBase
    {
        [FirestoreDocumentId]
        public string? IdDocumento { get; set; }

        public Guid Id
        {
            get => Guid.TryParse(IdDocumento, out var guid) ? guid : Guid.Empty;
            set => IdDocumento = value.ToString("D");
        }

        [FirestoreProperty("datacadastro")]
        public DateTime? DataCadastro { get; set; }
    }
}
