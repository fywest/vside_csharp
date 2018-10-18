using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace smartrac_sw
{
    public struct Test_Command
    {
        private string _manufacture, _type, _commands;

        public Test_Command(string manufacture, string type, string commands)
        {
            _manufacture = manufacture;
            _type = type;
            _commands = commands;
            //throw new System.NotImplementedException();
        }
    }
}