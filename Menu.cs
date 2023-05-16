namespace Fiados
{
    public static class Registros
    {
        public static string Menu()
        {
            short option = -1;
            do
            {
                Console.WriteLine("ANOTANDO FIADO");
                Console.WriteLine("..............");
                Console.WriteLine("Escolha forma de anotação: ");
                Console.WriteLine("1 - Fiado");
                Console.WriteLine("2 - Parcialmente Pago");
                Console.WriteLine("0 - Para Sair");

                option = short.Parse(Console.ReadLine());
                if (option != 1 && option != 2 && option != 0)
                {
                    Console.WriteLine("Opção inválida, digite novamente");
                }
            } while (option != 1 && option != 2 && option != 0);

            var escolha = MenuOption(option);
            return escolha;
        }

        public static string MenuOption(short option)
        {
            var escolha = "";
            switch (option)
            {
                case 1:
                    escolha = "Fiado";
                    break;
                case 2:
                    escolha = "Parcialmente Pago";
                    break;
                case 0:
                    {
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                    }
            }
            return escolha;
        }
    }
}