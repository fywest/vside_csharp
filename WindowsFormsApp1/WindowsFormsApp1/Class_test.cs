using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApp1
{
    public class Class_test
    {
        private int field_test;

        public int Property_test
        {
            get => default(int);
            set
            {
            }
        }
    }

    internal delegate void Delegate_test();

    public interface Interface_test
    {
    }

    public class Class_test_sub : Class_test
    {
    }
}