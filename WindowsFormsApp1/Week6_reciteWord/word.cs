using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reciteWord1
{
    class Word
    {
        public string _id;
        public string _english;
        public string _chinese;
        public string _phonetic;
        public bool _status=false;
        public Word(string id,string en,string ch,string ph)
        {
            _id = id;
            _english = en;
            _chinese = ch;
            _phonetic = ph;
        }
    }
}
