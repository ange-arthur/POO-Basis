using System;

namespace POO_Basis
{
    public class Voiture
    {
        /*
		* Mise en application de la composition
		*/
        private Moteur _moteur;
        public double Poids { get; set; }
        public string Marque { get; set; }
        public double Taille { get; set; }

        public void AfficherInfo()
        {
            Console.WriteLine("Poids : {0}", Poids);
            Console.WriteLine("Marque : {0}", Marque);
            Console.WriteLine("Taille : {0}", Taille);
            _moteur.AfficherInfoMoteur();
        }

        public Voiture(Moteur moteur)
        {
            _moteur = moteur;
        }
    }
}