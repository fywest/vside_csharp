using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using Excel = Microsoft.Office.Interop.Excel;

namespace CSharpProgrammeGuide
{
    public delegate void Del(string message);

    public class Galaxy
    {
        public string Name { get; set; }
        public int MegaLightYears { get; set; }
    }

    public class Element
    {
        public string Symbol { get; set; }
        public string Name { get; set; }
        public int AtomicNumber { get; set; }
    }

    class ExampleClass
    {
        public ExampleClass() { }
        public ExampleClass(int v) { }

        public void exampleMethod1(int i) { }

        public void exampleMethod2(string str) { }
    }

    class Product
    {
        public Product(string name, int newID)
        {
            ItemName = name;
            ItemId = newID;
        }

        public string ItemName { get; set; }
        public int ItemId { get; set; }
    }

    [Flags]
    public enum CarOptions
    {
        // The flag for SunRoof is 0001.
        SunRoof = 0x01,
        // The flag for Spoiler is 0010.
        Spoiler = 0x02,
        // The flag for FogLights is 0100.
        FogLights = 0x04,
        // The flag for TintedWindows is 1000.
        TintedWindows = 0x08,
    }

    namespace Nested
    {
        using static System.Console;
        using static System.Math;
        public class NestedNameSpaceClass
        {
            public static void SayHello()
            {

                Console.WriteLine("Hello");
                WriteLine(Sqrt(3*3 + 4*4));

            }
        }
    }
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

        public static long Factorial(int n)
        {
            if((n<0)||(n>20))
            {
                return -1;
            }
            long tempResult = 1;
            for(int i=1;i<=n;i++)
            {
                tempResult *= i;
            }
            return tempResult;
        }
        static int commandLine(string[] args)
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

            if(args.Length==0)
            {
                Console.WriteLine("Please enter a numeric argument");
                Console.WriteLine("Usage:Factorial <num>");
                return 1;
            }

            int num;
            bool test = int.TryParse(args[0], out num);
            if(test==false)
            {
                Console.WriteLine("Please enter a numeric argument");
                Console.WriteLine("Usage:Factorial <num>");
            }

            long result = Factorial(num);

            if(result==-1)
            {
                Console.WriteLine("Input must be >=0 and <=20");
                
            }
            else
            {
                Console.WriteLine("The Factorial of {0} is {1}.", num, result);
            }
            return 0;
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

        static void conceptAssembly()
        {
            //// Access an internal type.  
            //Class1 inst1 = new Class1();
            //inst1.Test();

            //Class2 inst2 = new Class2();
            //// Access an internal member of a public type.  
            //inst2.Test();

            //System.Console.ReadLine();
        }

