using System;
using System.Collections.Generic;
using System.Text;

namespace POO_Basis
{
    class Indexeur
    {
        public readonly Dictionary<string, string> _listeCompteBancaire;
        public string Nom { get; set; }
        public string Prenom { get; set; }

        public Indexeur()
        {
            _listeCompteBancaire = new Dictionary<string, string>();
        }

        public string this[string key]
        {
            get
            {
                return _listeCompteBancaire[key];
            }

            set
            {
                _listeCompteBancaire[key] = value;
            }
        }
    }
}
