using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EnumeratorDemo
{
    /// <summary>
    /// foreach使用，并不要求一定要实现 IEnumerable<T> 或IEnumerable
    /// 编译器如果没有找到IEnumerable<T> 或IEnumerable，那么就会找GetEnumerator方法
    /// Duck Tying
    /// </summary>
    /// <typeparam name="T"></typeparam>

    public class MyList<T>
    {
        List<T> _list = new List<T>();
        private int _currentIndex = 0;
        public void Add(T element)
        {
         _list.Add(element);   
        }
        public IEnumerator<T> GetEnumerator()
        {
            return new Enumerator<T>(this);
        }

        public T this[int index]
        {
            get
            {
                return _list[index];
            }
            set { _list[index] = value; }
        }

        public int Count
        {
            get { return _list.Count; }
        }
        private class Enumerator<T> : IEnumerator<T>
        {
            private MyList<T> _myList;
            private int _currentIndex;
            public Enumerator(MyList<T> mylist)
            {
                _myList = mylist;
                _currentIndex = 0;
            }
            public void Dispose()
            {
                Console.WriteLine("释放资源");
            }

            public bool MoveNext()
            {
                return _currentIndex < _myList.Count;
            }

            public void Reset()
            {
                _currentIndex = 0;
            }

            public T Current 
            {
                get
                {
                    return _myList[_currentIndex++];
                } 
                
            }

            object IEnumerator.Current
            {
                get { return Current; }
            }
        }
    }
    class Program
    {
        public static void TestDuckTyping()
        {
            MyList<int> intList = new MyList<int>();
            for (int i = 1; i < 5; i++)
            {
                intList.Add(i);
            }

            foreach (var element in intList)
            {
                Console.WriteLine(element);
            }
        }

        static void Main(string[] args)
        {
            Stack<int> intStack = new Stack<int>();
            int[] arr = new[] { 1, 2, 3, 4, 5 };
            foreach (var i in arr)
            {
                intStack.Push(i);
            }

            Stack<int>.Enumerator enumerator = intStack.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }

            TestDuckTyping();


        }
    }
}
