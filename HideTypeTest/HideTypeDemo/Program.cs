using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HideTypeDemo
{
    class Program
    {
        /// <summary>
        /// Test方法中MSIL生成生成两个匿名类
        /// </summary>
        public static void Test()
        {
            var t1 = new { Name = "zhangsan", Year = 21 };
            var t2 = new { Name = "lisi", Year = 11 };
            var t3 = new { Name = "wang", BirthYear = t2.Year };

            Console.WriteLine("Name:{0}, Year:{1}", t1.Name, t1.Year);
            Console.WriteLine("Name:{0}, Year:{1}", t2.Name, t2.Year);
            Console.WriteLine("Name:{0}, BirthYear:{1}", t1.Name, t3.BirthYear);
        }

        /// <summary>
        /// Test方法中MSIL生成生成三个匿名类.
        ///  两个匿名类要想在同一程序集类型兼容，必须要求属性名，数据类型，属性顺序都完全匹配
        /// </summary>
        public static void Test2()
        {
            var t1 = new { Name = "zhangsan", Year = 21 };
            var t2 = new {  Year = 11,Name = "lisi" }; // t1 t2 属性声明顺序不一致，编译器生成MSIL 时，生成两个不同的匿名类
            var t3 = new { Name = "wang", BirthYear = t2.Year };

            Console.WriteLine("Name:{0}, Year:{1}", t1.Name, t1.Year);
            Console.WriteLine("Name:{0}, Year:{1}", t2.Name, t2.Year);
            Console.WriteLine("Name:{0}, BirthYear:{1}", t1.Name, t3.BirthYear);
        }


        static void Main(string[] args)
        {
            var t1 = new {Name = "zhangsan", Year = 21 };
            var t2 = new {Name = "lisi", Year = 11};
            var t3 = new {Name = "wang", BirthYear = t2.Year};

            Console.WriteLine("Name:{0}, Year:{1}",t1.Name,t1.Year);
            Console.WriteLine("Name:{0}, Year:{1}", t2.Name, t2.Year);
            Console.WriteLine("Name:{0}, BirthYear:{1}", t1.Name, t3.BirthYear);

            Console.WriteLine(t3);
        }
    }
}
