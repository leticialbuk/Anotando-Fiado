namespace Fiados
{
    public static class Registros
    {
        public static void Menu()
        {
            var option = short.Parse(Console.ReadLine());
            MenuOption(option);
        }

        public static void MenuOption(short option)
        {
            var escolha = "";
            switch (option)
            {
                case 1:
                    escolha = Fiado();
                    break;
                case 2:
                    escolha = ParcialPagos();
                    break;
            }
        }
    }
}