using System;
using System.Collections.Generic;
using System.Text;

namespace POO_Basis
{
    class Tools
    {
        /*
         * Difference entre "ref" et "out"
         */

        public void Incrementer(ref  int x)
        {
            x++;
            Console.WriteLine("Methode incrementer x : {0}", x);
        }

        public void AfficherValeur(out int x)
        {
            x = 10;
            Console.WriteLine("Methode afficher valeur de x : {0}", x);
        }
    }
}
