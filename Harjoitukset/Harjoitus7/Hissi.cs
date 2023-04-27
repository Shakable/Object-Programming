using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus7
{
    internal class Hissi
    {
        private int kerros;

        public int Hissi_Kerros
        {
            get => kerros;
            set
            {
                if (value > 6)
                {
                    Console.WriteLine("Given floor value is above 6.");
                    value = 6;
                } else if (value < 0)
                {
                    Console.WriteLine("Given floor value is below 0");
                    value = 0;
                }
                Console.WriteLine("Current floor is: " +  value);

                kerros = value;
            }
            
        }
    }
}
