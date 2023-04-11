using Harjoitus4_KT;
internal class Program
{
    private static void Main(string[] args)
    {
        Album album = new Album("BattleJuice", "Crimson Light", "Metal & Rock", "Päätä itse.");

        album.AddSong(new Song("Crimson Light", "4:44"));
        album.AddSong(new Song("China Rising", "3:31"));
        album.AddSong(new Song("Serpent Head", "4:16"));
        album.AddSong(new Song("Inside a Fairy Tale", "5:10"));
        album.AddSong(new Song("Feel Alive", "3:26"));
        album.AddSong(new Song("Berserker", "3:34"));
        album.AddSong(new Song("Monster Disco", "3:14"));
        album.AddSong(new Song("From The Grave", "3:29"));
        album.AddSong(new Song("After Death", "3:57"));
        album.AddSong(new Song("Underworld City Lullaby", "2:01"));
        album.AddSong(new Song("Schooltime", "4:02"));

        album.DisplayAlbum();
    }
}