using Harjoitus9_KT;

internal class Program
{
    private static void Main(string[] args)
    {
        int Uusi_Aani;
        int Uusi_Taajuus;
        string Uusi_Paalla;

        Console.WriteLine("Luodaan uusi radio.");
        Radio radio = new Radio();
        Console.WriteLine("Uusi radio luotu, kirjoita 'exit' lopettaakseen.");

        while (true)
        {
            Console.Write("Valitse vaihdettava asetus ('päällä', 'äänenvoimakkuus' tai 'taajuus') \n-->");
            string luettuKomento = Console.ReadLine();

            if (luettuKomento.Equals("exit"))
            {
                break;
            } 
            else if (luettuKomento.Equals("päällä"))
            {
                string Kaynnissa;
                if (radio.Paalla)
                {
                    Kaynnissa = "Päällä";
                    Console.Write("Radio on nytten: " + Kaynnissa + ".\nAnna uusi asetus ('päälle' tai 'ei') \n-->"); //I had to make 2 of these.
                }
                else if (!radio.Paalla)
                {
                    Kaynnissa = "Pois päältä";
                    Console.Write("Radio on nytten: " + Kaynnissa + ".\nAnna uusi asetus ('päälle' tai 'ei') \n-->"); //For some reason cuz this thing is garbage.
                }
                while (true)
                {
                    Uusi_Paalla = Console.ReadLine();
                    if (Uusi_Paalla.Equals("päälle"))
                    {
                        radio.Paalla = true;
                        Console.WriteLine("Radio on nyt päällä.");
                        break;
                    }
                    else if (Uusi_Paalla.Equals("ei"))
                    {
                        radio.Paalla = false;
                        Console.WriteLine("Radio on nyt pois päältä.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Ei ollut oikea asetus, kirjoita joko 'päälle' tai 'ei'\n-->");
                    }

                }
                

            }
            else if (luettuKomento.Equals("äänenvoimakkuus"))
            {
                Console.Write("Nykyinen äänenvoimakkuus on: " +  radio.Aani + "\nAnna uusi äänenvoimakkuus (1-9)\n-->");
                while (true)
                {
                    string luettuArvo = Console.ReadLine();
                    bool result = int.TryParse(luettuArvo, out Uusi_Aani);
                    if (result)
                    {
                        radio.Aani = Uusi_Aani;
                        break;
                    }
                    else
                    {
                         Console.WriteLine("Ei ollut oikea arvo, kirjoita uudelleen.");
                    }

                }
            }
            else if (luettuKomento.Equals("taajuus"))
            {
                
            }
            else
            {
                Console.WriteLine("Ei toiminut, kirjoita uuselleen tai kirjoita 'exit' poistukaseen.");
            }
        }
    }
}