using System;
using System.Collections;

namespace BankSystem
{
    public class Account : IPayment,IPrintable
    {
        public BankType banktype;
        double money; //decimal money;

        double[] data = { 100, 200, 300, 400 };
        string[] foreignCurrency = { "JPY", "USD", "EUR", "GBP" };

        string id;
        string pwd;
        public bool Valid { set; get; }

        public Account(BankType banktype,string id, string pwd, double money)
        {
            //if( money < 0 ) throw new Exception("....");
            this.banktype = banktype;
            this.Id = id;
            this.Pwd = pwd;
            this.Money = money;
            this.Valid = true;
        }

   

        public string Id
        {
            get => id;
            set
            {
                id = value;
            }
        }

        public double Money
        {
            get => money;
            set
            {
                if (value < 0)
                {
                    try
                    {
                        throw new ArgumentOutOfRangeException(
                        $"{nameof(value)} must be great or equal 0.");

                    }
                    catch (ArgumentOutOfRangeException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }

                money = value;
            }
        }


        //外币索引
        public double this[int idx]
        {
            set
            {
                if (idx >= 0 && idx < data.Length)
                    data[idx] = value;
            }
            get
            {
                if (idx >= 0 && idx < data.Length)
                    return data[idx];
                return 0;
            }
        }

        public double this[string foreigncurrency]
        {
            set
            {
                int idx = FindKey(foreigncurrency);
                this[idx] = value;
            }
            get
            {
                return this[FindKey(foreigncurrency)];
            }
        }

        public int FindKey(string foreigncurrency)
        {
            for (int i = 0; i < foreignCurrency.Length; i++)
                if (foreignCurrency[i] == foreigncurrency) return i;
            return -1;
        }


        public string Pwd
        {
            get => pwd;
            set
            {
                pwd = value;
            }
        }

        //存款
        public bool SaveMoney(double money)
        {
            if (money < 0) return false;  //卫语句

            this.Money += money;
            return true;
        }

        //取款
        public virtual bool WithdrawMoney(double money)
        {


            if (this.Money >= money)
            {
                this.Money -= money;

                return true;
            }
            else
            {
                return false;
            }


        }

        

        //密码检查
        public bool IsMatch(string id, string pwd)
        {

            return id == this.id && pwd == this.pwd;

        }

        //付款接口
        bool IPayment.Payment(double pay)
        {
            {
               // Console.WriteLine("account pay" + pay);
                if (this.Money >= pay)
                {
                    this.Money -= pay;
                    return true;
                }

                return false;

            }
        }
        //显示账户信息,显示外币信息
        void IPrintable.IPrint()
        {
            Console.WriteLine("***account info*** ");
            Console.WriteLine("   bank    : " + this.banktype);
            Console.WriteLine("   id      : " + this.Id);
            //Console.WriteLine("   pwd     : " + this.Pwd);
            Console.WriteLine("   money   : " + this.Money);
            for (int i = 0; i < foreignCurrency.Length; i++)
            {
                Console.WriteLine("   " + this.foreignCurrency[i] + "     : " + this[i]);
            }

            Console.WriteLine("*******************\n");
        }
    }
}