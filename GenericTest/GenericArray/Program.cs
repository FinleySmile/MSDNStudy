using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericArray
{
    class Program
    {
        public static void ProcessItems<T>(IList<T> items )
        {
            Console.WriteLine("Items are ReadOnly:{0}",items.IsReadOnly);

            items.RemoveAt(0);
        }
        static void Main(string[] args)
        {
            int[] intArr = {1, 2, 3, 4, 5};
            List<int> intList = new List<int>();
            for (int i = 1; i <= 5; ++i)
            {
                intList.Add(i);
            }

          //  ProcessItems(intArr);
            ProcessItems(intList);

        }
    }
}
