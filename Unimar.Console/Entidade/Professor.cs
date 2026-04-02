using Unimar.Dominio.Entidade.Base;

namespace Unimar.Console.Entidade
{
    public class Professor : EntidadeBase
    {
        public string Nome { get; set; }

        public string Disciplina { get; set; }

        public string Email { get; set; }

        public bool Ativo { get; set; }
    }
}
