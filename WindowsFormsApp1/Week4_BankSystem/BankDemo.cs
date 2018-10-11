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
        {//����һ������
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



            ((IPayment)c).Payment(20);//�ӿڷ����������Ѹ���
            c.Type = CardType.Golden;//ö�ٸ�ֵ
            //((IPrintable)c).IPrint();

            b["USD"] = 29;//��Ҹ�ֵ
            ((IPayment)b).Payment(2);
            //((IPrintable)b).IPrint();
            //((IPrintable)a).IPrint();


            //atm.Transaction();//ѭ��������ֱ���û��˳�

            //***************************************************************************************************


            atm.BigMoneyFetched += new BigMoneyFetchedHandler(ShowWarning); //ע���¼�

            string op;
            while (true)
            {
                System.Threading.Thread.Sleep(1000);
                Console.Clear();
                pr("\n\n\n             ���з���ϵͳ           \n\n\n");
                pr("1:��̨����" + "\t" + "2:ATM����" + "\t" + "3:�˳�");
                op = Console.ReadLine();
                if (op == "1")
                {
                    bool loop = true;
                    do
                    {


                        pr("��ѡ�����ҵ��:");
                        pr("1:����" + "\t" + "2:����" + "\t" + "3:Ԥ��" + "\t" + "4:��ʧ" + "\t" + "5:����" + "\t");

                        string service = Console.ReadLine();
                        switch (service)
                        {

                            case "1"://  ����
                                {
                                    pr("��ѡ�񿪻�����: ");
                                    pr("1:����" + "\t" + "2:����" + "\t" + "3:ũ��" + "\t" + "4:����" + "\t" + "5:����");
                                    string sbanktype = Console.ReadLine();

                                    int type = int.Parse(sbanktype);
                                    BankType banktype = (BankType)type;

                                    pr("����д�����˺�:");
                                    string id = Console.ReadLine();
                                    if(bank.IsExist(id))
                                    {
                                        pr("�˺��Ѿ����ڣ��������趨");
                                        break;
                                    }
                                    pr("����������,��ȷ��:");
                                    string pwd = Console.ReadLine();
                                    pr("����д���:");
                                    string smoney = Console.ReadLine();
                                    double money = double.Parse(smoney);



                                    pr("���ÿ��û���������,��Ϊ��ͨ�û�");
                                    string sCredit = Console.ReadLine();
                                    double credit = double.Parse(smoney);

                                    if (sCredit=="0")
                                    {
                                        Account account = new Account(banktype, id, pwd, money);
                                        

                                        if (account != null)
                                        {
                                            bank.OpenAccount(account);
                                            pr("��ͨ�˻������ɹ�");
                                        }
                                        else
                                        {
                                            pr("��ͨ�˻�����ʧ��");
                                        }
                                    }
                                    else
                                    {
                                        CreditCard creditCard = new CreditCard(banktype, id, pwd, money, money, CardType.Silver, credit);
                                        if (creditCard != null)
                                        {
                                            bank.OpenAccount(creditCard);
                                            pr("���ÿ��˻������ɹ�");
                                        }
                                        else
                                        {
                                            pr("���ÿ��˻�����ʧ��");
                                        }
                                    }

                                    //bank.banktype = banktype;



                                }
                                break;
                            case "2"://ע��
                                {
                                    pr("������ע���˺�:");
                                    string id = Console.ReadLine();
                                    pr("����������,��ȷ��:");
                                    string pwd = Console.ReadLine();

                                    Account account;

                                    account = bank.FindAccount(id, pwd);
                                    bool ok = bank.CloseAccount(account);
                                    if (ok)
                                    {
                                        pr("ע���ɹ�");
                                    }
                                    else
                                    {
                                        pr("ע��ʧ��");

                                    }
                                }
                                break;
                            case "3"://Ԥ��
                                {
                                    ((IPrintable)bank).IPrint();
                                }
                                break;
                            case "4"://��ʧ
                                {
                                    pr("�������ʧ�˺�:");
                                    string id = Console.ReadLine();
                                    pr("����������,��ȷ��:");
                                    string pwd = Console.ReadLine();

                                    Account account;

                                    account = bank.FindAccount(id, pwd);
                                    bool ok = bank.Accountdisable(account);
                                    if (ok)
                                    {
                                        pr("��ʧ�ɹ�");
                                    }
                                    else
                                    {
                                        pr("��ʧʧ��");

                                    }
                                }
                                break;
                            case "5"://���
                                {
                                    pr("���������˺�:");
                                    string id = Console.ReadLine();
                                    pr("����������,��ȷ��:");
                                    string pwd = Console.ReadLine();

                                    Account account;

                                    account = bank.FindAccount(id, pwd);
                                    bool ok = bank.AccountEnable(account);
                                    if (ok)
                                    {
                                        pr("��ҳɹ�");
                                    }
                                    else
                                    {
                                        pr("���ʧ��");

                                    }
                                }

                                break;
                             
                        }
                        

                        pr("\n\n 1: ����  2: ������һ���˵� ");
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

