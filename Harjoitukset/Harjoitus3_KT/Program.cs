using Harjoitus3_KT;
internal class Program
{
    private static void Main(string[] args)
    {
        // Uusi olio.
        Kiuas kuias = new Kiuas();

        // Ominaisuudet oliolle.
        kuias.Lämpö = 96.5;
        kuias.Kosteus = 80;
        kuias.Käynnissä = true;

        //Kirjoittaa olion ominaisuudet.
        Console.WriteLine(kuias.Asetukset() + "\n");

        //Vaihdetaan olion ominaisuus ja kirjoitaa ne uudelleen. 
        kuias.Käynnissä = false;
        Console.WriteLine(kuias.Asetukset() + "\n");
    }
}