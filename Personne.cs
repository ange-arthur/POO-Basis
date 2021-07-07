using System;
using System.Collections.Generic;
using System.Text;

namespace POO_Basis
{
	/*
	* Mise en application des constructeurs, des setters et getters
	*/
	
	public class Personne
	{
		private string _nom;
		private string _prenom;
		public int _age;

		public Personne(string nom)
		{
			_nom = nom;
		}

		public Personne(string nom, string prenom) : this(nom)
		{
			_prenom = prenom;
		}

		public Personne(string nom, string prenom, int age) : this(nom, prenom)
		{
			_age = age;
		}

		public void AfficherInfo()
		{
			Console.WriteLine("Nom: {0}", _nom);
			Console.WriteLine("Prenom: {0}", _prenom);
			Console.WriteLine("Age: {0}", _age);
		}

		public void SetNom( string nom)
        {
			_nom = nom;
        }

		public string GetNom()
        {
			return _nom;
        }

		public void SetPrenom( string prenom)
        {
			_prenom = prenom;
        }

		public string GetPrenom()
        {
			return _prenom;
        }
	}
}
