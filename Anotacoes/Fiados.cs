namespace Fiados
{
    public class Fiado : Conteudo
    {
        public Fiado(string nome, string valor, string data, string produto)
            : base(nome, valor, data, produto)
        {

        }
        public string AnotacaoFiados { get; set; }

        public override string ToString()
        {
            return $"Nome: {Nome},\nValor: R$ {Valor}, \nData: {Data}, \nProduto: {Produto}";
        }
    }
}
