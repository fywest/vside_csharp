using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInterface
{
    public interface IShout
    {
        void Shout();
    }

    class Dog:IShout
    {
        public void Shout()
        {
            Console.WriteLine("This is Dog Shout ");

        }
    }

    public  interface lwc
    {
        void PrintC();
    }

    class MyClass:lwc
    {
        public void PrintC()
        {
            Console.WriteLine("This is MyClass");
        }
    }

    class YourClass : lwc
    {
        public void PrintC()
        {
            Console.WriteLine("This is YourClass");
        }
    }

    class HisClass : lwc
    {
        public void PrintC()
        {
            Console.WriteLine("This is HisClass");
        }
    }

    class Class
    {
        public void WriteClass(lwc item)
        {
            item.PrintC();
            Console.WriteLine("***************");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Shout();

            Class cs = new Class();
            lwc iClass;
            iClass = new MyClass();
            cs.WriteClass(iClass);

 
            iClass = new YourClass();
            cs.WriteClass(iClass);

            iClass = new HisClass();
            cs.WriteClass(iClass);
        }
    }
}
