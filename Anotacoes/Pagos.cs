namespace Fiados
{
    public class Pagos : Conteudo
    {
        public Pagos(string nome, string valor, string data, string produto)
            : base(nome, valor, data, produto)
        {

        }
        public string Comprovante { get; set; }
    }
}