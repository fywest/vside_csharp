using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Threading;

namespace CSharpString
{
    class Program
    {
        static void Str_split_1()
        {
            string phrase = "The quick brown    fox jumps over the layzy dog.";
            string[] words = phrase.Split(' ');

            foreach (var word in words)
            {
                System.Console.WriteLine($"<{word}>");

            }
            System.Console.WriteLine("*****************");
        }

        static void Str_split_2()
        {
            char[] delimiterChars = { ' ', ',', '.', ':', '\t' };
            string text = "one\ttwo :,five six seven";
            System.Console.WriteLine($"origin text: '{text}'");

            String[] words = text.Split(delimiterChars);
            System.Console.WriteLine($"{words.Length} words in text:");

            foreach(var word in words)
            {
                System.Console.WriteLine($"<{word}>");
            }
        }

        static void Str_split_3()
        {
            string[] separatingChars = { "<<", "..." };
            string text = "one<<two......three<four";
            System.Console.WriteLine("original txt: '{0}", text);

            string[] words = text.Split(separatingChars, System.StringSplitOptions.RemoveEmptyEntries);
            System.Console.WriteLine("{0} substrings in text:", words.Length);

            foreach(var word in words)
            {
                System.Console.WriteLine(word);
            }
        }

        static void Str_concatenation_1()
        {
            string text = "how are you," + " today is cold," + " see you!";
            System.Console.WriteLine(text);
        }
        
        static void Str_concatenation_2()
        {
            string userName = "lee";
            string dateString = DateTime.Today.ToShortDateString();
            string str = "Hello " + userName + ". Today is " + dateString;
            System.Console.WriteLine(str);
            str+= " How are you today?";
            System.Console.WriteLine(str);

        }

        static void Str_concatenation_3()
        {
            var sb = new System.Text.StringBuilder();
            for(int i=0;i<20;i++)
            {
                sb.AppendLine(i.ToString());
            }
            System.Console.WriteLine(sb.ToString());
        }

        static void Str_concatenation_4()
        {
            string[] words={ "The","quick","brown","fox","jumps","over","the","lazy","dog."};

            var unreadablePhase = string.Concat(words);
            System.Console.WriteLine(unreadablePhase);

            var readablePhase = string.Join(" ", words);
            System.Console.WriteLine(readablePhase);
        }

        static void Str_datetime_1()
        {
            string dataInput = "Jan 1,2009";
            DateTime parsedDate = DateTime.Parse(dataInput);
            Console.WriteLine(parsedDate);

        }

        static void Str_datetime_2()
        {
            CultureInfo MyCultureInfo = new CultureInfo("de-DE");
            string MyString = "12 Juni 2008";
            DateTime MyDateTime = DateTime.Parse(MyString, MyCultureInfo);
            Console.WriteLine(MyDateTime);
        }

        static void Str_search_1()
        {
            string factMessage = "Extension methods have all the capabilities of regular static methods.";
            Console.WriteLine($"\"{factMessage}\"");
            bool containsSearchResult = factMessage.Contains("extension");
            Console.WriteLine($"Starts with \"extension\"? {containsSearchResult}");

            bool ignoreCaseSearchResult = factMessage.StartsWith("extension",System.StringComparison.InvariantCultureIgnoreCase);
            Console.WriteLine($"Starts with \"extension\"? {ignoreCaseSearchResult} (ignoring case)");

            bool endsWithSearchResult = factMessage.EndsWith(".", System.StringComparison.InvariantCultureIgnoreCase);
            Console.WriteLine($"Ends with '.'? {endsWithSearchResult} ");
        }

        static void Str_search_2()
        {
            string[] sentences =
            {
                "Put the water over there.",
                "They're quite thirsty.",
                "Their water bottles broke."
            };

            string sPattern = "the(ir)?\\s";

            foreach(string s in sentences)
            {
                Console.Write($"|{s,24}|");//右侧对齐，占位宽度２４.
                if (System.Text.RegularExpressions.Regex.IsMatch(s,sPattern,System.Text.RegularExpressions.RegexOptions.IgnoreCase))
                {
                    Console.WriteLine($" (match for '{sPattern}' found)");
                }
                else
                {
                    Console.WriteLine();
                }
            }
        }

