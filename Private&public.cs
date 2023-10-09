
namespace Private{


    class Point
    {
        public int x = 1;

        private int y = 5;

        private void PrintX()
        {
            Console.WriteLine($"X: {x}");
        }

        public void PrintY()
        {
            Console.WriteLine($"Y: {y}");
        }

        public void PrintPoint()
        {
            PrintX();
            PrintY();
        }


        class Program {


            static void Main(string[] args)
            {
                Point point = new Point();

                point.PrintX();

            }
        }


        
    }


}

