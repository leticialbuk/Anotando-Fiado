namespace Fiados
{
    public class ParcialmentePagos : Conteudo
    {
        public ParcialmentePagos(string nome, int valor, int data, string produto)
            : base(nome, valor, data, produto)
        {

        }
        public string MeioComprovante { get; set; }
    }
}