using System;
using System.Collections;

namespace Lists.Entity
{
    public class Person : IComparable
        {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int Age { get; set; }

        public Person(string firstname, string lastname, int age)
        {
            LastName = lastname;
            FirstName = firstname;
            Age = age;
        }

        public int CompareTo(object obj)
        {
            Person p = (Person)obj;
            return this.LastName.CompareTo(p.LastName);
        }

        public override string ToString()
        {
            return $"{LastName} {FirstName}";
        }

        private class SortByFirstNameHelperAsc : IComparer
        {
            int IComparer.Compare(object x, object y)
            {
                Person p1 = (Person)x;
                Person p2 = (Person)y;
                int res = 0;

                if(p1.FirstName.CompareTo(p2.FirstName) == 1)
                {
                    res = 1;
                }
                else if(p1.FirstName.CompareTo(p2.FirstName) == -1)
                {
                    res = -1;
                }

                return res;
            }
        }
        private class SortByAgeHelperDsc : IComparer
        {
            int IComparer.Compare(object x, object y)
            {
                Person p1 = (Person)x;
                Person p2 = (Person)y;
                int res = 0;

                if(p1.Age.CompareTo(p2.Age) == 1)
                {
                    res = -1;
                }
                else if(p1.Age.CompareTo(p2.Age) == -1)
                {
                    res = 1;
                }
                return res;
            }
        }

        public static IComparer SortByAgeDsc()
        {
            return (IComparer) new SortByAgeHelperDsc();
        }

        public static IComparer SortByFirstnameAsc()
        {
            return (IComparer) new SortByFirstNameHelperAsc();
        }
    }
}
