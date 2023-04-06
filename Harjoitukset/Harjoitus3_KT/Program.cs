using Harjoitus3_KT;
internal class Program
{
    private static void Main(string[] args)
    {
        Kiuas kuias = new Kiuas();
        
        kuias.Lämpö = 96.5;
        kuias.Kosteus = 80;
        kuias.Käynnissä = true;

        Console.WriteLine(kuias.Asetukset() + "\n");

        kuias.Käynnissä = false;

        Console.WriteLine(kuias.Asetukset() + "\n");
    }
}