using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LambdaVariableScope
{
    public delegate bool D();

    public delegate bool D2(int i);


    class Program
    {
        private D del;
        private D2 del2;

        public void TestMethod(int input)
        {
            int j = 0;
            del = () =>
            {
                j = 10;
                return j > input;
            };

            del2 = (x) => x == j;

            Console.WriteLine("before call delegate j = {0}",j);

            bool bResult = del();

            Console.WriteLine("after call del j= {0}, bResult={1}",j,bResult);
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.TestMethod(5);

            bool bResult = p.del2(10);
            Console.WriteLine(bResult);

        }
    }
}
