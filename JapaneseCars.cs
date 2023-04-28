using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithList
{
    public class JapaneseCars : IComparable<JapaneseCars>
    {
        public string Name { get; set; }

        public int CompareTo(JapaneseCars? other)
        {
            return Name.CompareTo(other.Name);
        }
    }
}
