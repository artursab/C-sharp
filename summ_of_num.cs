class Program
{

    static int Foo(int value)
    {
        int result = 0;

        while (value > 0)
        {
            result += value % 10;
            value /= 10;
        }
        return result;
    }


    static void Main(string[] args)
    {
        int myValue = 561;
        int result = Foo(myValue);
    }
}