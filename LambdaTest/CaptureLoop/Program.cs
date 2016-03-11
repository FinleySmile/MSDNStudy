using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CaptureLoopDemo
{
    class CaptureLoop
    {
        /// <summary>
        /// 测试匿名方法捕获循环变量
        /// </summary>
        public void AnonymousMethodCaptureLoop()
        {
            var list = new List<string> {"One","Two","Three"};

            var actions = new List<Action>();
            foreach (var item in list)
            {
                actions.Add(() => { Console.WriteLine(item); });
            }

            foreach (var action in actions)
            {
                action();
            }
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            CaptureLoop instance = new CaptureLoop();
            instance.AnonymousMethodCaptureLoop();

        }
    }
}
