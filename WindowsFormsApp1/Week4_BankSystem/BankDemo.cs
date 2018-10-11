using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace BankSystem
{
    public delegate void Print(string s);
    public class BankDemo
    {

        static void ShowWarning(object sender, BigMoneyFetchedEventArgs e)
        {//定义一个方法
            {
                Console.WriteLine("\n***Big Money Fetch Warning***\n");
                Console.WriteLine("*** account " + e.Id + " Fetch " + e.Money + "***");
                Console.WriteLine("\n*****************************\n");

            }
        }

        public static void Main(string[] args)
        {

            Print pr = s => Console.WriteLine(s);


            Bank bank = new Bank();
            Account a = new Account(BankType.ICBC, "1", "1", 100);
            Account b = new Account(BankType.ICBC, "2", "2", 2);
            CreditCard c = new CreditCard(BankType.ICBC, "3", "3", 200, 100, CardType.Platinum);


            bank.OpenAccount(a);
            bank.OpenAccount(b);
            bank.OpenAccount(c);

            //bank.showAccount();
            //((IPrintable)bank).IPrint();



            ATM atm = new ATM(bank, "Beijing City");



            ((IPayment)c).Payment(20);//接口方法处理消费付款
            c.Type = CardType.Golden;//枚举赋值
            //((IPrintable)c).IPrint();

            b["USD"] = 29;//外币赋值
            ((IPayment)b).Payment(2);
            //((IPrintable)b).IPrint();
            //((IPrintable)a).IPrint();


            //atm.Transaction();//循环处理交易直到用户退出

            //***************************************************************************************************


            atm.BigMoneyFetched += new BigMoneyFetchedHandler(ShowWarning); //注册事件

            string op;
            while (true)
            {
                System.Threading.Thread.Sleep(1000);
                Console.Clear();
                pr("\n\n\n             银行服务系统           \n\n\n");
                pr("1:柜台服务" + "\t" + "2:ATM服务" + "\t" + "3:退出");
                op = Console.ReadLine();
                if (op == "1")
                {
                    bool loop = true;
                    do
                    {


                        pr("请选择办理业务:");
                        pr("1:开户" + "\t" + "2:销户" + "\t" + "3:预览" + "\t" + "4:挂失" + "\t" + "5:解卦" + "\t");

                        string service = Console.ReadLine();
                        switch (service)
                        {

                            case "1"://  开户
                                {
                                    pr("请选择开户银行: ");
                                    pr("1:工行" + "\t" + "2:中行" + "\t" + "3:农行" + "\t" + "4:建行" + "\t" + "5:招行");
                                    string sbanktype = Console.ReadLine();

                                    int type = int.Parse(sbanktype);
                                    BankType banktype = (BankType)type;

                                    pr("请填写开户账号:");
                                    string id = Console.ReadLine();
                                    if(bank.IsExist(id))
                                    {
                                        pr("账号已经存在，请重新设定");
                                        break;
                                    }
                                    pr("请输入密码,并确认:");
                                    string pwd = Console.ReadLine();
                                    pr("请填写存款:");
                                    string smoney = Console.ReadLine();
                                    double money = double.Parse(smoney);



                                    pr("信用卡用户请输入额度,零为普通用户");
                                    string sCredit = Console.ReadLine();
                                    double credit = double.Parse(smoney);

                                    if (sCredit=="0")
                                    {
                                        Account account = new Account(banktype, id, pwd, money);
                                        

                                        if (account != null)
                                        {
                                            bank.OpenAccount(account);
                                            pr("普通账户开户成功");
                                        }
                                        else
                                        {
                                            pr("普通账户开户失败");
                                        }
                                    }
                                    else
                                    {
                                        CreditCard creditCard = new CreditCard(banktype, id, pwd, money, money, CardType.Silver, credit);
                                        if (creditCard != null)
                                        {
                                            bank.OpenAccount(creditCard);
                                            pr("信用卡账户开户成功");
                                        }
                                        else
                                        {
                                            pr("信用卡账户开户失败");
                                        }
                                    }

                                    //bank.banktype = banktype;



                                }
                                break;
                            case "2"://注销
                                {
                                    pr("请输入注销账号:");
                                    string id = Console.ReadLine();
                                    pr("请输入密码,并确认:");
                                    string pwd = Console.ReadLine();

                                    Account account;

                                    account = bank.FindAccount(id, pwd);
                                    bool ok = bank.CloseAccount(account);
                                    if (ok)
                                    {
                                        pr("注销成功");
                                    }
                                    else
                                    {
                                        pr("注销失败");

                                    }
                                }
                                break;
                            case "3"://预览
                                {
                                    ((IPrintable)bank).IPrint();
                                }
                                break;
                            case "4"://挂失
                                {
                                    pr("请输入挂失账号:");
                                    string id = Console.ReadLine();
                                    pr("请输入密码,并确认:");
                                    string pwd = Console.ReadLine();

                                    Account account;

                                    account = bank.FindAccount(id, pwd);
                                    bool ok = bank.Accountdisable(account);
                                    if (ok)
                                    {
                                        pr("挂失成功");
                                    }
                                    else
                                    {
                                        pr("挂失失败");

                                    }
                                }
                                break;
                            case "5"://解挂
                                {
                                    pr("请输入解挂账号:");
                                    string id = Console.ReadLine();
                                    pr("请输入密码,并确认:");
                                    string pwd = Console.ReadLine();

                                    Account account;

                                    account = bank.FindAccount(id, pwd);
                                    bool ok = bank.AccountEnable(account);
                                    if (ok)
                                    {
                                        pr("解挂成功");
                                    }
                                    else
                                    {
                                        pr("解挂失败");

                                    }
                                }

                                break;
                             
                        }
                        

                        pr("\n\n 1: 继续  2: 返回上一级菜单 ");
                        string answer = Console.ReadLine();
                        if(answer=="1")
                        {
                            loop = true;
                        }
                        else if(answer=="2")
                        {
                            loop = false;
                        }

                        Console.Clear();
                    } while (loop);

                }
                else if (op == "2")
                {

                    atm.Transaction();
                }
                else if (op == "3")
                {
                    break;
                }
            }

        }

    }
}

