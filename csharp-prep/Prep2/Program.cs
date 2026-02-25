using System;

enum Grade
{
    A = 93,
    Aminus = 90,
    Bplus = 87,
    B = 83,
    Bminus = 80,
    Cplus = 77,
    C = 73,
    Cminus = 70,
    Dplus = 67,
    D = 63,
    Dminus = 60,
    F = 0
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your grade percentage:");
        var gradeInput = Console.ReadLine();

        if (!int.TryParse(gradeInput, out var percentage))
        {
            Console.WriteLine("Invalid input. Please enter a valid integer percentage.");
            return;
        }

        String grade;

        if (percentage >= (int)Grade.A)
            grade = "A";
        else if (percentage >= (int)Grade.Aminus)
            grade = "A-";
        else if (percentage >= (int)Grade.Bplus)
            grade = "B+";
        else if (percentage >= (int)Grade.B)
            grade = "B";
        else if (percentage >= (int)Grade.Bminus)
            grade = "B-";
        else if (percentage >= (int)Grade.Cplus)
            grade = "C+";
        else if (percentage >= (int)Grade.C)
            grade = "C";
        else if (percentage >= (int)Grade.Cminus)
            grade = "C-";
        else if (percentage >= (int)Grade.Dplus)
            grade = "D+";
        else if (percentage >= (int)Grade.D)
            grade = "D";
        else if (percentage >= (int)Grade.Dminus)
            grade = "D-";
        else
            grade = "F";

        Console.WriteLine($"Your letter grade is: {grade}");

        Console.WriteLine(percentage >= 70 ? "You passed!" : "Better luck next time!");
    }
}