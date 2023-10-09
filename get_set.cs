
namespace sharp{


    class Point
    {
        private int x;

        public void SetX(int x) 
        {
            if (x < 1)
            {
                this.x = 1;
                return;
            }
            if (x> 5)
            {
                this.x = 5;
                return;
            }

            this.x = x;
        }


        private int y;

        public void SetY(int y)
        {
            if (y < 1)
            {
                this.y = 1;
                return;
            }
            if (y > 5)
            {
                this.y = 5;
                return;
            }

            this.y = x;
        }


        public int z { get; set; }


    }


    class Program
    {


        static void Main(string[] args)
        {
            Point point = new Point();

            point.z = 1;

            int z = point.z;

        }
    }

}