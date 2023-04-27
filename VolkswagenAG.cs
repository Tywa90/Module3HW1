using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithList
{
    public class VolkswagenAG
    {
        public static IReadOnlyCollection<string> VolkswagenList()
        {
            return new List<string> { "Volkswagen", "Audi", "SEAT", "Skoda", "Bentley", "Bugatti", "Lamborghini", "Porsche", "Scania", "MAN" };
        }
    }
}
