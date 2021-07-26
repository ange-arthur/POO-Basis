using System;
using System.Collections.Generic;
using System.Text;

namespace POO_Basis
{
    public class Moteur
    {
		/*
		* Mise en application de la composition
		*/
		public double Poids { get; set; }
		public string Marque { get; set; }
		public double Diametre { get; set; }

		public void AfficherInfoMoteur()
		{
			Console.WriteLine("Poids du moteur : {0}", Poids);
			Console.WriteLine("Marque du moteur : {0}", Marque);
			Console.WriteLine("Diametre du moteur : {0}", Diametre);
		}
	}
}
