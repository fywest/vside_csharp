using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankSystem
{
    public class BadCashException : ApplicationException
    {
        public BadCashException(string message)
        : base(message)
        { }
    }

    public class CashException : ApplicationException
    {
        public CashException(string message)
        : base(message)
        { }

        public CashException(string message, Exception inner)
        : base(message, inner)
        { }
    }

    public class Cash
    {
        public static void GetCash()
        {
            Random ran = new Random();
            int a = ran.Next(30);
            //Console.WriteLine(a);
            if (a<=10)
            {
                throw new BadCashException("bad cash occur");
            }
                
        }
    }
}