        static void CreateWorkbook(int[] values, string filePath)
        {
           
            Excel.Application excelApp = null;
            Excel.Workbook wkbk;
            Excel.Worksheet sheet;

            try
            {
                // Start Excel and create a workbook and worksheet.  
                excelApp = new Excel.Application();
                wkbk = excelApp.Workbooks.Add();
                sheet = wkbk.Sheets.Add() as Excel.Worksheet;
                sheet.Name = "Sample Worksheet";

                // Write a column of values.  
                // In the For loop, both the row index and array index start at 1.  
                // Therefore the value of 4 at array index 0 is not included.  
                for (int i = 1; i < values.Length; i++)
                {
                    sheet.Cells[i, 1] = values[i];
                }

                // Suppress any alerts and save the file. Create the directory   
                // if it does not exist. Overwrite the file if it exists.  
                excelApp.DisplayAlerts = false;
                string folderPath = Path.GetDirectoryName(filePath);
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }
                wkbk.SaveAs(filePath);
            }
            catch
            {
            }
            finally
            {
                sheet = null;
                wkbk = null;

                // Close Excel.  
                excelApp.Quit();
                excelApp = null;
            }
        }

        static void collection_test()
        {
            var salmons = new List<string>();//{"chinook","coho","pink","sockeye"}
            salmons.Add("chinook");
            salmons.Add("coho");
            salmons.Add("pink");
            salmons.Add("sockeye");

            salmons.Remove("coho");//remove

            foreach(var salmon in salmons)
            {
                Console.WriteLine(salmon + " ");
            }

            var salmons_upper = new List<string> { "chinook", "coho", "pink", "sockeye" };

            salmons_upper.RemoveAt(1);//remove coho

            for(var index=0;index<salmons_upper.Count;index++)
            {
                Console.Write(salmons_upper[index].ToUpper() + " ");
            }
            Console.WriteLine();
            var theGalaxys = new List<Galaxy>
            {
               new Galaxy(){ Name = "Tadpole", MegaLightYears = 400 },
               new Galaxy(){ Name="Pinwheel",MegaLightYears=25},
               new Galaxy(){Name="Milky Way",MegaLightYears=0},
               new Galaxy(){Name="Andromeda",MegaLightYears=3}
            };
            foreach(Galaxy theGalaxy in theGalaxys)
            {
                Console.WriteLine(theGalaxy.Name + " " + theGalaxy.MegaLightYears);
            }

            Console.WriteLine("***dictionary");

            IterateThruDictionary();
            FindInDictionary("Ti");

            void IterateThruDictionary()
            {
                Dictionary<string, Element> elements = BuildDictionary();

                foreach (KeyValuePair<string, Element> kvp in elements)
                {
                    Element theElement = kvp.Value;

                    Console.WriteLine("key: " + kvp.Key);
                    Console.WriteLine("values: " + theElement.Symbol + " " +
                        theElement.Name + " " + theElement.AtomicNumber);
                }
            }

            Dictionary<string, Element> BuildDictionary()
            {
                var elements = new Dictionary<string, Element>();

                AddToDictionary(elements, "K", "Potassium", 19);
                AddToDictionary(elements, "Ca", "Calcium", 20);
                AddToDictionary(elements, "Sc", "Scandium", 21);
                AddToDictionary(elements, "Ti", "Titanium", 22);

                return elements;
            }

            void AddToDictionary(Dictionary<string, Element> elements,
                string symbol, string name, int atomicNumber)
            {
                Element theElement = new Element();

                theElement.Symbol = symbol;
                theElement.Name = name;
                theElement.AtomicNumber = atomicNumber;

                elements.Add(key: theElement.Symbol, value: theElement);
            }

            void FindInDictionary(string symbol)
            {
                Dictionary<string, Element> elements = BuildDictionary();

                if (elements.ContainsKey(symbol) == false)
                {
                    Console.WriteLine(symbol + " not found");
                }
                else
                {
                    Element theElement = elements[symbol];
                    Console.WriteLine("found: " + theElement.Name);
                }
            }

            Console.WriteLine("***dictionary2");
            IterateThruDictionary2();
            FindInDictionary2("Ti");

            void IterateThruDictionary2()
            {
                Dictionary<string, Element> elements = BuildDictionary2();

                foreach (KeyValuePair<string, Element> kvp in elements)
                {
                    Element theElement = kvp.Value;

                    Console.WriteLine("key: " + kvp.Key);
                    Console.WriteLine("values: " + theElement.Symbol + " " +
                        theElement.Name + " " + theElement.AtomicNumber);
                }

                //var subset = from theElement in elements
                //             where theElement.AtomicNumber < 22
                //             orderby theElement.Name
                //             select theElement;

                //foreach (Element theElement in subset)
                //{
                //    Console.WriteLine(theElement.Name + " " + theElement.AtomicNumber);
                //}


            }

            Dictionary<string, Element> BuildDictionary2()
            {
                return new Dictionary<string, Element>
                    {
                        {"K",
                            new Element() { Symbol="K", Name="Potassium", AtomicNumber=19}},
                        {"Ca",
                            new Element() { Symbol="Ca", Name="Calcium", AtomicNumber=20}},
                        {"Sc",
                            new Element() { Symbol="Sc", Name="Scandium", AtomicNumber=21}},
                        {"Ti",
                            new Element() { Symbol="Ti", Name="Titanium", AtomicNumber=22}}
                    };
            }

            void FindInDictionary2(string symbol)
            {
                Dictionary<string, Element> elements = BuildDictionary2();

                Element theElement = null;
                if (elements.TryGetValue(symbol, out theElement) == false)
                    Console.WriteLine(symbol + " not found");
                else
                    Console.WriteLine("found: " + theElement.Name);
            }



        }

        static void types_test()
        {
           

            byte num = 0xA;
            int byte_max = Byte.MaxValue;//FF
            int byte_szie=sizeof(byte);//1
            Type type_byte = num.GetType();//Byte


            char c = 'Z';
            int char_max = char.MaxValue;//FFFF
            int char_szie = sizeof(char);//72
            Type type_char = c.GetType();//Char

            short j = 5;
            int short_max = short.MaxValue;//32767
            int short_size = sizeof(short);//2
            Type type_short = j.GetType();//Int16

            int i = 5;
            int int_max = int.MaxValue;//217483647
            int int_size = sizeof(int);//4
            Type type_int = i.GetType();//Int32

            Console.WriteLine($"byte_max:{byte_max} byte_size:{byte_szie}\n" +
                $"char_max:{char_max} char_size:{char_szie}\n" +
                $"short_max:{short_max} short_size:{short_size}\n" +
                $"int_max:{int_max} int_size:{int_size}");
        }

        static void box_test()
        {
            int i = 123;
            object o = i;
            i = 456;
            

            try
            {
                //int j = (short)o;//invalid
                int j = (int)o;
                System.Console.WriteLine("unboxing ok");
            }
            catch(System.InvalidCastException e)
            {
                System.Console.WriteLine("{0} Error: Incorrect unboxing", e.Message);
            }
        }

        //static void dynamic_test()
        //{
        //    ExampleClass ec = new ExampleClass();
        //    dynamic dynamic_ec = new ExampleClass();

        //    dynamic_ec.exampleMethod1( 10, 4);
        //    dynamic_ec.someMethod("some argument", 7, null);
        //    dynamic_ec.nonexistentMethod();
        //}

        
        static void bitConvert_arrayInt()
        {
            byte[] bytes = { 0, 0, 0, 25 };
            //if the system architecture is little-endian(that is ,little end first),
            // reverse the byte array
            if (BitConverter.IsLittleEndian)
                Array.Reverse(bytes);
            int i = BitConverter.ToInt32(bytes, 0);
            Console.WriteLine("int: {0}", i);

            byte[] bytes1 = BitConverter.GetBytes(201805978);
            Console.WriteLine("byte array: " + BitConverter.ToString(bytes1));
        }

        static void bitConver_test()
        {
            Console.WriteLine(
                "This example of the BitConverter.IsLittleEndian field " +
                "generates \nthe following output when run on " +
                "x86-class computers.\n");
            Console.WriteLine("IsLittleEndian:  {0}",
                BitConverter.IsLittleEndian);

            const string formatter = "{0,25}{1,30}";

            double aDoubl = 0.1111111111111111111;
            float aSingl = 0.1111111111111111111F;
            long aLong = 1111111111111111111;
            int anInt = 1111111111;
            short aShort = 11111;
            char aChar = '*';
            bool aBool = true;

            Console.WriteLine(
                "This example of methods of the BitConverter class" +
                "\ngenerates the following output.\n");
            Console.WriteLine(formatter, "argument", "byte array");
            Console.WriteLine(formatter, "--------", "----------");

            // Convert values to Byte arrays and display them.
            Console.WriteLine(formatter, aDoubl,
                BitConverter.ToString(BitConverter.GetBytes(aDoubl)));
            Console.WriteLine(formatter, aSingl,
                BitConverter.ToString(BitConverter.GetBytes(aSingl)));
            Console.WriteLine(formatter, aLong,
                BitConverter.ToString(BitConverter.GetBytes(aLong)));
            Console.WriteLine(formatter, anInt,
                BitConverter.ToString(BitConverter.GetBytes(anInt)));
            Console.WriteLine(formatter, aShort,
                BitConverter.ToString(BitConverter.GetBytes(aShort)));
            Console.WriteLine(formatter, aChar,
                BitConverter.ToString(BitConverter.GetBytes(aChar)));
            Console.WriteLine(formatter, aBool,
                BitConverter.ToString(BitConverter.GetBytes(aBool)));

        }

        static void bitconvet_GetbytesChar()
        {
            const string formatter = "{0,10}{1,16}";

            Console.WriteLine(
            "This example of the BitConverter.GetBytes( char ) " +
            "\nmethod generates the following output.\r\n");
            Console.WriteLine(formatter, "char", "byte array");
            Console.WriteLine(formatter, "----", "----------");

            // Convert char values and display the results.
            GetBytesChar('\0');
            GetBytesChar(' ');
            GetBytesChar('*');
            GetBytesChar('3');
            GetBytesChar('A');
            GetBytesChar('[');
            GetBytesChar('a');
            GetBytesChar('{');

            void GetBytesChar(char argument)
            {
                byte[] byteArray = BitConverter.GetBytes(argument);
                Console.WriteLine(formatter, argument,
                    BitConverter.ToString(byteArray));
            }

        }

        static void bitConvert_GetBytes_int16()
        {

            const string formatter = "{0,10}{1,13}";

            Console.WriteLine(
            "This example of the BitConverter.GetBytes( short ) " +
            "\nmethod generates the following output.\n");
            Console.WriteLine(formatter, "short", "byte array");
            Console.WriteLine(formatter, "-----", "----------");

            // Convert short values and display the results.
            GetBytesInt16(0);
            GetBytesInt16(15);
            GetBytesInt16(-15);
            GetBytesInt16(10000);
            GetBytesInt16(-10000);
            GetBytesInt16(short.MinValue);
            GetBytesInt16(short.MaxValue);

            // Convert a short argument to a byte array and display it.
            void GetBytesInt16(short argument)
            {
                byte[] byteArray = BitConverter.GetBytes(argument);
                Console.WriteLine(formatter, argument,
                    BitConverter.ToString(byteArray));
            }
        }

        static void bitConvert_GetBytes_int32()
        {
            // Define an array of integers.
            int[] values = { 0, 15, -15, 0x100000,  -0x100000, 1000000000,
                         -1000000000, int.MinValue, int.MaxValue };

            // Convert each integer to a byte array.
            Console.WriteLine("{0,16}{1,10}{2,17}", "Integer",
                              "Endian", "Byte Array");
            Console.WriteLine("{0,16}{1,10}{2,17}", "---", "------",
                              "----------");
            foreach (var value in values)
            {
                byte[] byteArray = BitConverter.GetBytes(value);
                Console.WriteLine("{0,16}{1,10}{2,17}", value,
                                  BitConverter.IsLittleEndian ? "Little" : " Big",
                                  BitConverter.ToString(byteArray));
            }
        }

        static void BitConvert_ByteToChar()
        {
            string formatter = "{0,5}{1,17}{2,8}";

            byte[] byteArray = {
             32,   0,   0,  42,   0,  65,   0, 125,   0,
            197,   0, 168,   3,  41,   4, 172,  32 };

            Console.WriteLine(
                "This example of the BitConverter.ToChar( byte[ ], " +
                "int ) \nmethod generates the following output. It " +
                "converts \nelements of a byte array to char values.\n");
            Console.WriteLine("initial byte array");
            Console.WriteLine("------------------");
            Console.WriteLine(BitConverter.ToString(byteArray));

            for(int i=0;i<byteArray.Length;i=i+1)
                Console.Write("{0} ",byteArray[i]);

            Console.WriteLine();
            for (int i = 0; i < byteArray.Length; i++)
                Console.Write("|{0} ", (char)byteArray[i]);

            Console.WriteLine();
            Console.WriteLine(formatter, "index", "array elements", "char");
            Console.WriteLine(formatter, "-----", "--------------", "----");

            // Convert byte array elements to char values.
            BAToChar(byteArray, 0);
            BAToChar(byteArray, 1);
            BAToChar(byteArray, 3);
            BAToChar(byteArray, 5);
            BAToChar(byteArray, 7);
            BAToChar(byteArray, 9);
            BAToChar(byteArray, 11);
            BAToChar(byteArray, 13);
            BAToChar(byteArray, 15);

            void BAToChar(byte[] bytes, int index)
            {
                char value = BitConverter.ToChar(bytes, index);


                Console.WriteLine(formatter, index,
                    BitConverter.ToString(bytes, index, 2), value);
            }

            Console.WriteLine();
            Console.WriteLine(formatter, "index", "array elements", "int16");
            Console.WriteLine(formatter, "-----", "--------------", "----");

            BAToInt16(byteArray, 0);
            BAToInt16(byteArray, 1);
            BAToInt16(byteArray, 3);
            BAToInt16(byteArray, 5);
            BAToInt16(byteArray, 7);
            BAToInt16(byteArray, 9);
            BAToInt16(byteArray, 11);
            BAToInt16(byteArray, 13);
            BAToInt16(byteArray, 15);
            void BAToInt16(byte[] bytes,int index)
            {
                int value = BitConverter.ToInt16(bytes, index);
                Console.WriteLine(formatter, index,
                    BitConverter.ToString(bytes, index, 2), value.ToString());
            }

            formatter = "{0,5}{1,17}{2,18}";
            Console.WriteLine();
            Console.WriteLine(formatter, "index", "array elements", "int32");
            Console.WriteLine(formatter, "-----", "--------------", "----");

            BAToInt32(byteArray, 0);
            BAToInt32(byteArray, 3);
            BAToInt32(byteArray, 7);
            BAToInt32(byteArray, 11);
            

            void BAToInt32(byte[] bytes, int index)
            {
                int value = BitConverter.ToInt32(bytes, index);
                Console.WriteLine(formatter, index,
                    BitConverter.ToString(bytes, index, 4), value.ToString());
            }
        }

        static void tryParse_test()
        {
            string numString = "1287543"; //"1287543.0" will return false for a long
            long number1 = 0;
            bool canConvert = long.TryParse(numString, out number1);
            if (canConvert == true)
                Console.WriteLine("number1 now = {0}", number1);
            else
                Console.WriteLine("numString is not a valid long");

            byte number2 = 0;
            numString = "255"; // A value of 256 will return false
            canConvert = byte.TryParse(numString, out number2);
            if (canConvert == true)
                Console.WriteLine("number2 now = {0}", number2);
            else
                Console.WriteLine("numString is not a valid byte");

            decimal number3 = 0;
            numString = "27.3"; //"27" is also a valid decimal
            canConvert = decimal.TryParse(numString, out number3);
            if (canConvert == true)
                Console.WriteLine("number3 now = {0}", number3);
            else
                Console.WriteLine("number3 is not a valid decimal");
        }

        static void tryParse_strToNum()
        {
            // This snippet shows a couple of examples that extract number characters from the
            // beginning of the string to avoid TryParse errors.
            StringBuilder sb = new StringBuilder();
            var str = "  10FFxxx";
            foreach (char c in str)
            {
                // Check for numeric characters (hex in this case).  Add "." and "e" if float,
                // and remove letters.  Include initial space because it is harmless.
                if ((c >= '0' && c <= '9') || (c >= 'A' && c <= 'F') || (c >= 'a' && c <= 'f') || c == ' ')
                {
                    sb.Append(c);
                }
                else
                    break;
            }
            if (int.TryParse(sb.ToString(), System.Globalization.NumberStyles.HexNumber, null, out int i))
                Console.WriteLine(sb.ToString());
            Console.WriteLine("i= {0}", i);

            str = "   -10FFXXX";
            sb.Clear();
            foreach (char c in str)
            {
                // Check for numeric characters (allow negative in this case but no hex digits). 
                // Though we use int.TryParse in the previous example and this one, int.TryParse does NOT
                // allow a sign character (-) AND hex digits at the same time.
                // Include initial space because it is harmless.
                if ((c >= '0' && c <= '9') || c == ' ' || c == '-')
                {
                    sb.Append(c);
                }
                else
                    break;
            }
            if (int.TryParse(sb.ToString(), out int j))
                Console.WriteLine(sb.ToString());
            Console.WriteLine("j= {0}", j);
        }

        static void convert_HexToStr()
        {
            string input = "Hello World!";
            char[] values = input.ToCharArray();
            foreach(char letter in values)
            {
                int value = Convert.ToInt32(letter);
                string hexoutput = string.Format("{0:X}", value);
                Console.WriteLine("Hexadecimal value of {0} is {1}", letter, hexoutput);
            }

            Console.WriteLine(" hex to integer and char");

            string hexValues = "48 65 6C 6C 6F 20 57 6F 72 6C 64 21";
            string[] hexValuesSplit = hexValues.Split(' ');
            foreach(string hex in hexValuesSplit)
            {
                int value = Convert.ToInt32(hex,16);
                string stringValue = char.ConvertFromUtf32(value);
                char charValue = (char)value;
                Console.WriteLine("hexadecimal value = {0}, int value = {1}, char value = {2} or {3}",
                    hex, value, stringValue, charValue);


            }

            Console.WriteLine(" hex to decimal");
            string hexString = "8E2";//2274
            int num = Int32.Parse(hexString, System.Globalization.NumberStyles.HexNumber);
            Console.WriteLine($"{hexString} {num}");

            Console.WriteLine(" hex to float");
            string hexString1 = "43480170";
            uint num1 = uint.Parse(hexString1, System.Globalization.NumberStyles.AllowHexSpecifier);
            byte[] floatVals = BitConverter.GetBytes(num1);
            float f = BitConverter.ToSingle(floatVals, 0);
            Console.WriteLine("{0} float convert={1}",hexString1, f);

            Console.WriteLine(" byte to hex");
            byte[] vals = { 0x01, 0xAA, 0XB1, 0XDC, 0X10, 0XDD };
            string str = BitConverter.ToString(vals);
            Console.WriteLine(str);

            str = BitConverter.ToString(vals).Replace("-", "");
            Console.WriteLine(str);
        }

        static void types_test1()
        {
            //byte
            byte byteValue1 = 201;
            Console.WriteLine(byteValue1);

            byte byteValue2 = 0x00C9;
            Console.WriteLine(byteValue2);

            byte byteValue3 = 0b1100_1001;
            Console.WriteLine(byteValue3);

            //char
            char[] chars = new char[4];

            chars[0]= 'X';
            chars[1] = '\x0058';
            chars[2] = (char)88;
            chars[3] = '\u0058';

            foreach(char c in chars)
            {
                Console.WriteLine(c + " ");
            }

            //int,float,short,double
            int x = 3;
            float y = 4.5f;
            short z = 5;
            double w = 1.7E+3;
            // Result of the 2nd argument is a double:
            Console.WriteLine("The sum is {0}", x + y + z + w);

            //enum
            // The bitwise OR of 0001 and 0100 is 0101.
            CarOptions options = CarOptions.SunRoof | CarOptions.FogLights;

            // Because the Flags attribute is specified, Console.WriteLine displays
            // the name of each enum element that corresponds to a flag that has
            // the value 1 in variable options.
            Console.WriteLine(options);
            // The integer value of 0101 is 5.
            Console.WriteLine((int)options);

            //int
            int intValue1 = 90_946;
            Console.WriteLine(intValue1);

            int intValue2 = 0x0001_6342;
            Console.WriteLine(intValue2);

            int intValue3 = 0b0001_0110_0011_0100_0010;
            Console.WriteLine(intValue3);

            int intValue4 = 0x_0001_6342;       // C# 7.2 onwards
            Console.WriteLine(intValue4);

            int intValue5 = 0b_0001_0110_0011_0100_0010;       // C# 7.2 onwards
            Console.WriteLine(intValue5);
            // The example displays the following output:
            //          90946
            //          90946
            //          90946
            //          90946
            //          90946
        }

        static void methodParams()
        {
            UseParams(1, 2, 3, 4);
            UseParams2(1, 'a', "test",new int[] {6,5,4,3,2,1 });

            void UseParams(params int[] list)
            {
                for(int i=0;i<list.Length;i++)
                {
                    Console.WriteLine(list[i] + " ");
                }
                Console.WriteLine();
            }
            void UseParams2(params object[] list)
            {
                for(int i=0;i<list.Length;i++)
                {
                    Console.Write(list[i] + " ");
                    //if (list[i].length)
                }
                Console.WriteLine();
            }
        }

        static void ModifyProductByReference()
        {
            Product item = new Product("Fasteners", 54321);
            Console.WriteLine("Original values in Main. Name: {0},ID: {1} \n", item.ItemName, item.ItemId);

            ChangeByReference(ref item);
            Console.WriteLine("Back in Main. Name: {0},ID: {1} \n", item.ItemName, item.ItemId);

            void ChangeByReference(ref Product itemRef)
            {
                itemRef = new Product("Stapler", 99999);
                itemRef.ItemId = 12345;
            }

            int number = 1;
            Method(ref number);
            Console.WriteLine(number);
            void Method(ref int refArgument)
            {
                refArgument = refArgument + 44;
            }
        }

        static void namespace_test()
        {
            
            Nested.NestedNameSpaceClass.SayHello();
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
            //conceptAssembly()//reference friend unsigned_B project


            //int[] values = { 4, 6, 18, 2, 1, 76, 0, 3, 11 };
            //CreateWorkbook(values, @"C:\SampleFolder\SampleWorkbook.xls");

            //collection_test();

            types_test();//sizeof byte,char,int

            //box_test();

            //dynamic_test();

            //bitConvert_arrayInt();

            //bitConver_test();
            //bitconvet_GetbytesChar();
            //bitConvert_GetBytes_int16();
            //bitConvert_GetBytes_int32();
            //BitConvert_ByteToChar();

            //tryParse_test();//long,decimal,byte,
            //tryParse_strToNum();//hex , minus
            //convert_HexToStr();//hex to decimal,float. byte to hex

            //types_test1();//byte,char,int,long
            //methodParams();

            //ModifyProductByReference();
            //namespace_test();//namespace,using,

            //keep the consolte window ofpen in debug mode.
            Console.WriteLine("\nPress any key to exit");
            Console.ReadKey();

        }
    }
}

