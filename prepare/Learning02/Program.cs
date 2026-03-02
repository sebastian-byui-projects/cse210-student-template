namespace Learning02;

internal abstract class Program
{
    static void Main(string[] args)
    {
        var resume = new Resume
        {
            Name = "John Doe"
        };
        var job1 = new Job
        {
            Company = "Company A",
            JobTitle = "Software Engineer",
            StartYear = 2015,
            EndYear = 2018
        };
        var job2 = new Job
        {
            Company = "Company B",
            JobTitle = "Senior Software Engineer",
            StartYear = 2018,
            EndYear = 2021
        };
        resume.Jobs = [job1, job2];

        Console.WriteLine($"Name: {resume.Name}");
        Console.WriteLine("Jobs:");
        resume.Display();
    }
}

internal class Job
{
    public string Company { get; init; }
    public string JobTitle { get; init; }
    public int StartYear { get; init; }
    public int EndYear { get; init; }

    public void Display()
    {
        Console.WriteLine($"{JobTitle} ({Company}) {StartYear} - {EndYear}");
    }
}

internal class Resume
{
    public string Name { get; set; }
    public List<Job> Jobs { get; set; }


    public void Display()
    {
        Jobs.ForEach(job => job.Display());
    }
}