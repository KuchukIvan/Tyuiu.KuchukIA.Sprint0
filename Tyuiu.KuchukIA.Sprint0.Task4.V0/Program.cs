using Tyuiu.KuchukIA.Sprint0.Task4.V0.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(DataService.Addition(5, 5));

        Console.WriteLine(DataService.Subtraction(5, 5));

        Console.WriteLine(DataService.Multiplication(5, 5));

        Console.WriteLine(DataService.Division(5, 5));

        Console.ReadKey();
    }
}