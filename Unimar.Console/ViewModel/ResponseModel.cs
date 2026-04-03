using System.Text.Json.Serialization;

namespace Unimar.Dominio.ViewModel
{
    public class ResponseModel<T> where T : class
    {
        public int StatusCode { get; set; }

        public bool Sucesso => StatusCode >= 200  && StatusCode < 300  && (!MensagensErro.Any());

        public T Data { get; set; }

        public List<MensagemErro>? MensagensErro { get; set; } = new List<MensagemErro>();
    }

    public class MensagemErro
    { 
    
        public string Propriedade { get; set; }
        public string Mensagem { get; set; }

        public MensagemErro(string Propriedade, string Mensagem)
        {
            this.Propriedade = Propriedade;
            this.Mensagem = Mensagem;
        }
    }

}
