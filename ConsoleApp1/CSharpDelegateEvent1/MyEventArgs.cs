using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDelegateEvent1
{
    class MyEventArgs:EventArgs
    {
        private char keyChar;
        public MyEventArgs(char keychar)
        {
            this.keyChar = keychar;
        }
        public char KeyChar
        {
            get
            {
                return keyChar;
            }
        }

    }

    class MyStrEventArgs : EventArgs
    {
        private string keyChar;
        public MyStrEventArgs(string keychar)
        {
            this.keyChar = keychar;
        }
        public string KeyChar
        {
            get
            {
                return keyChar;
            }
        }

    }
}
