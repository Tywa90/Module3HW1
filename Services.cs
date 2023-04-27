using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithList
{
    public class Services
    {
        private string _userAnswer;
        public void DisplayInfo(string[] cars)
        {
            IEnumerator carsEnumerator = cars.GetEnumerator();
            while (carsEnumerator.MoveNext())
            {
                string item = (string)carsEnumerator.Current;
                Console.WriteLine(item);
            }
            carsEnumerator.Reset();

            Console.WriteLine("------------");
        }

        public void DisplayInfo(List<string> cars)
        {
            IEnumerator carsEnumerator = cars.GetEnumerator();
            while (carsEnumerator.MoveNext())
            {
                string item = (string)carsEnumerator.Current;
                Console.WriteLine(item);
            }
            carsEnumerator.Reset();

            Console.WriteLine($"Count: {cars.Count}");
            Console.WriteLine($"Capacity: {cars.Capacity}");
            Console.WriteLine("------------");
        }

        public void DisplayInfo(Cars cars)
        {
            foreach(var car in cars)
            {
                Console.WriteLine(car);
            }

            Console.WriteLine($"Count: {cars.FinalCarsList.Count}");
            Console.WriteLine($"Capacity: {cars.FinalCarsList.Capacity}");
            Console.WriteLine("------------");
        }

        public bool RemoveItem(List<string> cars)
        {
            while (UserInputCheck() == null)
            {
                UserInputCheck();
            }

            var result = cars.Remove(_userAnswer);
            return result;
        }

        public string UserInputCheck()
        {
            string? userString = Console.ReadLine();

            if (!string.IsNullOrEmpty(userString) && !string.IsNullOrWhiteSpace(userString))
            {
                _userAnswer = userString.Trim();
                return userString;
            }
            else
            {
                Console.WriteLine("Try again");
                return null;
            }
        }

        public void RemoveItemByIndex(List<string> cars)
        {
            Console.WriteLine("Enter the index of item to delete: ");
            int number = -1;
            while (true)
            {
                string text = Console.ReadLine();
                if (int.TryParse(text, out number))
                {
                    break;
                }
                Console.WriteLine("Сan't recognize the number. Try again");
            }

            if (number >= 0 && number <= cars.Count)
            {
                Console.WriteLine($"{cars[number]} was deleted from list\n");
                cars.RemoveAt(number);
            }
            else
            {
                Console.WriteLine("Out of index range in cars list\n");
            }

        }

    }
}
