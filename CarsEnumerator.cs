using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithList
{
    public class CarsEnumerator : IEnumerator<string>
    {
        private List<string> _cars;
        private int position = -1;

        public CarsEnumerator(List<string> cars) => _cars = cars;

        public string Current
        {
            get
            {
                if (position == -1 || position >= _cars.Count)
                {
                    throw new ArgumentException();
                }

                return _cars[position];
            }
        }

        object IEnumerator.Current => Current;

        public bool MoveNext()
        {
            if (position < _cars.Count - 1)
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
