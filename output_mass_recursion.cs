

// output massive with recursion

class Program
{

    static void PrintArray(int[] myArray, int i = 0)
    {
        if (i < myArray.Length)
        {
            Console.WriteLine(myArray[i]);
            PrintArray(myArray, i + 1);
        }
    }

    static void Main(string[] args)
    {
        int[] myArray = { 1, 2, 3 };

        PrintArray(myArray);
    }
}