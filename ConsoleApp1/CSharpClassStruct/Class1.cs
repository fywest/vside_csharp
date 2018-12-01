using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpClassStruct
{
    public class CustomClass
    {
        public int Number { get; set; }

        public int Multiply(int num)
        {
            return num * Number;
        }

        public CustomClass()
        {
            Number = 0;
        }
    }

    public class Person
    {
        // Constructor that takes no arguments:
        public Person()
        {
            Name = "unknown";
        }

        // Constructor that takes one argument:
        public Person(string name)
        {
            Name = name;
        }

        // Auto-implemented readonly property:
        public string Name { get; }

        // Method that overrides the base class (System.Object) implementation.
        public override string ToString()
        {
            return Name;
        }
    }

    public class WorkItem
    {
        private static int currentID;

        protected int ID { get; set; }
        protected string Title { get; set; }
        protected string Description { get; set; }
        protected TimeSpan jobLength { get; set; }

        public WorkItem()
        {
            ID = 0;
            Title = "Default title";
            Description = "Default Description";
            jobLength = new TimeSpan();
        }

        public WorkItem(string title,string desc,TimeSpan joblen)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.Description = desc;
            this.jobLength = joblen;
            
        }

        static WorkItem()
        {
            currentID = 0;
        }

        protected int GetNextID()
        {
            return ++currentID;
        }

        public void Update(string title,TimeSpan joblen)
        {
            this.Title = title;
            this.jobLength = joblen;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - {2}", this.ID, this.Title,this.jobLength);
        }

        ~WorkItem()
        {
            --currentID;
            Console.WriteLine("It is destoried");
        }
    }

    public class ChangeRequest:WorkItem
    {
        protected int originalItemID { get; set; }
        public ChangeRequest() { }

        public ChangeRequest(string title,string desc,TimeSpan joblen,int originalID)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.Description = desc;
            this.jobLength = joblen;

            this.originalItemID = originalID;
        }
    }

    public class Shape
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Height { get; set; }
        public int Width { get; set; }

        public virtual void Draw()
        {
            Console.WriteLine("Peforming base class drawing tasks");
        }
        public void set_X_Y(int x,int y)
        {
            this.X = x;
            this.Y = y;
        }
    }
    class Circle:Shape
    {
        public override void Draw()
        {
            
            Console.WriteLine("Drawing a circle");
            //base.Draw();
        }
        public override string ToString()
        {
            return String.Format("{0} - {1} - {2} - {3}", this.X, this.Y, this.Height,this.Width);
        }
    }
    class Rectangle:Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a rectangle");
            //base.Draw();

        }
    }
    class Triangle:Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a triangle");
            //base.Draw();
        }

    }

    namespace OverrideAndNew
    {
        class BaseClass
        {
            public virtual void Method1()
            { Console.WriteLine("Base - Method1"); }

            public virtual void Method2()
            { Console.WriteLine("Base - Method2"); }
        }

        class DerivedClass:BaseClass
        {
            public override void Method1()
            { Console.WriteLine("Derived - Method1"); }

            public new void Method2()
            { Console.WriteLine("Derived - Method2"); }
        }

        public class Program
        {
            public static void baseDerived()
            {
                BaseClass bc = new BaseClass();
                DerivedClass dc = new DerivedClass();
                BaseClass bcdc = new DerivedClass();

                bc.Method1();
                bc.Method2();

                dc.Method1();
                dc.Method2();

                bcdc.Method1();
                bcdc.Method2();

                var tests = new List<BaseClass> { bc, dc, bcdc };
                Console.WriteLine("----------");
                foreach(var test in tests)
                { test.Method1();test.Method2(); }
                Console.WriteLine("----------");
            }
        }

    }

    namespace TemperatureConverter
    {
        public static class TemperatureConverter
        {
            public static double CelsiusToFahrenheit(string temperatureCelsius)
            {
                double celsius = Double.Parse(temperatureCelsius);
                double fahrenheit = (celsius * 9 / 5) + 32;

                return fahrenheit;
            }


            public static double FahrenheitToCelsius(string temperatureFahrenheit)
            {
                double fahrenheit = Double.Parse(temperatureFahrenheit);
                double celsius = (fahrenheit - 32) * 5 / 9;

                return celsius;
            }
        }

        class TestTemperatureConverter
        {
            public static void test()
            {
                Console.WriteLine("Please select the convertor direction");
                Console.WriteLine("1. From Celsius to Fahrenheit.");
                Console.WriteLine("2. From Fahrenheit to Celsius.");
                Console.Write(":");

                string selection = Console.ReadLine();
                double F, C = 0;

                switch (selection)
                {
                    case "1":
                        Console.Write("Please enter the Celsius temperature: ");
                        F = TemperatureConverter.CelsiusToFahrenheit(Console.ReadLine());
                        Console.WriteLine("Temperature in Fahrenheit: {0:F2}", F);
                        break;

                    case "2":
                        Console.Write("Please enter the Fahrenheit temperature: ");
                        C = TemperatureConverter.FahrenheitToCelsius(Console.ReadLine());
                        Console.WriteLine("Temperature in Celsius: {0:F2}", C);
                        break;

                    default:
                        Console.WriteLine("Please select a convertor.");
                        break;
                }

            }
        }
    }
    class Program
    {
        static void customClass()
        {
            CustomClass custClass = new CustomClass();
            custClass.Number = 27;
            int result = custClass.Multiply(4);
            Console.WriteLine($"The result is {result}");
        }

        static void testPerson()
        {
            var person1 = new Person();
            Console.WriteLine(person1.Name);

            var person2 = new Person("Sarah Jones");
            Console.WriteLine(person2.Name);
            Console.WriteLine(person2);
        }

        static void workItem()
        {

            WorkItem item = new WorkItem("Fix Bugs",
                                         "Fix all bugs in my code branch",
                                         new TimeSpan(3, 4, 0, 0));

            ChangeRequest change = new ChangeRequest("Change Base Class Design",
                                                     "Add members to the class",
                                                     new TimeSpan(4, 0, 0),
                                                     1);

            Console.WriteLine(item.ToString());
            Console.WriteLine(change.ToString());

            change.Update("Change the Design of the Base Class",
                new TimeSpan(4, 0, 0));

            Console.WriteLine(change.ToString());
            //delete item instance
            //item = null;
            
            //trial
            WorkItem item1 = new WorkItem("trial Fix Bugs",
                             "Fix all bugs in my code branch",
                             new TimeSpan(3, 4, 0, 0));

            ChangeRequest change1 = new ChangeRequest("trial Change Base Class Design",
                                                     "Add members to the class",
                                                     new TimeSpan(4, 0, 0),
                                                     1);

            Console.WriteLine(item1.ToString());
            Console.WriteLine(change1.ToString());
            if(item.Equals(item1))
            {
                Console.WriteLine("item is same as item1");

            }
            else
            {
                Console.WriteLine("item is difference with item1");
            }
            
            
        }

        static void shape()
        {
            var shapes = new List<Shape>
            {
                new Circle(),
                new Rectangle(),
                new Triangle()
               
            };
            shapes[0].Width = 30;
            shapes[0].Height = 40;
            shapes[0].set_X_Y(10, 15);
            Console.WriteLine(shapes[0]);
            foreach(var shape in shapes)
            {
                shape.Draw();
            }
            
        }


        static void Main(string[] args)
        {
            //customClass();//construct person class
            //testPerson();//construct custom class
            //workItem();//construct inheritance class
            //shape();//Polymorphism usage
            //OverrideAndNew.Program.baseDerived();//base and derived class
            TemperatureConverter.TestTemperatureConverter.test();//static class

            Console.ReadKey();
        }
    }
}
