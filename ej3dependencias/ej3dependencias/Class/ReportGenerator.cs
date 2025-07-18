using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ej3dependencias.Interface;
using ej3dependencias.Interfaces;

namespace ej3dependencias.Class
{
    public class ReportGenerator : IConfigurable<ILogger>
    {
        private ILogger _logger;

        public void Configure(ILogger dep)
        {
            _logger = dep;
        }
        public void GenerateReport()
        {
            if (_logger != null)
            {
                _logger.Log("Report ready.");
            }
            else
            {
                Console.WriteLine("[ERROR]: Logger not configured !");
            }
        }
    }
}
