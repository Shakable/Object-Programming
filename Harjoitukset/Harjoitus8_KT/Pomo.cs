using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus8_KT
{
    class Pomo : Henkilot
    {
        public override string Nimi { get; set; }
        public override string Tyopaikka { get; set; }
        public override double Palkka { get; set; }
        public double Boonus { get; set; }
        public string Auto { get; set; }

        public static int count;
        public Pomo(string _Nimi, string _Tyopaikka, double _Palkka, double _Boonus, string _Auto) 
        {
            Nimi = _Nimi;
            Tyopaikka = _Tyopaikka;
            Palkka = _Palkka;
            Boonus = _Boonus;
            Auto = _Auto;
            instanssit++;
            count = count + 1;
            if (count > 1 ) 
            {
                throw new Exception();
            }
        }
        public static void Pomo_Maara()
        {
            Console.WriteLine("Pomoja on " + count);
        }
    }
}
