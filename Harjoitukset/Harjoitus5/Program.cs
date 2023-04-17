using Harjoitus5;
internal class Program
{
    private static void Main(string[] args)
    {
        Random Number_Random = new Random();
        Number New_Number = new Number();

        New_Number.Primary_Number = Number_Random.Next(100);
        New_Number.Secondary_Number = Number_Random.Next(100);

        Console.WriteLine(New_Number.Primary_Number + " + " + New_Number.Secondary_Number + " = " + Number.Add(New_Number.Primary_Number, New_Number.Secondary_Number));
        Console.WriteLine(New_Number.Primary_Number + " - " + New_Number.Secondary_Number + " = " + Number.Subtract(New_Number.Primary_Number, New_Number.Secondary_Number));
        Console.WriteLine(New_Number.Primary_Number + " * " + New_Number.Secondary_Number + " = " + Number.Multiply(New_Number.Primary_Number, New_Number.Secondary_Number));
        Console.WriteLine(New_Number.Primary_Number + " / " + New_Number.Secondary_Number + " = " + Number.Divide(New_Number.Primary_Number, New_Number.Secondary_Number));
    }
}