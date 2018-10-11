using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace reciteWord1
{
    public class WordLibrary
    {
       string _name;
        internal List<Word> wordlist = new List<Word>();


        public WordLibrary(string name)
        {
            _name = name;
        }

        public void ReadFile()
        {
            StreamReader sw = new StreamReader("College_Grade4.txt", Encoding.Default);
            
            string content = sw.ReadToEnd();
            string[] lines = content.Split('\n');
            for (int i = 0; i < lines.Length; i++)
            {
                string[] words = lines[i].Trim().Split('\t');
                //    foreach(string s in words)
                //{
                //        MessageBox.Show(s);
                //}
                if (words.Length < 3)
                { continue; }
                Word word = new Word(i.ToString(),words[0], words[1], words[2]);
                wordlist.Add(word);

                //  MessageBox.Show(words[0]+"\t"+ words[1]);
            }

        }


    }

}
