using Harjoitus9_KT;

internal class Program
{
    private static void Main(string[] args)
    {
        int Uusi_Aani;
        string Uusi_Paalla;
        string Uusi_Taajuus_String;
        float Uusi_Taajuus;

        Console.WriteLine("Luodaan uusi radio.");
        Radio radio = new Radio();

        Kanavat kanava1 = new Kanavat();
        kanava1.nimi = "Yle";
        kanava1.Taajuus = 100.5f;

        Kanavat kanava2 = new Kanavat();
        kanava2.nimi = "Tuntematon";
        kanava2.Taajuus = 98.4f;

        Kanavat kanava3 = new Kanavat();
        kanava3.nimi = "Tuntematon";
        kanava3.Taajuus = 88.1f;

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
                if (radio.Paalla == true)
                {
                    while (true)
                    {
                        Console.Write("Valitse taajuus tai kirjoita 'kanava lista'\n--->");

                        Uusi_Taajuus_String = Console.ReadLine();

                        if (float.TryParse(Uusi_Taajuus_String, out Uusi_Taajuus))
                        {
                            if (Uusi_Taajuus == kanava1.Taajuus)
                            {
                                Console.WriteLine("Taajuus: " + Uusi_Taajuus + "\nKanava " + kanava1.Nimi + " valittu.");
                                break;
                            }
                            else if (Uusi_Taajuus == kanava2.Taajuus)
                            {
                                Console.WriteLine("Taajuus: " + Uusi_Taajuus + "\nKanava " + kanava2.Nimi + " valittu.");
                                break;
                            }
                            else if (Uusi_Taajuus == kanava3.Taajuus)
                            {
                                Console.WriteLine("Taajuus: " + Uusi_Taajuus + "\nKanava " + kanava3.Nimi + " valittu.");
                                break;
                            }
                        }
                        else if (Uusi_Taajuus_String == "kanava lista")
                        {
                            Console.WriteLine("Kanavat: \nNimi: " + kanava1.Nimi + " Taajuus: " +  kanava1.Taajuus);
                            Console.WriteLine("Nimi: " + kanava2.Nimi + " Taajuus: " + kanava2.Taajuus);
                            Console.WriteLine("Nimi: " + kanava3.Nimi + " Taajuus: " + kanava3.Taajuus + "\n");
                        }
                        else
                        {
                            Console.WriteLine("Väärä vastaus.");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Radio ei ole päällä, laita se päälle jotta voit vaihtaa taajuutta.");
                }
            }
            else
            {
                Console.WriteLine("Ei toiminut, kirjoita uuselleen tai kirjoita 'exit' poistukaseen.");
            }
        } //Radion toiminnot.
    }
}