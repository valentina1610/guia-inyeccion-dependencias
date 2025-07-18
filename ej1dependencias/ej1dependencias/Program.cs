using System;
using ej1dependencias.Class;
using ej1dependencias.Implementations;
using ej1dependencias.Interface;

namespace ej1dependencias
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ILogger logger = new ConsoleLogger();
            //for try with FileLogger, change ConsoleLogger to FileLogger 

            AppService app = new AppService(logger);
            app.Run();
        }
    }
}
