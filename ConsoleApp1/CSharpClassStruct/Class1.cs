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
            item = null;
            
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

            
            
        }

        static void Main(string[] args)
        {
            //customClass();//construct person class
            //testPerson();//construct custom class
            workItem();//construct inheritance class


            Console.ReadKey();
        }
    }
}
