using System;
using System.Collections.Generic;
using System.Text;

namespace POO_Basis
{
    class Calcule
    {
        /*
         * Surcharge de methodes
         */

        public int Addition(int x, int y)
        {
            return x + y;
        }
        public int Addition(int x, int y, int z)
        {
            return x + y + z;
        }
        public int Addition(params int [] somme)
        {
            var sum = 0;
            foreach (var valeur in somme)
            {
                sum += valeur;
            }
            return sum;
        }

    }
}
