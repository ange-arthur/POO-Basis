using System;
using System.Collections.Generic;
using System.Text;

namespace POO_Basis
{
    class Properties
    {
        public readonly DateTime _dateDeNaissance;
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public int Age { get 
            {
                var ageref = DateTime.Now - _dateDeNaissance;
                return (ageref.Days / 365);
            } 
            private set { }
        }

        public Properties(DateTime DateNaissance)
        {
            _dateDeNaissance = DateNaissance;
        }

        public void AfficherInfo()
        {
            Console.WriteLine("Nom : {0}", Nom);
            Console.WriteLine("Prenom : {0}", Prenom);
            Console.WriteLine("Date de naissance : {0}", _dateDeNaissance.ToShortDateString());
            Console.WriteLine("Age : {0}", Age);

        }
    }
}
