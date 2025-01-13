using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_InterfaceAbstraction.Models
{
    internal class ConsoleEncrypt : IConsole
    {
        public void WriteLine(string message)
        {
            for(int i =0; i< message.Length; i++)
            {
                char c = message[i];
                c = (char)(c + 5);
                Console.Write(c);
            }
            Console.WriteLine();
        }
    }
}
