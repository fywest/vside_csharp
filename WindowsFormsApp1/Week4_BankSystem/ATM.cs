using System;
using System.Collections;

namespace BankSystem
{

    public delegate void BigMoneyFetchedHandler(object sender, BigMoneyFetchedEventArgs e); //����ί��

    public class BigMoneyFetchedEventArgs//�����¼�������
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

        public event BigMoneyFetchedHandler BigMoneyFetched;//�����¼�

        public ATM(Bank bank, string location)
        {
            this.bank = bank;
            this.Location = location;
        }





        //ѭ��������ֱ���û��˳�
        public void Transaction()
        {
            Console.Clear();
            bool loop = true;

            Show("\n\n**** ��ӭʹ�� ATM ���� " + this.Location + "*****");
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
                Show("card invalid �˿��Ѿ����ᣬ����ϵ��̨��Ա");
                System.Threading.Thread.Sleep(2000);
                return;
            }
            do
            {

                Show("1: ��ѯ; 2: ���; 3: ȡ��  4:�������� 5:��ӡƾ��");
                string op = GetInput();

                switch (op)
                {


                    case "1"://  ��ѯ
                        {
                            //Show("balance: " + account.Money);
                            ((IPrintable)account).IPrint();
                        }
                        break;
                    case "2"://  ���
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
                    case "3"://  ȡ��
                        {
                            Show("withdraw money");
                            string smoney = GetInput();
                            double money = double.Parse(smoney);

                            if (money>=10000&&account.Money>=10000) //�¼�����
                            {
                                BigMoneyFetched(this, new BigMoneyFetchedEventArgs(account.Id, money));//�����¼�
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
                                Console.WriteLine("�������쳣�� {0}", e.Message);
                                Console.WriteLine("�ڲ�ԭ�� {0}", e.InnerException.Message);
                                Console.WriteLine("����ϵ���й�����Ա");

                            }

                            Show("balance: " + account.Money);
                        }
                        break;
                    case "4"://  ��������
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
                    case "5"://  ��ӡƾ��
                        {
                            ((IPrintable)account).IPrint();
                        }
                        break;
  
                }
                Console.WriteLine("\n");

                Show("\n\n 1: ����  2: ������һ���˵� ");
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


        //��ʾ��Ϣ
        public void Show(string msg)
        {
            Console.WriteLine(msg);
        }
        // �����ַ�
        public string GetInput()
        {
            return Console.ReadLine();
        }

    }
}
