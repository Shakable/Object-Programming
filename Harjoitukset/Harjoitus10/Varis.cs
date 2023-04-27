using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Harjoitus10
{
    class Varis : Eläin, ICanFly
    {
        public float WingSize { get; set; }

        public Varis(string _Name, float _WingSize) 
        {
            Name = _Name;
            WingSize = _WingSize;
        }

        public void fly()
        {
            Console.WriteLine("{0} lentää. Siipien koko on {1}", Name, WingSize);
        }

        public override void MakeSound()
        {
            Console.WriteLine("Kakaaw, Kakaaw");
        }
    }
}
