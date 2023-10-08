

class Program
{


    static void Main(string[] args)
    {

        int? i = null;  

        Console.WriteLine(i == null);   //true

        Console.WriteLine(i.HasValue);  //false

        Console.WriteLine(i.GetValueOrDefault());   // 0

        Console.WriteLine(i.GetValueOrDefault(5));  //5

        Console.WriteLine(i ?? 55); //55

        //Console.WriteLine(i.Value);    //InvalidOperationException

        Console.WriteLine(i);



            
        int a = 5;

        int? b = 22;

        int? result = a + b;

        Console.WriteLine(result);

        Console.WriteLine(a == b);

        Console.WriteLine(a > b);

        Console.WriteLine(a < b);




        int a2 = 5;

        int? b2 = null;

        int? result2 = a + b;

        Console.WriteLine(result2);

        Console.WriteLine(a2 == b2);

        Console.WriteLine(a2 > b2);

        Console.WriteLine(a2 < b2);

    }
}