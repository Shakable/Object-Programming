using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus8_KT
{
    abstract class Henkilot
    {
        public abstract string Nimi { get; set; }
        public abstract string Tyopaikka { get; set; }
        public abstract double Palkka { get; set; }

        public static int instanssit;

        public static void KuinkaMonta() 
        {
            Console.WriteLine("Nyt on " + instanssit + " monta henkilöä.");
        }
    }
}
