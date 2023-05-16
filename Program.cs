using Fiados;

namespace FiadoOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var escolha = Registros.Menu();

            Console.WriteLine("ANOTANDO FIADO");
            Console.WriteLine("..............");
            Console.WriteLine("Nome do cliente: ");
            var nome = Console.ReadLine();
            Console.WriteLine("Valor da compra R$: ");
            var valor = Console.ReadLine();
            Console.WriteLine("Digite a data da compra: ");
            var data = Console.ReadLine();
            Console.WriteLine("Digite os produtos adquiridos: ");
            var produto = Console.ReadLine();
            Console.Clear();

            if (escolha == "Fiado")
            {
                var fiados = new Fiado(nome, valor, data, produto);
                Console.WriteLine(fiados);
            }
            else
            {
                var parcialPagos = new ParcialPagos(nome, valor, data, produto);
                Console.WriteLine(parcialPagos);
            }
        }
    }
}