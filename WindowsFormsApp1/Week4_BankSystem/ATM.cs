using System;
using System.Collections;

namespace BankSystem
{

    public delegate void BigMoneyFetchedHandler(object sender, BigMoneyFetchedEventArgs e); //声明委托

    public class BigMoneyFetchedEventArgs//声明事件参数类
    {
        public string Id { get { return _id; } set { _id = value; } }
        private string _id;
        public double Money { get { return _money; } set { _money = value; } }
        private double _money;
        public BigMoneyFetchedEventArgs(string id, double money) { this._id = id; this._money = money; }
    }

    public class ATM
    {

        Bank bank;
        public string Location { set; get; }

        public event BigMoneyFetchedHandler BigMoneyFetched;//声明事件

        public ATM(Bank bank, string location)
        {
            this.bank = bank;
            this.Location = location;
        }





        //循环处理交易直到用户退出
        public void Transaction()
        {
            Console.Clear();
            bool loop = true;

            Show("\n\n**** 欢迎使用 ATM 服务 " + this.Location + "*****");
            Show("please insert your card");
            string id = GetInput();

            Show("please enter your password");
            string pwd = GetInput();

            Account account = bank.FindAccount(id, pwd);

            if (account == null)
            {
                Show("card invalid or password not correct");
                System.Threading.Thread.Sleep(1000);
                return;
            }
            if (account.Valid == false)
            {
                Show("card invalid 此卡已经冻结，请联系柜台人员");
                System.Threading.Thread.Sleep(2000);
                return;
            }
            do
            {

                Show("1: 查询; 2: 存款; 3: 取款  4:更改密码 5:打印凭条");
                string op = GetInput();

                switch (op)
                {


                    case "1"://  查询
                        {
                            //Show("balance: " + account.Money);
                            ((IPrintable)account).IPrint();
                        }
                        break;
                    case "2"://  存款
                        {
                            Show("save money");
                            string smoney = GetInput();
                            double money = double.Parse(smoney);

                            bool ok = account.SaveMoney(money);
                            if (ok) Show("save successful");
                            else Show("save money fail");

                            Show("balance: " + account.Money);
                        }
                        break;
                    case "3"://  取款
                        {
                            Show("withdraw money");
                            string smoney = GetInput();
                            double money = double.Parse(smoney);

                            if (money>=10000&&account.Money>=10000) //事件发生
                            {
                                BigMoneyFetched(this, new BigMoneyFetchedEventArgs(account.Id, money));//发生事件
                            }

                            try
                            {
                                bool ok = account.WithdrawMoney(money);

                                if (ok)
                                {
                                    try
                                    {
                                        Cash.GetCash();
                                        Show("successful ,please take your cash");
                                    }
                                    catch (BadCashException e)
                                    {
                                        throw new CashException("problem in cash", e);
                                    }
                                } 
                                else
                                {
                                    Show("no enough money . withdraw fails");
                                }
                                
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("出现了异常： {0}", e.Message);
                                Console.WriteLine("内部原因： {0}", e.InnerException.Message);
                                Console.WriteLine("请联系银行工作人员");

                            }

                            Show("balance: " + account.Money);
                        }
                        break;
                    case "4"://  更改密码
                        {
                            Show("please input new password");
                            string pwdnew = GetInput();
                            Show("please input again");
                            string pwdagain = GetInput();
                            if (pwdnew == pwdagain)
                            {
                                account.Pwd = pwdnew;
                                Show("password update succesful");
                            }
                            else
                            {
                                Show("they does not match");
                            }
                        }
                        break;
                    case "5"://  打印凭条
                        {
                            ((IPrintable)account).IPrint();
                        }
                        break;
  
                }
                Console.WriteLine("\n");

                Show("\n\n 1: 继续  2: 返回上一级菜单 ");
                string answer = Console.ReadLine();
                if (answer == "1")
                {
                    loop = true;
                }
                else if (answer == "2")
                {
                    loop = false;
                }

                Console.Clear();

            } while (loop);

            return;
        }


        //显示信息
        public void Show(string msg)
        {
            Console.WriteLine(msg);
        }
        // 输入字符
        public string GetInput()
        {
            return Console.ReadLine();
        }

    }
}
