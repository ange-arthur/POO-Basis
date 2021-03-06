using System;
using System.Collections.Generic;
using System.Text;

namespace POO_Basis
{
    public abstract class CompteBancaire
    {
        /*
         * Mise en application de l'heritage
         */

        public string IBAN { get; set; }
        private string _nom;
        private string _prenom;

        public CompteBancaire(string nom, string prenom)
        {
            _nom = nom;
            _prenom = prenom;
        }
        public virtual void AfficherInfo()
        {
            Console.WriteLine("Nom : {0}", _nom);
            Console.WriteLine("Prenom : {0}", _prenom);
            Console.WriteLine("IBAN : {0}", IBAN);
        }

        public abstract void AfficherTaux();
    }
}
