using Harjoitus12_KT;

internal class Program
{
    public static void lisaaKortit(string maa)
    {
        List<Kortit> Kortteja = new List<Kortit>();
        List<int> arvotut = new List<int>();

        Random rnd = new Random();

        
            
        


        for (int i = 1; i <= 13; i++)
        {
             int arvo = rnd.Next(1, 14);

            Kortit kortti = new Kortit(maa, i);
            Kortteja.Add(kortti);
            
            if (arvotut.Contains(arvo))
            {

                i--;


            } else
            {

                arvotut.Add(arvo);

            }

            for (int j = 0; j <= 12; j++)
            {

                Console.WriteLine(Kortteja[arvotut[j]]);
                
            }
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