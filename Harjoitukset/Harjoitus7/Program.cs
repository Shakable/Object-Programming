using Harjoitus7;
using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {
        int newKerros;

        Console.WriteLine("Creating new Elevator");
        Hissi hissi = new Hissi();
        Console.WriteLine("New elevator created. To exit, type: 'leave'");

        while (true)
        {
            Console.Write("Give a new floor to elevator (0-6) > ");
            string luettuArvo = Console.ReadLine();

            if (luettuArvo.Equals("leave"))
            {
                break;
            }

            bool result = int.TryParse(luettuArvo, out newKerros);
            
            if (result)
            {
                hissi.Hissi_Kerros = newKerros;
            }
            else
            {
                Console.WriteLine("Error, Not a correct value. If you want to exit, type: 'Leave'");
               
            }
        }
    }
}