using System;
using Learning03;

class Program
{
    static void Main(string[] args)
    {
        var fration1 = new Fraction();

        for (int i = 0; i < 19; i++)
        {
            var random = new Random();
            var numerator = random.Next(1, 10);
            var denominator = random.Next(1, 10);
            fration1.SetTop(numerator);
            fration1.SetBottom(denominator);
            Console.WriteLine($"Fraction 1: {fration1.GetFractionString()} Number: {fration1.GetDecimalValue()}");
        }
    }
}