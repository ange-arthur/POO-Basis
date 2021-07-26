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

        public CompteEpargne(string nom, string prenom, double taux) : base (nom, prenom)
        {
            Taux = taux;
        }

        public void AfficherTaux()
        {
            base.AfficherInfoBase();
            Console.WriteLine("Taux : {0}", Taux);
        }
    }
}
