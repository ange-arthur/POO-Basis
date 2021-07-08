using System;
using System.Collections.Generic;
using System.Text;

namespace POO_Basis
{
    class CompteBancaire
    {
        /*
         * Mise en application de l'heritage
         */

        public string IBAN { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }

        public void AfficherInfoBase()
        {
            Console.WriteLine("Nom : {0}", Nom);
            Console.WriteLine("Prenom : {0}", Prenom);
            Console.WriteLine("IBAN : {0}", IBAN);
        }
    }
}
