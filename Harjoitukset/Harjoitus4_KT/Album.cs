using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus4_KT
{
    internal class Album
    {
        public string Artist_Name { get; set; }
        public string Album_Name { get; set; }
        public string Genre { get; set; }
        public string Price { get; set; }

        private List<Song> Songs = new List<Song>();

        public Album(string artist_Name, string album_Name, string genre, string price)
        {
            Artist_Name = artist_Name;
            Album_Name = album_Name;
            Genre = genre;
            Price = price;
        }

        public void AddSong(Song song)
        {
            Songs.Add(song);
        }

        public void DisplaySongs()
        {
            foreach (Song song in Songs)
            {
                song.DisplaySongInfo();
            }
        }

        public void DisplayAlbum()
        {
            Console.WriteLine("\nAlbumi: ");
            Console.WriteLine(" -Artisti: " + Artist_Name);
            Console.WriteLine(" -Albumi: " + Album_Name);
            Console.WriteLine(" -Genre: " + Genre);
            Console.WriteLine(" -Hinta: " +  Price);
            Console.WriteLine("Songs: ");
            DisplaySongs();
        }

    }
}
