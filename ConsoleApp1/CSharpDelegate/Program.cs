using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDelegate
{
    delegate double Function(double x);

    class Multiplier
    {
        double factor;
        public Multiplier(double factor)
        {
            this.factor = factor;
        }
        public double Multiply(double x)
        {
            return x * factor;
        }
    }

    class Program
    {
        static double Square(double x)
        {
            return x * x;
        }
        static double[] Apply(double[] a, Function f)
        {
            double[] result = new double[a.Length];
            for (int i = 0; i < a.Length; i++) result[i] = f(a[i]);
            return result;
        }

        static void Main(string[] args)
        {
            double[] a = { 0.0, 0.5, 1.0 };
            Console.WriteLine($"{a[0]} {a[1]} {a[2]}");
            double[] squares = Apply(a, Square);
            Console.WriteLine($"{squares[0]} {squares[1]} {squares[2]}");
            double[] sines = Apply(a, Math.Sin);
            Console.WriteLine($"{sines[0]} {sines[1]} {sines[2]}");
            Multiplier m = new Multiplier(2.0);
            double[] doubles = Apply(a, m.Multiply);
            Console.WriteLine($"{doubles[0]} {doubles[1]} {doubles[2]}");
        }
    }
}
