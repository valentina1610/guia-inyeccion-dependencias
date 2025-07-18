using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ej3dependencias.Interface;

namespace ej3dependencias.Implementation
{
    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"[CONSOLE]: {message}");
        }
    }
}
