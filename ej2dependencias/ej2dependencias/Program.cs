using System;
using ej2dependencias.Class;
using ej2dependencias.Implementation;
using ej2dependencias.Interface;

namespace ej2dependencias
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ILogger logger = new ConsoleLogger();
            AppService app = new AppService(logger);
            app.optionalLogger = new ConsoleLogger();
            app.Run();
        }
    }
}
