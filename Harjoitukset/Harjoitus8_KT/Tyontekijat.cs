using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus8_KT
{
    class Tyontekijat : Henkilot
    {
        public override string Nimi { get; set; }
        public override string Tyopaikka { get; set; }
        public override double Palkka { get; set; }
        public float ViikoTunnit { get; set; }
        public static int Tyo_instassit;

        public Tyontekijat(string nimi, string tyopaikka, double palkka, float viikoTunnit)
        {
            Nimi = nimi;
            Tyopaikka = tyopaikka;
            Palkka = palkka;
            ViikoTunnit = viikoTunnit;
            instanssit++;
            Tyo_instassit++;
        }
        public static void Kuinkamonta_Tyo()
        {
            Console.WriteLine("Työntekijoitä on " + Tyo_instassit);
        }
    }
}
