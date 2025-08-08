using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        for (int i = 0; i < 12; i++)
        {
            Console.Write("Enter number: ");
            numbers.Add(int.Parse(Console.ReadLine()));
        }

        List<int> evenList = new List<int>();
        List<int> oddList = new List<int>();

        foreach (var num in numbers)
        {
            if (num % 2 == 0) evenList.Add(num);
            else oddList.Add(num);
        }

        Console.WriteLine("Even Numbers: " + string.Join(", ", evenList));
        Console.WriteLine("Odd Numbers: " + string.Join(", ", oddList));
    
    }
}