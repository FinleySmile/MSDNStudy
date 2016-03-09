using System;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhereConstraintTest
{
    class Program
    {
        public static bool OpTest<T>(T t1, T t2) where T : class
        {
            return t1 == t2;
        }

        static void Main(string[] args)
        {

            int[] ages = {21, 23, 43, 12, 45};
            string[] names = {"zhangsna", "lisi", "wangwu", "jack", "marry"};
            SortedList<Person> personSortedList = new SortedList<Person>();

            for (int i = 0; i < ages.Length; ++i)
            {
                personSortedList.AddHead(new Person {Age = ages[i],Name=names[i]});
            }
            personSortedList.BubbleSort();

            //output person
            foreach (var person in personSortedList)
            {
                Console.WriteLine(person);    
            }
            

        }
    }
}
