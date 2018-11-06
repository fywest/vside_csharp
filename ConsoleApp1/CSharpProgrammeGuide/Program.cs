using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammeGuide
{
    public delegate void Del(string message);


    class Hello
    {
        public static void DelMethod(string str)
        {
            Console.WriteLine("DelMethod argument:{0}", str);
        }

        static void delegate_test()
        {
            Del exampleDel2 = DelMethod;

            Del exampleDel1 = new Del(DelMethod);
            // Console.WriteLine(exampleDel1);
            exampleDel1("del here");

        }

        static void commandLine(string[] args)
        {
            // The Length property provides the number of array elements
            System.Console.WriteLine("parameter count = {0}", args.Length);

            for (int i = 0; i < args.Length; i++)
            {
                System.Console.WriteLine("Arg[{0}] = [{1}]", i, args[i]);
            }

            foreach (string s in args)
            {
                System.Console.WriteLine(s);
            }
        }

        static void array_queryExpression()
        {
            int[] scores = new int[] { 97, 92, 81, 60 };

            IEnumerable<int> scoreQuery =
                from score in scores
                where score > 80
                select score;

            //foreach(int item in scores)
            //{
            //    Console.WriteLine(item);
            //}
            foreach(int i in scoreQuery)
            {
                Console.Write(i+" ");

                //Console.WriteLine(i);
            }
        }

        static void array_rank()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            int lengthOfNumbers = numbers.Length;

            int[,] theArray = new int[5,10];
            System.Console.WriteLine("The array has {0} dimensions", theArray.Rank);
        }

        static void array_oneDim()
        {
            int[] array1= new int[]{ 1,3,5,7,9};
            int[] array2 = { 1, 3, 5, 7, 9 };

            int[] array3;
            array3 = new int[] { 1, 3, 5, 7, 9 };

            Console.WriteLine($"{array1[0]}, {array2[1]}, {array3[2]}");

        }

        static void array_multiDim()
        {
            // Two-dimensional array.
            int[,] array2D = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
            // The same array with dimensions specified.
            int[,] array2Da = new int[4, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
            // A similar array with string elements.
            string[,] array2Db = new string[3, 2] { { "one", "two" }, { "three", "four" },
                                        { "five", "six" } };

            // Three-dimensional array.
            int[,,] array3D = new int[,,] { { { 1, 2, 3 }, { 4, 5, 6 } },
                                 { { 7, 8, 9 }, { 10, 11, 12 } } };
            // The same array with dimensions specified.
            int[,,] array3Da = new int[2, 2, 3] { { { 1, 2, 3 }, { 4, 5, 6 } },
                                       { { 7, 8, 9 }, { 10, 11, 12 } } };

            // Accessing array elements.
            System.Console.WriteLine(array2D[0, 0]);
            System.Console.WriteLine(array2D[0, 1]);
            System.Console.WriteLine(array2D[1, 0]);
            System.Console.WriteLine(array2D[1, 1]);
            System.Console.WriteLine(array2D[3, 0]);
            System.Console.WriteLine(array2Db[1, 0]);
            System.Console.WriteLine(array3Da[1, 0, 1]);
            System.Console.WriteLine(array3D[1, 1, 2]);

            // Getting the total count of elements or the length of a given dimension.
            var allLength = array3D.Length;
            var total = 1;
            for (int i = 0; i < array3D.Rank; i++)
            {
                total *= array3D.GetLength(i);
            }
            System.Console.WriteLine("{0} equals {1}", allLength, total);
        }

        static void array_jagged()
        {
            // Declare the array of two elements:
            int[][] arr = new int[2][];

            // Initialize the elements:
            arr[0] = new int[5] { 1, 3, 5, 7, 9 };
            arr[1] = new int[4] { 2, 4, 6, 8 };

            // Display the array elements:
            for (int i = 0; i < arr.Length; i++)
            {
                System.Console.Write("Element({0}): ", i);

                for (int j = 0; j < arr[i].Length; j++)
                {
                    System.Console.Write("{0}{1}", arr[i][j], j == (arr[i].Length - 1) ? "" : " ");
                }
                System.Console.WriteLine();
            }
        }

        static void array_foreach()
        {
            int[] numbers = { 4, 5, 6, 1, 2, 3, -2, -1, 0 };
            foreach(int i in numbers)
            {
                System.Console.Write("{0} ", i);
            }
            Console.WriteLine();
            int[,] numbers2D = new int[3, 2] { { 9, 99 }, { 3, 33 }, { 5, 55 } };
            foreach(int i in numbers2D)
            {
                Console.Write("{0} ", i);

            }
        }

        static void DisplayArray(string[] arr) => Console.WriteLine(string.Join(" ", arr));

        // Change the array by reversing its elements.
        static void ChangeArray(string[] arr) => Array.Reverse(arr);

        static void ChangeArrayElements(string[] arr)
        {
            // Change the value of the first three array elements. 
            arr[0] = "Mon";
            arr[1] = "Wed";
            arr[2] = "Fri";
        }
        static void array_parameter()
        {
            // Declare and initialize an array.
            string[] weekDays = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
            // Display the array elements.
            DisplayArray(weekDays);
            Console.WriteLine();

            // Reverse the array.
            ChangeArray(weekDays);
            // Display the array again to verify that it stays reversed.
            Console.WriteLine("Array weekDays after the call to ChangeArray:");
            DisplayArray(weekDays);
            Console.WriteLine();

            // Assign new values to individual array elements.
            ChangeArrayElements(weekDays);
            // Display the array again to verify that it has changed.
            Console.WriteLine("Array weekDays after the call to ChangeArrayElements:");
            DisplayArray(weekDays);
        }

        static void array_parameter2D(int[,] arr)
        {
            for(int i=0;i<arr.GetLength(0);i++)
            {
                for(int j=0;j<arr.GetLength(1);j++)
                {
                    Console.WriteLine("Element({0},{1})={2}", i, j, arr[i, j]);
                }
            }
        }
        static void Main(string[] args)
        {

            //A hello world! program in c#
            /* multiline ofr comments*/
            //Console.WriteLine("Hello World!");  


            //delegate_test();//delegate test
            //commandLine(args);//command line information 

            //array_queryExpression();//query expression
            //array_rank();//array lenght and rank
            //array_oneDim();//array one  dimension
            //array_multiDim();//multi array dimension
            //array_jagged();//jagged array
            //array_foreach();
            //array_parameter();
            //array_parameter2D(new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } });

            //keep the consolte window ofpen in debug mode.
            Console.WriteLine("\nPress any key to exit");
            Console.ReadKey();

        }
    }
}

