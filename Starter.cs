﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithList
{
    public class Starter
    {
        private string[] _starterArr;
        private List<string> _allCarsList;

        public Starter()
        {
            _starterArr = new string[] { "Ford", "Cadilac", "Tesla", "Jeep" };
            _allCarsList = new List<string>();
        }

        public void Run()
        {
            Services services = new Services();

            AddCarsToList(_starterArr);

            services.DisplayInfo(_starterArr);

            _allCarsList.AddRange(VolkswagenAG.VolkswagenList());

            _allCarsList.Sort();
            services.DisplayInfo(_allCarsList);

            Console.WriteLine("What car need to delete from list? Enter car name: ");

            var result = services.RemoveItem(_allCarsList);
            Console.WriteLine($"Delete item status: {result}\n");
            services.DisplayInfo(_allCarsList);

            services.RemoveItemByIndex(_allCarsList);

            Cars cars = new Cars(_allCarsList);
            services.DisplayInfo(cars);
        }

        private void AddCarsToList(string[] cars)
        {
            foreach (var item in _starterArr)
            {
                _allCarsList.Add(item);
            }
        }
    }
}
