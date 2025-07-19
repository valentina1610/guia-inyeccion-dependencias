using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ej5dependencias.Interface;

namespace ej5dependencias.Mock
{
    public class MockLogger : ILogger
    {
        public List<string> Messages { get; } = new List<string>();

        public void Log(string message)
        {
            Messages.Add(message);
        }

    }
}
