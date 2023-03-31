using Oli_Elain_Esimerkki;

internal class Program
{
    private static void Main(string[] args)
    {
        Koira KoiraOlio = new Koira();

        KoiraOlio.Nimi = "Rekku";
        KoiraOlio.Rotu = "Saksanpaimenkoira";
        KoiraOlio.Ikä = 4;
        KoiraOlio.Väri = "Harmaa";
        KoiraOlio.Paino = 32.1f;

        KoiraOlio.Hauku();

        Console.WriteLine(KoiraOlio.HaeTiedot());

        KoiraOlio.Hauku();
        
    }
}

/*private static void Main(string[] args)
    {
        Koira KoiraOlio = new Koira("Rekku", "Saksanpaimenkoira", 4, "Harmaa", 32.1f);

        Console.WriteLine(KoiraOlio.HaeTiedot());

        KoiraOlio.Hauku();
    } */