        static void Str_search_3()
        {
            string[] numbers =
            {
                "123-555-0190",
                "444-234-22450",
                "690-555-0178",
                "146-893-232",
                "146-555-0122",
                "4007-555-0111",
                "407-555-0111",
                "407-2-5555",
                "407-555-8974",
                "407-2ab-5555",
                "690-555-8148",
                "146-893-232-"
            };
            string sPattern = "^\\d{3}-\\d{3}-\\d{4}$";
            foreach(string s in numbers)
            {
                Console.Write($"{s,14}");
                if (System.Text.RegularExpressions.Regex.IsMatch(s, sPattern))
                {
                    Console.WriteLine(" - valid");
                }
                else
                {
                    Console.WriteLine(" - invalid");
                }
            }

        }

        static void Str_modify_1()
        {
            string source = "The mountains are behind the clouds today.";
            var replacement = source.Replace("mountains", "peaks");
            Console.WriteLine($"The source string is <{source}>");
            Console.WriteLine($"The updated string is <{replacement}>");
        }

        static void Str_modify_2()
        {
            string source = "The mountains are behind the clouds today.";
            var replacement = source.Replace(' ', '_');
            Console.WriteLine(source);
            Console.WriteLine(replacement);
        }

        static void Str_modify_3()
        {
            string source = "     I'm wider than I need to be.    ";
            var trimmedResult = source.Trim();
            var trimLeading = source.TrimStart();
            var trimTrailing = source.TrimEnd();
            Console.WriteLine($"<{trimmedResult}>");
            Console.WriteLine($"<{trimLeading}>");
            Console.WriteLine($"<{trimTrailing}>");
        }

        static void Str_modify_4()
        {
            string source = "Many mountains are behind many clouds today.";
            string toRemove = "many ";
            string result = string.Empty;
            int i = source.IndexOf(toRemove);
            if(i>=0)
            {
                result = source.Remove(i, toRemove.Length);
            }
            Console.WriteLine(source);
            Console.WriteLine(result);

        }

