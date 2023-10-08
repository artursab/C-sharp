class Program
{


    static void Main(string[] args)
    {
        int a = int.MaxValue;
        a = a + 1;   //overflow through the upper bound
        Console.WriteLine(a);

        int b = int.MaxValue;
        b = b - 1;  //overflow through the lower bound
        Console.WriteLine(b);



        double d = 1.0 / 0.0;
        Console.WriteLine(double.IsInfinity(a));  //output: True

        double c = 0.0 / 0.0;
        Console.WriteLine(double.IsNaN(c)); //output: True

        double e = double.MaxValue + double.MaxValue; 
        Console.WriteLine(double.IsInfinity(e));       //output: True



        decimal i = decimal.MaxValue;
        decimal j = decimal.MaxValue;
        decimal z = unchecked(i + j);   //decimal is exact data type


    }
}