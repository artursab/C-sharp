


using System.ComponentModel.DataAnnotations;

namespace Car_oop
{

    class Car
    {

        private int speed = 0;

        public void PrintSpeed()
        {
            if (speed == 0)
            {
                Console.WriteLine("Car stay");
            }
            if (speed > 0)
            {
                Console.WriteLine($"Riding forward with {speed} km/h");
            }
            if (speed < 0)
            {
                Console.WriteLine($"Riding back with {speed} km/h");
            }
        }

        public void DriveForward()
        {
            speed = 60;
        }

        public void Stop()
        {
            speed = 0;
        }

        public void DriveBackward()
        {
            speed = -5;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t== Car 1 ==");
            var car = new Car();
            car.PrintSpeed();
            car.DriveForward();
            car.Stop();
            car.DriveBackward();
            car.PrintSpeed();

            Console.WriteLine("\t== Car 2 ==");
            var car2 = new Car();
            car2.PrintSpeed();
            car2.DriveForward();
            car2.Stop();
            car2.DriveBackward();
            car2.PrintSpeed();
        }
    }
}