using Harjoitus1;
internal class Program
{
    private static void Main(string[] args)
    {
        Auto car = new Auto();

        car.Name = "Volvo";
        car.Speed = 80;
        car.Tires = 4;

        Console.WriteLine(car.TulostaData());
    }
}