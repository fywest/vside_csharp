using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

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
            Str_modify_7();//unsafe
        }



    }
}

