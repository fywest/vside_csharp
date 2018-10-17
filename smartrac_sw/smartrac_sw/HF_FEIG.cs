using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace smartrac_sw
{
    public class HF_FEIG:HF_Reader
    {
        public HF_FEIG(string manufacturer, string model, double txPower) : base(manufacturer, model, txPower)
        {

        }

        public string SelectCommand()
        {
            string msg = "";

            using (var sr = new StreamReader("SWT_HF_TEST_COMMANDS.cfg"))
            {

                string line;
                char[] delimiterChars = { '\t' };//{ ' ', ',', '.', ':', '\t' };
                string[] manufacture = new string[15];
                string[] type = new string[15];
                string[] commands = new string[15];
                int index = 0;
                while (sr.Peek() > 0)
                {
                    line = sr.ReadLine();
                    // process the file line by line
                    string[] words = line.Split(delimiterChars);
                    manufacture[index] = words[0];
                    type[index] = words[1];
                    commands[index] = words[4];


                    //msg += line+"\n";
                    msg += manufacture[index] + "\t" + type[index] + "\t" + commands[index] + "\n";

                    index++;
                }

            }
            return msg;
            //throw new System.NotImplementedException();
        }
    }
}