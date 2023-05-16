namespace Fiados
{
    public class ParcialPagos : Conteudo
    {
        public ParcialPagos(string nome, string valor, string data, string produto)
            : base(nome, valor, data, produto)
        {

        }

        public override string ToString()
        {
            Console.WriteLine("COMPROVANTE PARCIALMENTE PAGO");
            Console.WriteLine(".............................");
            return $"Nome: {Nome},\nValor: R$ {Valor}, \nData: {Data}, \nProdutos: {Produto}";
        }
    }
}