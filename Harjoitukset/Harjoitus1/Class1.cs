using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus1
{
    internal class Auto
    {
        public string Name { get; set; }
        public int Speed { get; set; }
        public int Tires { get; set; }

        public string TulostaData ()
        {
            string AutoTiedot = "Nimi: " + Name + "\nNopeus: " + Speed.ToString() + "km/h\nRenkaiden määrä: " + Tires.ToString();
            
            return AutoTiedot;
        }
    }
}
