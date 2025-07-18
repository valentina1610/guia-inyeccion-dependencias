using System;
using ej3dependencias.Class;
using ej3dependencias.Implementation;

namespace ej3dependencias
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var reportGen = new ReportGenerator();
            reportGen.Configure(new ConsoleLogger());
            reportGen.GenerateReport();
        }
    }
}
