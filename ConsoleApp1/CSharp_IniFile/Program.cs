using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

namespace CSharp_Smartrac
{
    
    class Program
    {

        public static string strFilePath = Path.Combine(Environment.CurrentDirectory, "config.ini");

        static void inifile_test()
        {
            Console.WriteLine(strFilePath);

            string strSection = "Section2";
            string strSectionKey = "Item2";
            string strValue = "hello123456";
            string strResult = "";

            IniFile.WriteValue(strSection, strSectionKey, strValue, strFilePath);
            strResult = IniFile.ReadValue(strSection, strSectionKey, strFilePath);
            Console.WriteLine(strResult);
        }

        static void WriteValues()
        {
            using (var writer = new CsvFileWriter("WriteTest.csv"))
            {
                // Write each row of data
                for (int row = 0; row < 100; row++)
                {
                    // TODO: Populate column values for this row
                    List<string> columns = new List<string>();
                    columns.Add(row.ToString());
                    writer.WriteRow(columns);
                }
            }
        }

         static void ReadValues()
        {
            List<string> columns = new List<string>();
            using (var reader = new CsvFileReader("ReadTest.csv"))
            {
                while (reader.ReadRow(columns))
                {
                    // TODO: Do something with columns' values
                    foreach(var item in columns)
                    {
                        Console.Write(item+" ");
                    }
                   
                }
            }
        }

        static void Main(string[] args)
        {

            //inifile_test();
            //WriteValues();
            ReadValues();
            Console.ReadKey();
        }
        
    }
}
