using System;
using System.Collections;

public class ATM {
	
	Bank bank;
    private string location;

    public ATM( Bank bank,string location)
	{
		this.bank = bank;
        this.Location = location;
	}

    public string Location
    {
        get => location;
        set
        {
            location = value;
        }
    }//////////////////


    //循环处理交易直到用户退出
    public void Transaction()
	{

        Show("**** Welcome "+bank.Name+" ATM in "+this.Location+"*****");

        Show("please insert your card");
        string id = GetInput();

        Show("please enter your password");
        string pwd = GetInput();

        Account account = bank.FindAccount(id, pwd);

        if (account == null)
        {
            Show("card invalid or password not corrent");
            return;
        }

        
        do
        {

           Show("1: display; 2: save; 3: withdraw  4: exit");
            string op = GetInput();
            if (op == "1")
            {
                Show("balance: " + account.Money);
            }
            else if (op == "2")
            {
                Show("save money");
                string smoney = GetInput();
                double money = double.Parse(smoney);

                bool ok = account.SaveMoney(money);
                if (ok) Show("ok");
                else Show("eeer");

                Show("balance: " + account.Money);
            }
            else if (op == "3")
            {
                Show("withdraw money");
                string smoney = GetInput();
                double money = double.Parse(smoney);

                bool ok = account.WithdrawMoney(money);
                if (ok) Show("ok");
                else Show("eeer");

                Show("balance: " + account.Money);

            }
            else if(op=="4")
            {
                break;
            }

            Console.WriteLine("\n");
        } while (true);

        Show("********Thank you and Please take card *********");
    }


    //显示信息
    public void Show(string msg)
	{
		Console.WriteLine(msg);
	}
	public string GetInput()
	{
		return Console.ReadLine();// 输入字符
	}
}
