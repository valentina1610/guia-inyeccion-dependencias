using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ej2dependencias.Interface;

namespace ej2dependencias.Class
{
    public class AppService
    {
        private readonly ILogger _logger;
        public ILogger optionalLogger { get; set; }

        public AppService(ILogger logger)
        {
            _logger = logger;
        }
        public void Run()
        {
            _logger.Log("Welcome to the AppService using Dependency Injection.");

            if (optionalLogger != null)
            {
                Console.WriteLine("Optional mode activated!");
            }
        }
    }
}
