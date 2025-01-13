using Demo_InterfaceAbstraction.Models;

namespace Demo_InterfaceAbstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Quel genre de message voulez-vous voir?");
            ConsoleRainbow cr = new ConsoleRainbow();
            ConsoleVertical cv = new ConsoleVertical();
            ConsoleEncrypt ce = new ConsoleEncrypt();
            Console.WriteLine("1. écriture arc-en-ciel");
            Console.WriteLine("2. écriture verticale");
            Console.WriteLine("3. écriture encryptée");
            string answer = Console.ReadLine();
            IConsole c;
            switch (answer)
            {
                case "1":
                    c = cr;
                    break;
                case "2":
                    c = cv;
                    break;
                default:
                    c = ce;
                    break;
            }
            c.WriteLine("Hello, World!");
        }
    }
}
