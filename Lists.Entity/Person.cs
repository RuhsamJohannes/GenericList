using System;
using System.Collections;

namespace Lists.Entity
{
    public class Person : IComparable
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }

        public int Age { get; set; }

        public int Compare(object x, object y)
        {
            throw new NotImplementedException();
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"{LastName} {FirstName}";
        }

        //nested class z.B. SortAsc
    }
}
