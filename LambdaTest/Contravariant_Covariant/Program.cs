using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Contravariant_Covariant
{

    interface IMyList<in T>
    {
        void Change(T element);
    }

    public class MyList<T> : IMyList<T>
    {
        public void Change(T element)
        {
            
        }
    }

    class Program
    {
        /// <summary>
        /// 测试协变
        /// </summary>
        public static void TestCovariant()
        {
            Dog dog = new Dog();
            Animal animal = dog; //协变
            List<Animal> animalList = new List<Animal>();
            List<Dog> dogAnimal = animalList.Select((d) => (Dog) d).ToList();
        }


        /// <summary>
        /// 测试协变
        /// </summary>
        public static void TestContravariant()
        {
            Dog dog = new Dog();
            Animal animal = dog; //协变
            IMyList<Animal> animalList = new MyList<Animal>();
            IMyList<Dog> dogList = animalList;
        }
        static void Main(string[] args)
        {
            
        }
    }
}
