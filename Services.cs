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

        public string UserInputCheck()
        {
            // Сделать проверкку на верхний нижний регистр, и тримм пробелы
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

        public void RemoveItem(List<string> cars)
        {
            while (UserInputCheck() == null)
            {
                UserInputCheck();
            }

            if (cars.Remove(_userAnswer))
            {
                Console.WriteLine("Delete sucsefull");
            }
            else
            {
                Console.WriteLine("Delete error");
            }
        }
    }
}
