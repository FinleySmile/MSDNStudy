using System;

namespace WhereConstraintTest
{
    public class Person : IComparable<Person>
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public int CompareTo(Person other)
        {
            return Age - other.Age;
        }

        public override string ToString()
        {
            return string.Format("age:{0}, name:{1}", Age, Name);
        }
    }
}