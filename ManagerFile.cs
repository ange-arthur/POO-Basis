using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace POO_Basis
{
    public class ManagerFile : IManager
    {
        private string _path;
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public int NbrAnneesExperience { get; set; }
        public double Salaire { get; set; }

        public ManagerFile(string path)
        {
            _path = path;
        }

        public void AfficherInfo()
        {
            using( var streamwriter = new StreamWriter(_path,true))
            {
                streamwriter.WriteLine("Nom du managaer : {0}", Nom);
                streamwriter.WriteLine("Prenom du managaer : {0}", Prenom);
                streamwriter.WriteLine("Nombre d'années d'expérience du managaer : {0}", NbrAnneesExperience);
                streamwriter.WriteLine("Salaire du managaer : {0}", Salaire);
            }
        }
    }
}
