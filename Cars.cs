using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithList
{
    public class Cars<T> : IEnumerable
        where T : IComparable<T>
    {
        private const int StartCapacity = 10;
        private const int Resize = 2;
        private T[] _carsList;
        private int _length;
        private bool _isRemoved;

        public Cars()
        {
            _carsList = new T[StartCapacity];
            _length = 0;
        }

        public bool IsRemoved
        {
            get
            {
                return _isRemoved;
            }
        }

        public void Add(T item)
        {
            if (_length >= _carsList.Length)
            {
                Array.Resize(ref _carsList, _carsList.Length * Resize);
            }

            _carsList[_length] = item;
            _length++;
        }

        public void AddRange(IEnumerable<T> items)
        {
            foreach (var item in items)
            {
                Add(item);
            }
        }

        public void Remove(T item)
        {
            int index = -1;
            for (int i = 0; i < _carsList.Length; i++)
            {
                if (item.Equals(_carsList[i]))
                {
                    index = i;
                    break;
                }
            }

            if (index < 0 || index >= _length)
            {
                _isRemoved = false;
            }
            else
            {
                RemoveAt(index);
                _isRemoved = true;
            }
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= _length)
            {
                Console.WriteLine("RemoveAt index is not correct");
                return;
            }

            for (int i = 0; i < _carsList.Length; i++)
            {
                if (i == index)
                {
                    break;
                }
            }

            for (int i = index; i < _carsList.Length - 1; i++)
            {
                _carsList[i] = _carsList[i + 1];
            }

            _length--;
        }

        public void Sort()
        {
            Array.Sort(_carsList, 0, _length);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new CarsEnumerator<T>(_carsList, _length);
        }
    }
}
