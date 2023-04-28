using System.Net.WebSockets;

namespace WorkWithList
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var cars = new Cars<string>() { "Fiat", "GMC", "MG" };

            cars.Add("Tesla");
            cars.Add("Jeep");
            cars.Add("Ford");
            cars.Add("Audi");

            cars.AddRange(new string[] { "Bentley", "Bugatti", "Ducati", "Lamborghini", "Seat", "MAN", "Scania", "Skoda", "Porsche", "Volkswagen" });

            cars.Remove("Audi");
            Console.WriteLine(cars.IsRemoved);
            cars.RemoveAt(2);

            cars.Sort();

            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }

            var userCollection = new Cars<JapaneseCars>();
            var toyota = new JapaneseCars() { Name = "Toyota" };
            userCollection.Add(new JapaneseCars() { Name = "Subaru" });
            userCollection.Add(toyota);
            userCollection.Add(new JapaneseCars() { Name = "Nissan" });
            userCollection.Add(new JapaneseCars() { Name = "Daihatsu" });

            var array = new JapaneseCars[2]
            {
                new JapaneseCars() { Name = "Acura"},
                new JapaneseCars() { Name = "Honda"}
            };

            userCollection.AddRange(array);

            userCollection.Remove(toyota);
            userCollection.RemoveAt(1);

            userCollection.Sort();

            foreach (var car in userCollection)
            {
                Console.WriteLine(car);
            }

            Console.WriteLine();
        }
    }
}