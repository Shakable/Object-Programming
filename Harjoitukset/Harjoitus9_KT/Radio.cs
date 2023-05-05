using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus9_KT
{
    internal class Radio
    {
        public bool Paalla { get; set; }

        private int Aani_Pvt;
        public int Aani
        {
            get => Aani_Pvt;
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Ääni ei voi olla pienempi kuin 0");
                    value = 0;
                } else if (value > 9)
                {
                    Console.WriteLine("Ääni ei voi ylittää 9 rajaa");
                    value = 9;
                }
                Console.WriteLine("Nykyinen ääniasetus on: " + value);

                Aani_Pvt = value;
            }
        }
        
    }
}
