using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus10
{
    class Sorsa : Eläin, ICanSwim, ICanFly
    {
        public float WingSize { get; set; }
        public float SwinSpeed { get; set; }

        public Sorsa(string _Name, float _WingSize, float _SwinSpeed)
        {
            Name = _Name;
            WingSize = _WingSize;
            SwinSpeed = _SwinSpeed;
        }

        public void fly()
        {
            Console.WriteLine("{0} lentää. Siipien koko on {1}", Name, WingSize);
        }

        public override void MakeSound()
        {
            Console.WriteLine("Quack");
        }

        public void Swim()
        {
            Console.WriteLine("{0} ui nopeudella {1}", Name, SwinSpeed);
        }
    }
}
