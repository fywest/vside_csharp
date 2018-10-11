using System;
using System.Collections;
using System.Collections.Generic;

namespace BankSystem
{
    public class Bank:IPrintable
    {


        //public BankType banktype;
        List<Account> accounts;
        private string adminPwd { get; set; }


        public Bank()
        {

            accounts = new List<Account>();
           // this.banktype = banktype;

        }



        //添加账户
        public Account OpenAccount(Account account)
        {
            //Account account = new Account(id, pwd, money);
            accounts.Add(account);
            //   account.PrintInfo();
            return account;
        }

        //删除账户
        public bool CloseAccount(Account account)
        {
            int idx = accounts.IndexOf(account);
            if (idx < 0) return false;
            accounts.Remove(account);
            return true;
        }

        public bool Accountdisable(Account account)
        {
            int idx = accounts.IndexOf(account);
            if (idx < 0) return false;
            account.Valid = false;
            return true;
        }

        public bool AccountEnable(Account account)
        {
            int idx = accounts.IndexOf(account);
            if (idx < 0) return false;
            account.Valid = true;
            return true;
        }

        //是否有相同账户
        public bool IsExist(string id)
        {
            foreach (Account account in accounts)
            {
                if (account.Id==id)
                {
                    return true;
                }
            }

            return false;
        }

        //进入账户
        public Account FindAccount(string id, string pwd)
        {
            foreach (Account account in accounts)
            {
                if(account.IsMatch(id,pwd))
                {
                    return account;
                }
            }

            return null;
        }

        //显示银行信息

        void IPrintable.IPrint()
        {
            Console.WriteLine("************" + "  bank " + " info  ************ ");
            Console.WriteLine("bank"+"\t" + "account  "+"\t"+"id "+"\t" + "pwd " + "\t" + "money "+"\t" + "status " + "\t" + "limit " + "\t" + "credit " + "\t" + "type ");
            foreach (Account account in accounts)
            {
                //Console.WriteLine("***"+" bank "+" info*** ");
                //Console.WriteLine("   bank    : " + account.banktype);
                //Console.WriteLine("   id      : " + account.Id);
                //Console.WriteLine("   pwd     : " + account.Pwd);
                //Console.WriteLine("   money   : " + account.Money);
                //Console.WriteLine("*******************\n");

                if(account is CreditCard)
                {
                    CreditCard a = (CreditCard)account;
                    Console.WriteLine(account.banktype + "\t" + "CreditCard" + "\t" + a.Id + "\t" + a.Pwd + "\t" + a.Money + "\t" + a.Valid+"\t" + a.Limit+"\t" + a.Credit+"\t" + a.Type);
                }
                else if(account is Account)
                {
                    Console.WriteLine(account.banktype + "\t" + "normal    " + "\t" + account.Id + "\t" + account.Pwd + "\t" + account.Money + "\t" + account.Valid);
                    
                }
                
            }
            Console.WriteLine("**************************************\n");
        }
    }
}
