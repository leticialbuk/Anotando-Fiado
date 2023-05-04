using Fiados;

namespace FiadoOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var fiados = new Fiado("Cliente X", 24, 0, "3 águas");
            Console.WriteLine(fiados);
        }
    }
}