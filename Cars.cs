using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithList
{
    public class Cars<T>
    {
        private T[] _carsList;
        private int _counter = 0;
        private int _i = 0;

        public void Add(T item)
        {
            _counter++;
            Array.Resize(ref _carsList, _counter);
            _carsList[_i] = item;
            _i++;
        }

        public void AddRange(ICollection<T> items)
        {
            foreach (T item in items)
            {
                _counter++;
                Array.Resize(ref _carsList, _counter);
                _carsList[_i] = item;
                _i++;
            }
        }

        public void Remove(T item)
        {
            int index = 0;
            for (int i = 0; i < _carsList.Length; i++)
            {
                if (item.Equals(_carsList[i]))
                {
                    RemoveAt(i);
                }
            }
        }

        public void RemoveAt(int index)
        {
            T[] temp = new T[_carsList.Length - 1];
            for (int i = 0; i < _carsList.Length; i++)
            {
                if (i == index)
                {
                    break;
                }
                else
                {
                    temp[i] = _carsList[i];
                }
            }

            for (int i = index; i < _carsList.Length - 1; i++)
            {
                temp[i] = _carsList[i + 1];
            }

            _carsList = temp;
        }
    }
}
