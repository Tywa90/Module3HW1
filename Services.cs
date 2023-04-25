using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithList
{
    public class Services
    {
        public void DisplayInfo(string[] cars)
        {
            foreach (var item in cars)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------");

        }

        public void DisplayInfo(List<string> cars)
        {
            foreach (var item in cars)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"Count: {cars.Count}");
            Console.WriteLine($"Capacity: {cars.Capacity}");
            Console.WriteLine("------------");
        }

        public string UserInputCheck()
        {
            string? userString = Console.ReadLine();
            if (!string.IsNullOrEmpty(userString) && !string.IsNullOrWhiteSpace(userString))
            {
                return userString;
            }
            else
            {
                Console.WriteLine("Try again");
                return null;
            }
        }
    }
}
