namespace Assignment;

class Program
{
    public static void Main(string[] args)
    {
        var result = ConsoleRunner.Run(1100);
        Console.WriteLine("Number of PLCs in RUN mode: " + result);
    }
}