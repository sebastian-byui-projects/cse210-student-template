using System;

class Program
{
    static void Main(string[] args)
    {
        var numbers = new List<int>();
        var ended = false;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (!ended)
        {
            Console.Write("Enter a number: ");
            var input = Console.ReadLine();
            if (!int.TryParse(input, out var number)) return;
            if (number == 0)
            {
                ended = true;
            }
            else
            {
                numbers.Add(number);
            }
        }

        var sum = numbers.Sum();
        var average = numbers.Average();
        var max = numbers.Max();

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");
    }
}