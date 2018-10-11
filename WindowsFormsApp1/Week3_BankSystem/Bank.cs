using System;
using System.Collections;
using System.Collections.Generic;

public class Bank {

    
    
	List<Account> accounts;
    private string name;

    public Bank(string name)
    {

        accounts = new List<Account>();
        Name = name;

    }

    public string Name
    {
        get => name;
        set
        {
            name = value;
        }
    }

    //添加账户
    public Account OpenAccount(Account account)
	{
		//Account account = new Account(id, pwd, money);
		accounts.Add( account );
   //   account.PrintInfo();
		return account;
	}

    //删除账户
    public bool CloseAccount( Account account) 
	{
		int idx = accounts.IndexOf(account);
		if( idx<0 )return false;
		accounts.Remove(account);
		return true;		
	}

    //进入账户
    public Account FindAccount(string id, string pwd)
	{
		foreach(Account account in accounts)
		{
			if( account.IsMatch(id, pwd))
			{
				return account;
			}
		}

		return null;
	}

    //显示账户信息
    public void showAccount()
    {
        foreach (Account account in accounts)
        {
            account.PrintInfo();
        }
    }
	
}
