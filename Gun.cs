
namespace Gun
{

    class Gun
    {
        private bool isLoaded;

        private void Reload()

        {
            Console.WriteLine("Reloading...");

            isLoaded = true;

            Console.WriteLine("Reloaded!");
        }

        public void Shoot()
        {
            if (isLoaded)
            {
                Console.WriteLine("Gun isn't reloaded!");
                Reload();
            }

            Console.WriteLine("Shoot - Shoot\n");
            isLoaded= false;
        }

    }


    class Program
    {


        static void Main(string[] args)
        {
            Gun gun = new Gun();
            gun.Shoot();
        }
    }


}
