using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus10
{
    internal interface ICanSwim
    {
        public float SwinSpeed {get; set;}
        public void Swim();
    }
}
