public class BankDemo {



	public static void Main(string [] args)
	{

        Bank bank = new Bank("China Bank");
        Account a = new Account("1", "1", 100);     
        Account b = new Account("2", "2", 2);
        CreditCard c = new CreditCard("3", "3", 200, 100,CardType.Platinum);
        bank.OpenAccount(a);
        bank.OpenAccount(b);
        bank.OpenAccount(c);

        bank.showAccount();


        ATM atm = new ATM(bank,"Beijing City");

        

        IPayment Ic = c;//�ӿڷ����������Ѹ���
        Ic.Payment(20);
        c.Type= CardType.Golden;//ö�ٸ�ֵ
        c.PrintInfo();

        b["USD"] = 29;//��Ҹ�ֵ
        IPayment Ib = b;
        Ib.Payment(2);
        b.PrintInfo();

        
		atm.Transaction();//ѭ��������ֱ���û��˳�

    }
	
}
