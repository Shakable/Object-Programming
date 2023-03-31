using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Harjoitus2
{
    internal class Opiskelija
    {
        public string Nimi { get; set; }
        public string OpiskelijaID { get; set; }
        public int Opintopisteet { get; set; }

        public string TulostaData()
        {
            string OpiskelijaData = "Nimi: " + Nimi + "\nOpiskelija ID: " + OpiskelijaID + "\nOpintopisteet: " + Opintopisteet.ToString();

            return OpiskelijaData;
        }

        public int MuokkaaOpintopisteitä()
        {
            Console.Write(Nimi + " opintopiste määrä on " + Opintopisteet.ToString() + "\nAnna opiskelijalle uusi opintopiste määrä: ");
            Opintopisteet = int.Parse(Console.ReadLine());
            return Opintopisteet;
        }
    }
}
