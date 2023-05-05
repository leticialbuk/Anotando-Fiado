namespace Fiados
{
    public class ParcialmentePagos : Conteudo
    {
        public ParcialmentePagos(string nome, string valor, string data, string produto)
            : base(nome, valor, data, produto)
        {
            MeioComprovante = "Comprovante gerado 1233";

        }
        public string MeioComprovante { get; set; }
    }
}