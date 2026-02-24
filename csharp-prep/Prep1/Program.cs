namespace Prep1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your first name?");
        var firstName = Console.ReadLine();
        Console.WriteLine("What is your last name?");
        var lastName = Console.ReadLine();
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }
}