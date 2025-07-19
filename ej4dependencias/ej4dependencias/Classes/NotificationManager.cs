using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ej4dependencias.Interface;

namespace ej4dependencias.Classes
{
    public class NotificationManager
    {
        private readonly IMessageService _messageserv;

        public NotificationManager(IMessageService messageserv)
        {
            _messageserv = messageserv;
        }

        public void Notify(string msg)
        {
            _messageserv.Send(msg);
        }
    }
}
