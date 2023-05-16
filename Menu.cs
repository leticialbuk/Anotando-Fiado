namespace Fiados
{
    public static class Registros
    {
        public static string Menu()
        {
            Console.WriteLine("ANOTANDO FIADO");
            Console.WriteLine("..............");
            Console.WriteLine("Escolha forma de anotação: ");
            Console.WriteLine("1- Fiados");
            Console.WriteLine("2 - Parcialmente Pagos");

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
                    escolha = "ParcialPagos";
                    break;
            }
            return escolha;
        }
    }
}