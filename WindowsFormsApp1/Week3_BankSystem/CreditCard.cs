using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//namespace BankSystem
//{
    public enum CardType { Silver,Golden,Platinum}
    public class CreditCard : Account,IPayment
    {
        private double credit;
        private double limit;
        public CardType Type { set; get; }

        public CreditCard(string id, string pwd, double money,double limit,CardType type,double credit=0) : base(id,pwd,money)
        {
            Limit = limit;
            Credit = Limit;
            Type = type;
            
        }



        
        public double Credit
        {
            get => credit;
            set
            {
                credit = value;
            }
        }

        public double Limit
        {
            get => limit;
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
                limit = value;
            }
        }

    //取款方法 虚方法覆盖
    public override bool WithdrawMoney(double money)
        {
            if (this.Money >= money)
            {
                this.Money -= money;
                return true;
            }

            return false;
        }

    //付款接口
    bool IPayment.Payment(double pay)
    {
        Console.WriteLine("credit card pay "+pay);
        if (this.Credit >= pay)
        {
            this.Credit -= pay;
            return true;
        }

        return false;
    }


    //显示信用卡信息
    public override void PrintInfo()
        {
            Console.WriteLine("***creditCard info*** ");
            Console.WriteLine("  id       : " + Id);
            Console.WriteLine("  pwd      : " + Pwd);
            Console.WriteLine("  money    : " + Money);
            Console.WriteLine("  limit    : " + Limit);
            Console.WriteLine("  credit   : " + Credit);
            Console.WriteLine("  Cardtype : " + Type.ToString());
             Console.WriteLine("**********************\n");
        }
}
//}