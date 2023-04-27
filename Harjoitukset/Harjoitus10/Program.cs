using Harjoitus10;

internal class Program
{
    private static void Main(string[] args)
    {
        Varis varis = new Varis("Varis", 90);

        varis.MakeSound();
        varis.fly();

        Kala ahven = new Kala("Ahven", 50, "Blurps");

        ahven.MakeSound();
        ahven.Swim();

        Sorsa sorsa = new Sorsa("Sorsa", 90, 10);

        sorsa.MakeSound();
        sorsa.fly();
        sorsa.MakeSound();
        sorsa.Swim();
    }
}