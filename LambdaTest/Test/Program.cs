using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Test
{
    public delegate int Calculate(int val) ;

    public delegate bool IsGreater(int x, string s);

    public delegate void Output<T>(T obj);
    class Program
    {
        static void Main(string[] args)
        {
            Calculate cal ;
            Console.WriteLine("test---");
            cal = x => x*x;

            Console.WriteLine("test2222---");
            Console.WriteLine(cal(10));

            IsGreater predicate = (int x, string s) => s.Length > x;
            
            Console.WriteLine(predicate(10, "zhangsa"));

            Output<string> output = (str) => { Console.WriteLine(str); };
            output("aaa");


            int[] numbers = { 5, 4, 1, 3, 9, 2, 6, 7, 2, 0 };
            int oddNumbers = numbers.Count(n => n % 2 == 1);
            var oddElements = numbers.Where(x => x%2 == 1);
            Console.WriteLine("odd numbers:{0}",oddNumbers);

            foreach (var element in oddElements)
            {
                Console.Write(element + " " );
            }
            Console.WriteLine();

            var firstNumbersLessThan6 = numbers.TakeWhile(n => n < 6);
            foreach (var element in firstNumbersLessThan6)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();

            var firstSmallNumbers = numbers.TakeWhile((n, index) => {
                                                                        Console.Write("n:{0},index:{1}",n,index);
                                                                       return  n > index; });
            foreach (var element in firstSmallNumbers)
            {
                Console.WriteLine(" " + element );
            }
            Console.WriteLine();
        }
    }
}
