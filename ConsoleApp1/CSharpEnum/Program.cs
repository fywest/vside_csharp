using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEnum
{
    enum Color
    {
        Red,
        Green,
        Blue
    }



    class Program
    {
        static void PrintColor(Color color)
        {
            switch (color)
            {
                case Color.Red:
                    Console.WriteLine("Red");
                    break;
                case Color.Green:
                    Console.WriteLine("Green");
                    break;
                case Color.Blue:
                    Console.WriteLine("Blue");
                    break;
                default:
                    Console.WriteLine("Unknown color");
                    break;
            }
        }

        static void Main(string[] args)
        {
            Color c = Color.Red;
            PrintColor(c);
            Console.WriteLine($"{(int)(c)}");
            PrintColor(Color.Blue);
            Console.WriteLine($"{(int)(Color.Blue)}");
            Color r = (Color)1;
            PrintColor(r);
        }
    }
}
