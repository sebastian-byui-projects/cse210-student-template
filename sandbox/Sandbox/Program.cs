namespace Sandbox;

internal abstract class Program
{
    private static void Main(string[] args)
    {
        // var done = false;
        //
        // while (!done)
        // {
        //     Console.WriteLine("Please input your age: ");
        //     var input = Console.ReadLine();
        //     if (!int.TryParse(input, out var age)) continue;
        //     if (age is >= 0 and <= 120)
        //     {
        //         Console.WriteLine($"Your age is {age}");
        //         done = true;
        //     }
        //     else
        //     {
        //         Console.WriteLine("Please input a valid age between 0 and 120.");
        //     }
        // }
        //
        //


        // var done2 = false;
        //
        // do
        // {
        //     Console.WriteLine("Please input your age: ");
        //     var input = Console.ReadLine();
        //     if (!int.TryParse(input, out var age)) continue;
        //     if (age is >= 0 and <= 120)
        //     {
        //         Console.WriteLine($"Your age is {age}");
        //         done2 = true;
        //     }
        //     else
        //     {
        //         Console.WriteLine("Please input a valid age between 0 and 120.");
        //     }
        // } while (!done2);

        var array = new string[5];
        var list = new List<Person>();
        var map = new Dictionary<string, string>();
        var set = new HashSet<string>();
        var tuple = (Name: "John", Age: 30, Address: "123 Main Street");
        var record = new Person("John", "Doe", 24);
        var recordStruct = new Person("Jane", "Smith", 36);
        var recordClass = new Person("Alice", "Johnson", 47);
        var anonymousType = new { Name = "Bob", Age = 25, Address = "456 Elm Street" };

        list.Add(new Person("John", "Doe", 24));
        list.Add(new Person("Jane", "Smith", 36));
        list.Add(new Person("Alice", "Johnson", 47));


        list.ForEach(Greeting);
        var olderThan30 = new Predicate<Person>(person => person.Age > 30);
        var result = list.FindAll(olderThan30);
        Console.WriteLine(result);
    }


    private static void Greeting(Person person)
    {
        var fullName = $"{person.FirstName} {person.LastName}";
        Console.WriteLine($"Hello, {fullName}!");
    }
}

internal record Person(string FirstName, string LastName, int Age);