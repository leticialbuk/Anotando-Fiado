namespace Fiados
{
    public static class Registros
    {
        public static string Menu()
        {
            Console.WriteLine("ANOTANDO FIADO");
            Console.WriteLine("..............");
            Console.WriteLine("Escolha forma de anotação: ");
            Console.WriteLine("1 - Fiado");
            Console.WriteLine("2 - Parcialmente Pago");
            Console.WriteLine("0 - Para Sair");

            var option = short.Parse(Console.ReadLine());
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