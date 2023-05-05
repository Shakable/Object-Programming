using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus3_KT
{
    internal class Kiuas
    {
        //Arvot oliolle.
        public bool Käynnissä { get; set; }
        public int Kosteus { get; set; }
        public double Lämpö { get; set; }


        
        public string Asetukset() //Katsoo onko laite päällä ja kirjoittaa sen nykyiset asetukset.
        {
            string päällä;
            if (Käynnissä == true)
            {
                päällä = "Kyllä";
            }
            else
            {
                päällä = "Ei";
            }

            string Nykyset_Asetukset = "Nykyset asetukset:\nLämpö: " + Lämpö.ToString() + "°C\nKosteus: " + Kosteus.ToString() + "%\nPäällä: " + päällä;

            return Nykyset_Asetukset;
        }
    }
}
