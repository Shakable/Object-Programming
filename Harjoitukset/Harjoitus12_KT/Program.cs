using Harjoitus12_KT;

internal class Program
{
    public static void lisaaKortit(string maa)
    {
        List<Kortit> Kortteja = new List<Kortit>();
        List<int> arvotut = new List<int>();

        for (int i = 1; i <= 13; i++)
        {
            Kortit kortti = new Kortit(maa, i);
            Kortteja.Add(kortti);
        }

        foreach (var kortti in Kortteja)
        {
            Console.WriteLine(kortti.Maa + " " + kortti.Numero);
        }
    }
    
    private static void Main(string[] args)
    {
        lisaaKortit("Pata");
        lisaaKortit("Risti");
        lisaaKortit("Herta");
        lisaaKortit("Ruutu");
        

    }
}