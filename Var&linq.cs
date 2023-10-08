

// var and linq

class Program
{
    static void Main(string[] args)
    {

        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        var result = from i in numbers where i > 5 select i;

        foreach (var item in result)
        {
            Console.Write($"{item}\t");
        }

        Console.WriteLine();

        Console.WriteLine($"Type data results {result.GetType()}");
    }
}

