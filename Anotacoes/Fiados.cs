namespace Fiados
{
    public class Fiado : Conteudo
    {
        public Fiado(string nome, int valor, int data, string produto)
            : base(nome, valor, data, produto)
        {

        }
        public string AnotacaoFiados { get; set; }
    }
}
