using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus10
{
    class Kala : Eläin, ICanSwim
    {
        public float SwinSpeed { get; set; }
        public string Sound { get; set; }

        public Kala(string _Name, int _SwimSpeed, string _sound)
        {
            Name = _Name;
            SwinSpeed = _SwimSpeed;
            Sound = _sound;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Blurp");
        }

        public void Swim()
        {
            Console.WriteLine("Kala {0} ui nopeudella {1}", Name, SwinSpeed);
        }
    }
}
