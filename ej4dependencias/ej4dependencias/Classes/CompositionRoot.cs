using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ej4dependencias.Implementations;
using ej4dependencias.Interface;

namespace ej4dependencias.Classes
{
    public static class CompositionRoot
    {
        public static NotificationManager Build()
        {
            bool useEmail = false;
            IMessageService service;
            if(useEmail)
            {
                service = new EmailService();
            }
            else
            {
                service = new SmsService();
            }
            return new NotificationManager(service);
        }

    }
}
