using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_InterfaceAbstraction.Models
{
    internal class ConsoleVertical : IConsole
    {
        public void WriteLine(string message)
        {
            foreach (char c in message)
            {
                Console.WriteLine(c);
            }
        }
    }
}
