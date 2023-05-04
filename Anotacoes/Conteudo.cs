namespace Fiados
{
    public abstract class Conteudo
    {
        public Conteudo(string nome, int valor, int data, string produto)
        {
            Nome = nome;
            Valor = valor;
            Data = data;
            Produto = produto;
        }

        public string Nome { get; set; }

        public int Valor { get; set; }

        public int Data { get; set; }

        public string Produto { get; set; }

        public override string ToString()
        {
            return $"Nome: {Nome}, Valor: {Valor}, Data: {Data}, Produto: {Produto}";
        }
    }
}