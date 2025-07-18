using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ej1dependencias.Interface;

namespace ej1dependencias.Class
{
    public class AppService
    {
        private readonly ILogger _logger;

        public AppService(ILogger logger)
        {
            _logger = logger;
        }
        public void Run()
        {
            _logger.Log("Welcome to the AppService using Dependency Injection.");
        }
    }
}
