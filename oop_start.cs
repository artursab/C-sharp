
//OOP start

class Point
{
    public int x;
    public int y;
    public Color color;
}

enum Color
{
    Red,
    Green,
    Yellow,
    Blue
}

class Program
{


    static void Main(string[] args)
    {
        Point point = new Point();
        point.x = 1;
        point.y = 2;
        point.color = Color.Red;
        
        Console.WriteLine($"X: {point.x} | Y: {point.y} | Color: {point.color}");

    }
}
