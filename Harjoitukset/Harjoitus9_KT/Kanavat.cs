using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus9_KT
{
    internal class Kanavat
    {
        private float taajuudet;

        public string nimi { get ; set; }
        
        public string Nimi 
        {    
            get { return nimi; } 
            
            set { nimi = value; } 
        }

        public float Taajuus
        { 
            get { return taajuudet; } 
            set 
            {
                if (value <= 88.0f)
                {
                    Console.WriteLine("Taajuus oli liian pieni, taajuus nollattu.");
                    Taajuus = 0;
                    taajuudet = 0;
                }
                else if (value >= 107.9f)
                {
                    Console.WriteLine("Taajuus oli liian suuri, taajuus nollattu.");
                    Taajuus = 0;
                    taajuudet = 0;
                }
                else
                {
                    taajuudet = value;
                    Console.WriteLine("Taajuus on nytten " +  taajuudet);
                }
            }
        }
    }
}
