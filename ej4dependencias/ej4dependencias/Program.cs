using System;
using ej4dependencias.Classes;

namespace ej4dependencias
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var manager = CompositionRoot.Build();

            manager.Notify("Hello!");

        }
    }
}
