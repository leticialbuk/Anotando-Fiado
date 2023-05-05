namespace Fiados
{
    public class ParcialmentePagos : Conteudo
    {
        public ParcialmentePagos(string nome, string valor, string data, string produto)
            : base(nome, valor, data, produto)
        {

        }
        public string MeioComprovante { get; set; }
    }
}