using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_ClassStatic
{
    internal static class ConsoleRainbow
    {
        public static void WriteLine(string message)
        {
            int i = 0;
            foreach (char c in message)
            {
                Console.BackgroundColor = (ConsoleColor)(i % 16);
                Console.ForegroundColor = (ConsoleColor)(15-(i % 16));
                Console.Write(c);
                i++;
            }
            Console.ResetColor();
            Console.WriteLine();
        }
    }
}
