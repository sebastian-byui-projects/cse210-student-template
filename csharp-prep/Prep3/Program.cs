namespace Prep3;

internal abstract class Program
{
    static void Main(string[] args)
    {
        var found = false;
        var magicNumber = new Random();
        var number = magicNumber.Next(1, 101);

        while (!found)
        {
            Console.Write("What is your guess? ");
            var guessInput = Console.ReadLine();
            if (int.TryParse(guessInput, out var guess))
            {
                if (guess == number)
                {
                    Console.WriteLine("You guessed it!");
                    found = true;
                }
                else if (guess < number)
                {
                    Console.WriteLine("Too low!");
                }
                else
                {
                    Console.WriteLine("Too high!");
                }
            }
            else
            {
                Console.WriteLine("Invalid guess. Please enter a number.");
            }
        }
    }
}