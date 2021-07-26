using System;
using System.Collections.Generic;
using System.Text;

namespace POO_Basis
{
    public class Entreprise
    {
        IManager _manager;
        public readonly List<INotificationChannel> _listNotification;
        public string Nom { get; set; }
        public string Adresse { get; set; }
        public int NbrEmployes { get; set; }

        public Entreprise(IManager manager)
        {
            _manager = manager;
            _listNotification = new List<INotificationChannel>();
        }

        public void AfficherInfoEntreprise()
        {
            Console.WriteLine("Nom de l'entreprise : {0}", Nom);
            Console.WriteLine("Adresse de l'entreprise : {0}", Adresse);
            Console.WriteLine("Nombre d'employes de l'entreprise : {0}", NbrEmployes);
            _manager.AfficherInfo();
        }

        public void AjouterNotification(INotificationChannel notification)
        {
            _listNotification.Add(notification);
        }

        public void SendNotificationManager()
        {
            foreach(var notification in _listNotification)
            {
                notification.Send();
            }
        }
        
    }
}
