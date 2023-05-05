namespace Fiados
{
    public abstract class Conteudo
    {
        public Conteudo(string nome, string valor, string data, string produto)
        {
            Nome = nome;
            Valor = valor;
            Data = data;
            Produto = produto;
        }

        public string Nome { get; set; }
        public string Valor { get; set; }
        public string Data { get; set; }
        public string Produto { get; set; }

    }
}