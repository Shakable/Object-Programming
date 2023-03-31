using Harjoitus2;
internal class Program
{
    private static void Main(string[] args)
    {
        Opiskelija oppilas = new Opiskelija();

        oppilas.Nimi = "Rekku Mordiin";
        oppilas.OpiskelijaID = "123456A789B";
        oppilas.Opintopisteet = 16;

        Console.WriteLine(oppilas.TulostaData() + "\n");

        Console.WriteLine(oppilas.MuokkaaOpintopisteitä() + " on " + oppilas.Nimi + " uusi oppintopiste määrä.");
    }
}