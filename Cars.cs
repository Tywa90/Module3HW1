using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithList
{
    public class Cars : IEnumerable<string>
    {
        public List<string> FinalCarsList { get; }
        public Cars(List<string> finalList)
        {
            FinalCarsList = finalList;
        }

        public IEnumerator<string> GetEnumerator()
        {
            return new CarsEnumerator(FinalCarsList);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
