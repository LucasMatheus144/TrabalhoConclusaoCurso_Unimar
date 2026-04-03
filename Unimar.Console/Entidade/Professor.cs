using Google.Cloud.Firestore;
using Unimar.Dominio.Entidade.Base;

namespace Unimar.Console.Entidade
{
    [FirestoreData]
    public class Professor : EntidadeBase
    {
        [FirestoreProperty("nome")]
        public string Nome { get; set; }

        [FirestoreProperty("disciplina")]
        public string Disciplina { get; set; }

        [FirestoreProperty("email")]
        public string Email { get; set; }

        [FirestoreProperty("ativo")]
        public bool Ativo { get; set; }
    }
}
