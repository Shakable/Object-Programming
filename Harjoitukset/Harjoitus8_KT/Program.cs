using Harjoitus8_KT;

internal class Program
{
    private static void Main(string[] args)
    {
        Tyontekijat tyontekijat = new Tyontekijat("Pate 1", "Vantaa", 50000, 30);
        Tyontekijat tyontekijat1 = new Tyontekijat("Pate 2", "Porvoo", 35000, 25);

        Henkilot.KuinkaMonta();
        Tyontekijat.Kuinkamonta_Tyo();
        Pomo.Pomo_Maara();

        Tyontekijat tyontekijat2 = new Tyontekijat("Pate 3", "Helsinki", 65000, 35);
        Pomo pomo = new Pomo("Pater boss 1", "Vantaa", 75000, 5000, "Volvo");

        Henkilot.KuinkaMonta();
        Tyontekijat.Kuinkamonta_Tyo();
        Pomo.Pomo_Maara();

        if (Pomo.count >= 1)
        {
            Console.WriteLine("Ei voi luoda enempää pomoja, jos pomo on olemassa.");
        } else 
        {
            Pomo pomo1 = new Pomo("Pater boss 2", "Helsinki", 70000, 3000, "Hyundai");
        }
        Henkilot.KuinkaMonta();
        Tyontekijat.Kuinkamonta_Tyo();
        Pomo.Pomo_Maara();

    }
}