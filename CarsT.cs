using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithList
{
    public class CarsT<T>
    {
        private T[] _cars;
        private int _counter = 0;
        private int _i = 0;

        public void Add(T item)
        {
            _counter++;
            Array.Resize(ref _cars, _counter);
            _cars[_i] = item;
            _i++;
        }

        public void AddRange(ICollection<T> items)
        {
            foreach (T item in items)
            {
                _counter++;
                Array.Resize(ref _cars, _counter);
                _cars[_i] = item;
                _i++;
            }

            string[] arr = new string[] { "arr", "arr1" };
            var a = _cars.GetType();
            Console.WriteLine(a);
            Console.WriteLine(arr.GetType());
        }

    }
}
