using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ej4dependencias.Interface;

namespace ej4dependencias.Implementations
{
    public class SmsService : IMessageService
    {
        public void Send(string message)
        {
            Console.WriteLine($"[SMS]: {message}");
        }
    }
}
