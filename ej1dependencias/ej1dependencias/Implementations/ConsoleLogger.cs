using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ej1dependencias.Interface;

namespace ej1dependencias.Implementations
{
    public class ConsoleLogger : ILogger
    {
        public void Log (string message)
        {
            Console.WriteLine($"[CONSOLE]: {message}");
        }
    }
}
