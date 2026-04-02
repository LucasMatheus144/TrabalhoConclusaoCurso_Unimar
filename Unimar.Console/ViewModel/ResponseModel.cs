namespace Unimar.Dominio.ViewModel
{
    public class ResponseModel<T> where T : class
    {
        public int StatusCode { get; set; }

        private bool _sucesso { get; set; }

        public bool Sucesso
        {
            get { return _sucesso; }
            set
            {
                var validaSeTemMsgErro = MensagensErro.Any();
                if(!validaSeTemMsgErro && StatusCode >= 200 && StatusCode < 300){
                    _sucesso = true;
                }
                else {
                    _sucesso = false;
                }
            }
        }

        public T Data { get; set; }

        public List<MensagemErro> MensagensErro { get; set; }
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
