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

    //����˻�
    public Account OpenAccount(Account account)
	{
		//Account account = new Account(id, pwd, money);
		accounts.Add( account );
   //   account.PrintInfo();
		return account;
	}

    //ɾ���˻�
    public bool CloseAccount( Account account) 
	{
		int idx = accounts.IndexOf(account);
		if( idx<0 )return false;
		accounts.Remove(account);
		return true;		
	}

    //�����˻�
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

    //��ʾ�˻���Ϣ
    public void showAccount()
    {
        foreach (Account account in accounts)
        {
            account.PrintInfo();
        }
    }
	
}
