
namespace Gun
{

    class Gun
    {

        public Gun(bool isLoaded)
        {
            _isLoaded = isLoaded;
        }

        private bool _isLoaded;

        private void Reload()

        {
            Console.WriteLine("Reloading...");

            _isLoaded = true;

            Console.WriteLine("Reloaded!");
        }

        public void Shoot()
        {
            if (_isLoaded)
            {
                Console.WriteLine("Gun isn't reloaded!");
                Reload();
            }

            Console.WriteLine("Shoot - Shoot\n");
            _isLoaded= false;
        }

    }


    class Program
    {


        static void Main(string[] args)
        {
            Gun gun = new Gun(isLoaded: true);
            gun.Shoot();
        }
    }


}
