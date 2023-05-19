using Fiados;

namespace FiadoOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var parcialPago = new List<ParcialPagos>();
            var fiado = new List<Fiado>();
            short resp = -1;
            do
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
                    fiado.Add(fiados);
                }
                else
                {
                    var parcialPagos = new ParcialPagos(nome, valor, data, produto);
                    parcialPago.Add(parcialPagos);
                }

                Console.WriteLine("Deseja adicionar mais intens? \n1 - sim \n2 - não");
                resp = short.Parse(Console.ReadLine());

            } while (resp == 1);

            if (fiado.Count > 0)
            {
                var comprovanteFiado = string.Empty;
                foreach (var item in fiado)
                {
                    comprovanteFiado += "\n" + item.ToString();
                }
                Console.WriteLine("COMPROVANTE DEVEDOR");
                Console.WriteLine("...................");
                Console.WriteLine(comprovanteFiado);
            }

            if (parcialPago.Count > 0)
            {
                var comprovanteParcial = string.Empty;
                foreach (var item in parcialPago)
                {
                    comprovanteParcial += "\n" + item.ToString();
                }
                Console.WriteLine("COMPROVANTE PARCIAL");
                Console.WriteLine("...................");
                Console.WriteLine(comprovanteParcial);
            }
        }
    }
}