using System;
using System.Collections.Generic;
using System.Text;

namespace POO_Basis
{
    class CompteEpargne : CompteBancaire
    {
        /*
         * Mise en application de l'heritage
         */

        public double Taux { get; set; }

        public void AfficherTaux()
        {
            Console.WriteLine("Taux : {0}", Taux);
        }
    }
}
