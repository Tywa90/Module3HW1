using System;
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
                    //Console.WriteLine("Вы ввели число {0}", number);
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
                Console.WriteLine("Out of index range in cars list");
            }

        }
    }
}
