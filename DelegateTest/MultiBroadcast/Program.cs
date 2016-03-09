using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MultiBroadcast
{
    public delegate void DelegateMethod(string message);
    public delegate void DelegateMethod2(string message);
    public class MethodClass
    {
        public void Method1(string message)
        {
            Console.WriteLine("Method1:{0}",message);
            throw new Exception("sss");
        }

        public void Method2(string message)
        {
            Console.WriteLine("Method2:{0}",message);
        }

        public static void StaticMethod(string message)
        {
            Console.WriteLine("StaticMethod:{0}",message);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var instance = new MethodClass();
            DelegateMethod d1 = instance.Method1;
            DelegateMethod d2 = instance.Method2;
            Console.WriteLine("d1 invocation length:{0}", d1.GetInvocationList().GetLength(0));
            DelegateMethod staticDelegateMethod = MethodClass.StaticMethod;

            DelegateMethod allDelegateMethod = d1 + d2;
            allDelegateMethod += staticDelegateMethod;

            int length = allDelegateMethod.GetInvocationList().GetLength(0);
            Console.WriteLine("length:{0}",length);
            allDelegateMethod.Invoke("hello");



        }
    }
}
