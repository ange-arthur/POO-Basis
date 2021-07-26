using System;
using System.Collections.Generic;
using System.Text;

namespace POO_Basis
{
    public class Manager : IManager
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public int NbrAnneesExperience { get; set; }
        public double Salaire { get; set; }
        public void AfficherInfo()
        {
            Console.WriteLine("Nom du manager : {0}", Nom);
            Console.WriteLine("Prenom du manager : {0}", Prenom);
            Console.WriteLine("Nombre d'années d'expérience du manager : {0}", NbrAnneesExperience);
            Console.WriteLine("Salaire du manager : {0}", Salaire);
        }
    }
}
