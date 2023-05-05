using Fiados;

namespace FiadoOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ANOTANDO FIADO");
            Console.WriteLine("..............");

            Console.WriteLine("Nome do cliente: ");
            var nome = Console.ReadLine();
            Console.WriteLine("Valor da compra R$: ");
            var valor = Console.ReadLine();
            Console.WriteLine("Digite a data da compra: ");
            var data = Console.ReadLine();
            Console.WriteLine("Digite os produtos: ");
            var produto = Console.ReadLine();

            Console.WriteLine("...................");
            Console.WriteLine("Comprovante devedor");

            var fiados = new Fiado(nome, valor, data, produto);
            Console.WriteLine(fiados);
        }
    }
}