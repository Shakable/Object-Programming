using Harjoitus11;

internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<string, Opiskelija> OpiskelijaSanakirja = new Dictionary<string, Opiskelija>();

        string Etunimi;
        string Sukunimi;
        string RyhmaTunnus;
        string OpiskelijaTunnus;

        int Loopcount = 0;

        while (true)
        {
            Console.WriteLine("\n\n");
            Console.Write("Anna seuvaarat tiedot. \nEtunimi: ");
            Etunimi = Console.ReadLine();
            Console.Write("Sukunimi: ");
            Sukunimi = Console.ReadLine();
            Console.Write("RyhmäTunnus: ");
            RyhmaTunnus = Console.ReadLine();
            Console.Write("OpiskelijaTunnus: ");
            OpiskelijaTunnus = Console.ReadLine();
            Console.WriteLine();


            if (OpiskelijaSanakirja.ContainsKey(OpiskelijaTunnus))
            {
                Console.WriteLine("Ei toiminut, Ei lisätty.\n\n");
            }
            else
            {
            Opiskelija Opiskelija1 = new Opiskelija(Etunimi, Sukunimi, RyhmaTunnus, OpiskelijaTunnus);
            OpiskelijaSanakirja.Add(Opiskelija1.OpiskelijaID, Opiskelija1);
            }






            foreach (string ID in OpiskelijaSanakirja.Keys)
            {
                Console.WriteLine("Etunimi ja Sukunimi: " + OpiskelijaSanakirja[ID].Enimi + " " + OpiskelijaSanakirja[ID].Snimi);
                Console.WriteLine("Ryhmä tunnus: " + OpiskelijaSanakirja[ID].TiimiID);
                Console.WriteLine("Opiskelijan tunnus: " + OpiskelijaSanakirja[ID].OpiskelijaID);
                Console.WriteLine();
            }
            
            if (Loopcount >= 2)
            {
                break;
            }

            Loopcount++;
        }
     }
}