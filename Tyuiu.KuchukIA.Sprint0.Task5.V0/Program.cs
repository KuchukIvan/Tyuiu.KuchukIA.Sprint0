using Tyuiu.KuchukIA.Sprint0.Task5.V0.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("A + B = " + DataService.Addition(5, 5));

        Console.WriteLine("A - B = " + DataService.Subtraction(5, 5));

        Console.WriteLine("A * B = " + DataService.Multiplication(5, 5));

        Console.WriteLine("A / B = " + DataService.Division(9, 3));

        Console.ReadKey();
    }
}