        static void Str_modify_5()
        {
            string source = "The mountains are still there behind many clouds today.";
            string replaceWith = "many ";
            source = System.Text.RegularExpressions.Regex.Replace(source, "the\\s", LocalReplaceMatchCase,
    System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            Console.WriteLine(source);

            string LocalReplaceMatchCase(System.Text.RegularExpressions.Match matchExpression)
            {
                // Test whether the match is capitalized
                if (Char.IsUpper(matchExpression.Value[0]))
                {
                    // Capitalize the replacement string
                    System.Text.StringBuilder replacementBuilder = new System.Text.StringBuilder(replaceWith);
                    replacementBuilder[0] = Char.ToUpper(replacementBuilder[0]);
                    return replacementBuilder.ToString();
                }
                else
                {
                    return replaceWith;
                }
            }

        }

        static void Str_modify_6()
        {
            string phrase = "THe quick brown fox jumps over the fence";
            Console.WriteLine(phrase);

            char[] phraseAsChars = phrase.ToCharArray();
            int animalIndex = phrase.IndexOf("fox");
            if(animalIndex!=-1)
            {
                phraseAsChars[animalIndex++] = 'c';
                phraseAsChars[animalIndex++] = 'a';
                phraseAsChars[animalIndex] = 't';

            }
            string updatedPhrase = new string(phraseAsChars);
            Console.WriteLine(updatedPhrase);
        }
         unsafe static void Str_modify_7()
        {
            
            {
                string helloOne = "Hello";
                string helloTwo = "Hello";

                fixed (char* p = helloOne)
                {
                    p[0] = 'C';
             
                }
                Console.WriteLine(helloOne);
                Console.WriteLine(helloTwo);

            }

        }

        static void Str_compare_1()
        {
            string root = @"C:\users";
            string root2 = @"C:\Users";

            bool result = root.Equals(root2);
            int comparition = root.CompareTo(root2);
            Console.WriteLine($"Ordinal comparison: <{root}> and <{root2}> are {(result ? "equal." : "not equal.")}");
            if (comparition < 0)
                Console.WriteLine($"<{root}> is less than <{root2}>");
            else if (comparition > 0)
                Console.WriteLine($"<{root}> is greater than <{root2}>");
            else
                Console.WriteLine($"<{root}> and <{root2}> are equivalent in order");

            result = root.Equals(root2, StringComparison.Ordinal);
            Console.WriteLine($"Ordinal comparsion: <{root}> and <{root2}> are {(result ? "equal." : "not equal.")}");
            Console.WriteLine($"Using == says that <{root}> and <{root2}> are {(root == root2 ? "equal" : "not equal")}");
        }

        static void Str_compara_2()
        {
            string root = @"C:\users";
            string root2 = @"C:\Users";

            bool result = root.Equals(root2, StringComparison.OrdinalIgnoreCase);
            bool areEqual = String.Equals(root, root2, StringComparison.OrdinalIgnoreCase);
            int comparison = String.Compare(root, root2, ignoreCase: true);

            Console.WriteLine($"Ordinal ignore case: <{root}> and <{root2}> are {(result ? "equal." : "not equal.")}");
            Console.WriteLine($"Ordinal static ignore case: <{root}> and <{root2}> are {(areEqual ? "equal." : "not equal.")}");
            if (comparison < 0)
                Console.WriteLine($"<{root}> is less than <{root2}>");
            else if (comparison > 0)
                Console.WriteLine($"<{root}> is greater than <{root2}>");
            else
                Console.WriteLine($"<{root}> and <{root2}> are equivalent in order");
        }

        static void Str_compare_3()
        {
            string first = "Sie tanzen auf der Straße.";
            string second = "Sie tanzen auf der Strasse.";

            Console.WriteLine($"First sentence is <{first}>");
            Console.WriteLine($"Second sentence is <{second}>");

            bool equal = String.Equals(first, second, StringComparison.InvariantCulture);
            Console.WriteLine($"The two strings {(equal == true ? "are" : "are not")} equal.");
            showComparison(first, second);

            string word = "coop";
            string words = "co-op";
            string other = "cop";

            showComparison(word, words);
            showComparison(word, other);
            showComparison(words, other);
            void showComparison(string one, string two)
            {
                int compareLinguistic = String.Compare(one, two, StringComparison.InvariantCulture);
                int compareOrdinal = String.Compare(one, two, StringComparison.Ordinal);
                if (compareLinguistic < 0)
                    Console.WriteLine($"<{one}> is less than <{two}> using invariant culture");
                else if (compareLinguistic > 0)
                    Console.WriteLine($"<{one}> is greater than <{two}> using invariant culture");
                else
                    Console.WriteLine($"<{one}> and <{two}> are equivalent in order using invariant culture");
                if (compareOrdinal < 0)
                    Console.WriteLine($"<{one}> is less than <{two}> using ordinal comparison");
                else if (compareOrdinal > 0)
                    Console.WriteLine($"<{one}> is greater than <{two}> using ordinal comparison");
                else
                    Console.WriteLine($"<{one}> and <{two}> are equivalent in order using ordinal comparison");
            }
        }

        static void Str_compare_4()
        {
            string first = "Sie tanzen auf der Straße.";
            string second = "Sie tanzen auf der Strasse.";

            Console.WriteLine($"First sentence is <{first}>");
            Console.WriteLine($"Second sentence is <{second}>");

            var en = new System.Globalization.CultureInfo("en-US");

            // For culture-sensitive comparisons, use the String.Compare 
            // overload that takes a StringComparison value.
            int i = String.Compare(first, second, en, System.Globalization.CompareOptions.IgnoreNonSpace);
            Console.WriteLine($"Comparing in {en.Name} returns {i}.");

            var de = new System.Globalization.CultureInfo("de-DE");
            i = String.Compare(first, second, de, System.Globalization.CompareOptions.IgnoreNonSpace);
            Console.WriteLine($"Comparing in {de.Name} returns {i}.");

            bool b = String.Equals(first, second, StringComparison.CurrentCulture);
            Console.WriteLine($"The two strings {(b == true ? "are" : "are not")} equal.");

            string word = "coop";
            string words = "co-op";
            string other = "cop";

            showComparison(word, words, en);
            showComparison(word, other, en);
            showComparison(words, other, en);
            void showComparison(string one, string two, System.Globalization.CultureInfo culture)
            {
                int compareLinguistic = String.Compare(one, two, en, System.Globalization.CompareOptions.IgnoreNonSpace);
                int compareOrdinal = String.Compare(one, two, StringComparison.Ordinal);
                if (compareLinguistic < 0)
                    Console.WriteLine($"<{one}> is less than <{two}> using en-US culture");
                else if (compareLinguistic > 0)
                    Console.WriteLine($"<{one}> is greater than <{two}> using en-US culture");
                else
                    Console.WriteLine($"<{one}> and <{two}> are equivalent in order using en-US culture");
                if (compareOrdinal < 0)
                    Console.WriteLine($"<{one}> is less than <{two}> using ordinal comparison");
                else if (compareOrdinal > 0)
                    Console.WriteLine($"<{one}> is greater than <{two}> using ordinal comparison");
                else
                    Console.WriteLine($"<{one}> and <{two}> are equivalent in order using ordinal comparison");
            }
        }

        static void Str_compare_5()
        {
            string[] lines = new string[]
            {
                @"c:\public\A.txt",
                @"c:\public\a.txt",
                @"c:\public\textfile.txt",
                @"c:\public\textFile.TXT",
                @"c:\public\Text.txt",
                @"c:\public\textfile2.txt"
            };

            Console.WriteLine("Non-sorted order:");
            foreach(string s in lines)
            {
                Console.WriteLine($"   {s}");

            }
            int str_index = lines[0].IndexOf('A');
            Display(lines);

            Console.WriteLine("\n\rSorted order: ");

            Array.Sort(lines, StringComparer.Ordinal);//.CurrentCulture);
            foreach(string s in lines)
            {
                Console.WriteLine($"   {s}");
            }

           void Display(string[] lst)//, string title)
            {
                Char c;
                int codePoint;
                //Console.WriteLine(title);
                foreach (string s in lst)
                {
                    c = s[str_index];
                    codePoint = Convert.ToInt32(c);
                    Console.WriteLine("0x{0:x}", codePoint);
                }
                Console.WriteLine();
            }
        }

        static void Str_compare_6()
        {
            // Create a list of string.
            List<string> list = new List<string>();

            // Get the tr-TR (Turkish-Turkey) culture.
            CultureInfo turkish = new CultureInfo("tr-TR");

            // Get the culture that is associated with the current thread.
            CultureInfo thisCulture = Thread.CurrentThread.CurrentCulture;

            // Get the standard StringComparers.
            StringComparer invCmp = StringComparer.InvariantCulture;
            StringComparer invICCmp = StringComparer.InvariantCultureIgnoreCase;
            StringComparer currCmp = StringComparer.CurrentCulture;
            StringComparer currICCmp = StringComparer.CurrentCultureIgnoreCase;
            StringComparer ordCmp = StringComparer.Ordinal;
            StringComparer ordICCmp = StringComparer.OrdinalIgnoreCase;

            // Create a StringComparer that uses the Turkish culture and ignores case.
            StringComparer turkICComp = StringComparer.Create(turkish, true);

            // Define three strings consisting of different versions of the letter I.
            // LATIN CAPITAL LETTER I (U+0049)
            string capitalLetterI = "I";

            // LATIN SMALL LETTER I (U+0069)
            string smallLetterI = "i";

            // LATIN SMALL LETTER DOTLESS I (U+0131)
            string smallLetterDotlessI = "\u0131";

            // Add the three strings to the list.
            list.Add(capitalLetterI);
            list.Add(smallLetterI);
            list.Add(smallLetterDotlessI);

            // Display the original list order.
            Display(list, "The original order of the list entries...");

            // Sort the list using the invariant culture.
            list.Sort(invCmp);
            Display(list, "Invariant culture...");
            list.Sort(invICCmp);
            Display(list, "Invariant culture, ignore case...");

            // Sort the list using the current culture.
            Console.WriteLine("The current culture is \"{0}\".", thisCulture.Name);
            list.Sort(currCmp);
            Display(list, "Current culture...");
            list.Sort(currICCmp);
            Display(list, "Current culture, ignore case...");

            // Sort the list using the ordinal value of the character code points.
            list.Sort(ordCmp);
            Display(list, "Ordinal...");
            list.Sort(ordICCmp);
            Display(list, "Ordinal, ignore case...");

            // Sort the list using the Turkish culture, which treats LATIN SMALL LETTER 
            // DOTLESS I differently than LATIN SMALL LETTER I.
            list.Sort(turkICComp);
            Display(list, "Turkish culture, ignore case...");

            void Display(List<string> lst, string title)
            {
                Char c;
                int codePoint;
                Console.WriteLine(title);
                foreach (string s in lst)
                {
                    c = s[0];
                    codePoint = Convert.ToInt32(c);
                    Console.WriteLine("0x{0:x}", codePoint);
                }
                Console.WriteLine();
            }
        }

        static void Str_compare_7()
        {
            string[] lines = new string[]
            {
                @"c:\public\textfile.txt",
                @"c:\public\textFile.TXT",
                @"c:\public\Text.txt",
                @"c:\public\testfile2.txt",
                @"c:\public\TEXTFILE.TXT"
            };
            Array.Sort(lines, StringComparer.CurrentCulture);

            string searchString = @"c:\public\TEXTFILE.TXT";
            Console.WriteLine($"Binary search for <{searchString}>");
            int result = Array.BinarySearch(lines, searchString, StringComparer.CurrentCulture);
            ShowWhere<string>(lines, result);

            Console.WriteLine($"{(result > 0 ? "Found" : "Did not find")} {searchString}");

            void ShowWhere<T>(T[] array, int index)
            {
                if (index < 0)
                {
                    index = ~index;

                    Console.Write("Not found. Sorts between: ");

                    if (index == 0)
                        Console.Write("beginning of sequence and ");
                    else
                        Console.Write($"{array[index - 1]} and ");

                    if (index == array.Length)
                        Console.WriteLine("end of sequence.");
                    else
                        Console.WriteLine($"{array[index]}.");
                }
                else
                {
                    Console.WriteLine($"Found at index {index}.");
                }
            }
        }

        static void Str_compare_8()
        {
            List<string> lines = new List<string>
                {
                    @"c:\public\textfile.txt",
                    @"c:\public\textFile.TXT",
                    @"c:\public\Text.txt",
                    @"c:\public\testfile2.txt"
                };
            Console.WriteLine("Non-sorted order:");
            foreach(string s in lines)
            {
                Console.WriteLine($"   {s}");
            }

            Console.WriteLine("\n\rSorted order:");
            lines.Sort((left, right) => left.CompareTo(right));
            foreach(string s in lines)
            {
                Console.WriteLine($"    {s}");
            }
        }

        static void Str_compare_9()
        {
            List<string> lines = new List<string>
                {
                    @"c:\public\textfile.txt",
                    @"c:\public\textFile.TXT",
                    @"c:\public\Text.txt",
                    @"c:\public\testfile2.txt",
                    @"c:\public\TEXTFILE.TXT"
                };
            lines.Sort((left, right) => left.CompareTo(right));

            string searchString = @"c:\public\TEXTFILE.TXT";
            Console.WriteLine($"Binary search for <{searchString}>");
            int result = lines.BinarySearch(searchString);
            ShowWhere<string>(lines, result);

            Console.WriteLine($"{(result > 0 ? "Found" : "Did not find")} {searchString}");

            void ShowWhere<T>(IList<T> collection, int index)
            {
                if (index < 0)
                {
                    index = ~index;

                    Console.Write("Not found. Sorts between: ");

                    if (index == 0)
                        Console.Write("beginning of sequence and ");
                    else
                        Console.Write($"{collection[index - 1]} and ");

                    if (index == collection.Count)
                        Console.WriteLine("end of sequence.");
                    else
                        Console.WriteLine($"{collection[index]}.");
                }
                else
                {
                    Console.WriteLine($"Found at index {index}.");
                }
            }
        }
        static void Str_compare_10()
        {
            string a = "The computer ate my source code.";
            string b = "The computer ate my source code.";

            if (String.ReferenceEquals(a, b))
                Console.WriteLine("a and b are interned.");
            else
                Console.WriteLine("a and b are not interned.");

            string c = String.Copy(a);
            if (String.ReferenceEquals(a, c))
                Console.WriteLine("a and c are interned.");
            else
                Console.WriteLine("a and c are not iinterned.");
        }

         class Animal
        {
            public void Eat()
            {
                Console.WriteLine("Eating.");
            }
            public override string ToString()
            {
                return "I am an animal";
            }

        }
        class Mammal : Animal { }
        class Griaffe : Mammal { }
        class SuperNova { }

        static void Str_IsAndAs_1()
        {
            Griaffe g = new Griaffe();
            FeedMammals(g);

            SuperNova sn = new SuperNova();
            TestForMammals(sn);

            void FeedMammals(Animal a)
            {
                if(a is Mammal m)
                {
                    m.Eat();
                }
            }
            void TestForMammals(object o)
            {
                if(o is Mammal m)
                {
                    Console.WriteLine(m.ToString());
                }
                else
                {
                    Console.WriteLine($"{o.GetType().Name} is not a Mammal ");
                }
            }
        }

        static void Str_IsAndAs_2()
        {
            { 
            // Use the as operator with a value type.
            // Note the implicit conversion to int? in 
            // the method body.
            int i = 5;
            PatternMatchingNullable(i);

            int? j = null;
            PatternMatchingNullable(j);

            double d = 9.78654;
            PatternMatchingNullable(d);

            PatternMatchingSwitch(i);
            PatternMatchingSwitch(j);
            PatternMatchingSwitch(d);

            }

            void PatternMatchingNullable(System.ValueType val)
            {
                if (val is int j) // Nullable types are not allowed in patterns
                {
                    Console.WriteLine(j);
                }
                else if (val is null) // If val is a nullable type with no value, this expression is true
                {
                    Console.WriteLine("val is a nullable type with the null value");
                }
                else
                {
                    Console.WriteLine("Could not convert " + val.ToString());
                }
            }

             void PatternMatchingSwitch(System.ValueType val)
            {
                switch (val)
                {
                    case int number:
                        Console.WriteLine(number);
                        break;
                    case long number:
                        Console.WriteLine(number);
                        break;
                    case decimal number:
                        Console.WriteLine(number);
                        break;
                    case float number:
                        Console.WriteLine(number);
                        break;
                    case double number:
                        Console.WriteLine(number);
                        break;
                    case null:
                        Console.WriteLine("val is a nullable type with the null value");
                        break;
                    default:
                        Console.WriteLine("Could not convert " + val.ToString());
                        break;
                }
            }
        }

        static void Str_IsAndAs_3()
        {
             {
                
                // Use the is operator to verify the type.
                // before performing a cast.
                Griaffe g = new Griaffe();
                UseIsOperator(g);

                // Use the as operator and test for null
                // before referencing the variable.
                UseAsOperator(g);

                // Use the as operator to test
                // an incompatible type.
                SuperNova sn = new SuperNova();
                UseAsOperator(sn);

                // Use the as operator with a value type.
                // Note the implicit conversion to int? in 
                // the method body.
                int i = 5;
                UseAsWithNullable(i);

                double d = 9.78654;
                UseAsWithNullable(d);
            }

             void UseIsOperator(Animal a)
            {
                if (a is Mammal)
                {
                    Mammal m = (Mammal)a;
                    m.Eat();
                }
            }

             void UsePatternMatchingIs(Animal a)
            {
                if (a is Mammal m)
                {
                    m.Eat();
                }
            }

             void UseAsOperator(object o)
            {
                Mammal m = o as Mammal;
                if (m != null)
                {
                    Console.WriteLine(m.ToString());
                }
                else
                {
                    Console.WriteLine($"{o.GetType().Name} is not a Mammal");
                }
            }

             void UseAsWithNullable(System.ValueType val)
            {
                int? j = val as int?;
                if (j != null)
                {
                    Console.WriteLine(j);
                }
                else
                {
                    Console.WriteLine("Could not convert " + val.ToString());
                }
            }
        }
        static void Main(string[] args)
        {
            //Str_split_1();
            //Str_split_2();
            //Str_split_3();
            //Str_concatenation_1();
            //Str_concatenation_2();
            //Str_concatenation_3();
            //Str_concatenation_4();
            //Str_datetime_1();
            //Str_datetime_2();
            //Str_search_1();//contains,startwith,endswith
            //Str_search_2();//regex
            //Str_search_3();
            //Str_modify_1();//replace
            //Str_modify_2();
            //Str_modify_3();//trim
            //Str_modify_4();//remove
            //Str_modify_5();regex
            //Str_modify_6();//char array
            //Str_modify_7();//unsafe
            //Str_compare_1();//equals(),eqquals(,StringComparisoin.Ordinal),compareTo
            //Str_compara_2();//ignoreCase
            //Str_compare_3();//invariant culture
            //Str_compare_4();//Compare(,,Globalization.CompareOptions.IngoreNonSpace),StringComparision.CurrentCulture)
            //Str_compare_5();//StringComparer.ordinal or CurrentCulture.       
            //Str_compare_6();//StringComparer.Ordinal 
            //Str_compare_7();//Binary search
            //Str_compare_8();//Ordinal sorting and searching in collections
            //Str_compare_9();//sorting in collection then binary search
            //Str_compare_10();//reference equals
            //Str_IsAndAs_1();//safely cast by using pattern matching is and as operators
            //Str_IsAndAs_2();// null type checking
            //Str_IsAndAs_3();//test if a variable is of a given type
        }



    }
}

