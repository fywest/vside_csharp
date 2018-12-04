using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Console_FileLine
{

    class Program
    {
        static string delComments(string s)
        {
            if (s == null)
            {
                return s;
            }

            //int pos = s.IndexOf("//");
            char[] anyOf = { '/', '#' };
            int pos = s.IndexOfAny(anyOf);
            if (pos < 0)
            {
                return s;
            }
            return s.Substring(0, pos);
        }


        static void Main(string[] args)
        {
            string infname = "CopyFileAddLineNumber.cs";
            string outfname = "CopyFIleAddLineNumber.txt";
            bool enableLineNumber = false;
            Console.WriteLine("input output linenumber(or nothing)");
            foreach (var arg in args)
            {
                Console.WriteLine(arg);
            }

            if(args.Length>=1)
            {
                infname = args[0];
            }
            if(args.Length>=2)
            {
                outfname = args[1];
            }
            if(args.Length>=3)
            {
                if(args[2].Contains("linenumber"))
                {
                    enableLineNumber = true;
                }

            }
            try
            {
                FileStream fin = new FileStream(infname, FileMode.Open, FileAccess.Read);
                FileStream fout = new FileStream(outfname, FileMode.Create, FileAccess.Write);
                StreamReader brin = new StreamReader(fin, System.Text.Encoding.Default);
                StreamWriter brout = new StreamWriter(fout, System.Text.Encoding.Default);
                int cnt = 0;
                string s = brin.ReadLine();
                while(s!=null)
                {
                    cnt++;
                    s = delComments(s);
                    if(enableLineNumber)
                    {
                        brout.WriteLine(cnt + ":\t" + s);
                        Console.WriteLine(cnt + ":\t" + s);
                    }
                    else
                    {
                        brout.WriteLine(s);
                        Console.WriteLine(s);
                    }

                    s = brin.ReadLine();

                }
                brin.Close();
                brout.Close();
            }
            catch(FileNotFoundException)
            {
                Console.WriteLine("File not found!");

            }
            catch(IOException e2)
            {
                Console.WriteLine(e2);
            }
        }
    }
}
