class Program
{

    enum Colors
    {
        White,
        Red, 
        Green,
        Yellow,
        Orange
    }


    enum DayOfWeek
    {
        Monday =1,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    static void Main(string[] args)
    {

        //key
        while (true)
        {
            ConsoleKey key = Console.ReadKey().Key;

            int keyCode = (int)key;

            Console.WriteLine($"\tEnum {key} \tKey Code {keyCode}");

            if (key == ConsoleKey.Enter)
            {
                Console.WriteLine("U pressed Enter!");
            }
        }



        //Day Of Week
        
            DayOfWeek dayOfWeek = DayOfWeek.Friday;

            Console.WriteLine(Enum.GetUnderlyingType(typeof(DayOfWeek)));  //type

            Console.WriteLine(dayOfWeek);

            Console.WriteLine((int)dayOfWeek);  //DayOfWeek to int

            Console.WriteLine((DayOfWeek)3);    //int tp DayOfWeek

            DayOfWeek nextDay = GetNextDay(dayOfWeek);
            Console.WriteLine(nextDay);

            static DayOfWeek GetNextDay(DayOfWeek day)
            {
                if (day < DayOfWeek.Sunday)
                {
                    return day + 1;
                }
                return DayOfWeek.Monday;
            }
        
      


        //days of week with value = 55;

        int value = 55;

        if (Enum.IsDefined(typeof(DayOfWeek), value))
        {
            dayOfWeek = (DayOfWeek)value;
        }
        else
        {
            throw new Exception("Invalid Day Of Week value");
        }
        Console.WriteLine(dayOfWeek);


        //Colors
        var values = Enum.GetValues(typeof(Colors));

        foreach (var item in values)
        {
            Console.WriteLine(item);
        }


        //Colors parse
        string str = Console.ReadLine();

        Colors color = (Colors)Enum.Parse(typeof(Colors), str, ignoreCase: true);

        Console.WriteLine(color);


        //Colors switch
        switch (color)
        {
            case Colors.White:
                break;

            case Colors.Red:
                break;
            case Colors.Green:
                break;
            case Colors.Yellow:
                break;
            case Colors.Orange:
                break;
        }
    }
}