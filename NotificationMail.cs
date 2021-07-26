using System;
using System.Collections.Generic;
using System.Text;

namespace POO_Basis
{
    public class NotificationMail : INotificationChannel
    {
        public void Send()
        {
            Console.WriteLine("Notification by Mail");
        }
    }
}
