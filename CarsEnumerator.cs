using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithList
{
    public class CarsEnumerator<T> : IEnumerator
    {
        private T[] _cars;
        private int _length;
        private int position = -1;
        public CarsEnumerator(T[] array, int length)
        {
            _cars = array;
            _length = length;
        }

        public T Current
        {
            get
            {
                if (position == -1 || position >= _length)
                {
                    throw new ArgumentException();
                }

                return _cars[position];
            }
        }

        object IEnumerator.Current => Current;

        //string IEnumerator<string>.Current => throw new NotImplementedException();

        public bool MoveNext()
        {
            if (position < _length - 1)
            {
                position++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Reset() => position = -1;
        public void Dispose()
        {
        }
    }
}
