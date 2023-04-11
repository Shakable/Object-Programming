using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus4_KT
{
    internal class Song
    {
        private string Name;
        private string Duration;

        public Song(string name, string duration)
        {
            Name = name;
            Duration = duration;
        }

        public void DisplaySongInfo()
        {
            Console.WriteLine("--- Nimi: " + Name + " - " + Duration + " minuuttia");
        }

    }
}
