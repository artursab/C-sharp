

class Program
{



    static void Main(string[] args)
    {
        byte agression = 1;

        byte democracyModifier = 2;

        try
        {
            agression = checked((byte)(agression - democracyModifier));
            Console.WriteLine(agression);
        }
        catch (OverflowException)
        {

            Console.WriteLine("Overflow!");
        }
    }
}
