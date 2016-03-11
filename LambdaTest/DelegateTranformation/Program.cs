using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DelegateTranformation
{
    public delegate int MyDelegate(int i);
    public delegate int MyDelegate2(int i);
    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate d = (i) => i + 10;
            MyDelegate2 d2 = d.Invoke;
            Console.WriteLine(d2.Invoke(10));
            Action<object> objectAction = (obj) =>
            {
                Console.WriteLine(obj);
            };

            Action<string> stringAction = objectAction;
            stringAction.Invoke("aa");
        }
    }
}
