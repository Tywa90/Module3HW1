using System.Net.WebSockets;

namespace WorkWithList
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Starter starter = new Starter();
            // starter.Run();
            var cars = new CarsT<string>();

            cars.Add("Tesla");
            cars.Add("Jeep");
            cars.Add("Ford");
            cars.Add("Audi");

            cars.AddRange(new string[] { "Subaru", "Toyota", "Nissan", "MAN", "SEAT", "Skoda", "Bentley", "Bugatti", "Lamborghini" });


        }
    }
}