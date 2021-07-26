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

        public override void AfficherInfo()
        {
            base.AfficherInfo();
            Console.WriteLine("Taux : {0}", Taux);
        }

        public override void AfficherTaux()
        {
            Console.WriteLine("Taux : {0}", Taux);
        }
    }
}
