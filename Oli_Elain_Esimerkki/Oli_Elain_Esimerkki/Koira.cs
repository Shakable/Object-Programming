using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oli_Elain_Esimerkki
{
    internal class Koira
    {
        public string Nimi { get; set; }
        public string Rotu { get; set; }
        public int Ikä { get; set; }
        public string Väri { get; set; }
        public float Paino { get; set; }

        public string HaeTiedot ()
        {
            string KoiranTiedot = "Nimi: " + Nimi + "\nRotu: " + Rotu + "\nIkä: " + Ikä.ToString() + "\nVäri: " + Väri + "\nPaino: " + Paino.ToString();

            return KoiranTiedot;
        }

        /*public Koira(string _nimi, string _rotu, int _ikä, string _väri, float _paino)
        {
            Nimi = _nimi;
            Rotu = _rotu;
            Ikä = _ikä;
            Väri = _väri;
            Paino = _paino;
        }*/

        public void Hauku()
        {
            Console.WriteLine("Woof Woof");
        }
    }
}
