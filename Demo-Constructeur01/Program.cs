using Demo_Constructeur01.Models;

namespace Demo_Constructeur01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Chat matou = new Chat("Billy");
            Console.WriteLine($"Mon matou a pour données :");
            Console.WriteLine(matou);

            Chien chien = new Chien("Rex", "grande");
            Console.WriteLine($"Mon chien a pour données :");
            Console.WriteLine(chien);
        }
    }
}
