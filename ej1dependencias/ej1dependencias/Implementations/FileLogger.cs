using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ej1dependencias.Interface;

namespace ej1dependencias.Implementations
{
    internal class FileLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"[MOCK FILE]: {message}");
        }
    }
}
