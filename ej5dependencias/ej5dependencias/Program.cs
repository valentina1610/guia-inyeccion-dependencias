using System;
using ej5dependencias.Class;
using ej5dependencias.Mock;

namespace ej5dependencias
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var mockLogger = new MockLogger();
            var appService = new AppService(mockLogger);

            appService.Run();

            foreach (var m in mockLogger.Messages)
            {
                Console.WriteLine(m);
            }

        }
    }
}
