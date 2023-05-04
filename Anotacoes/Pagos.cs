namespace Fiados
{
    public class Pagos : Conteudo
    {
        public Pagos(string nome, int valor, int data, string produto)
            : base(nome, valor, data, produto)
        {

        }
        public string Comprovante { get; set; }
    }
}