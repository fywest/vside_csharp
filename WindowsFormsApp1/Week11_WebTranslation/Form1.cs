using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Text.RegularExpressions;

namespace WebTranslation
{

    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        //翻译按钮双击事件
        private void btnTranslate_Click(object sender, EventArgs e)
        {
            //清除输出窗口
            rtxTo.Clear();
            rtxTo2.Clear();

            //布尔变量标识是否有汉字
            bool isChinese = false;

            string text = rtxFrom.Text;
            for (int i = 0; i < text.Length; i++)
            {
                //正则检查汉字
                if (Regex.IsMatch(text[i].ToString(), @"^[\u4e00-\u9fa5]{0,}$"))
                {
                    isChinese = true;
                    continue;
                }

            }
            if(isChinese)
            {
                //创建线程
                Test obj1 = new Test();
                Test obj2 = new Test();

                obj1.from = rtxFrom.Text;
                obj2.from = rtxFrom.Text;

                Thread thread1 = new Thread(new ThreadStart(obj1.fun));
                Thread thread2 = new Thread(new ThreadStart(obj2.fun2));

                thread1.Start();
                thread2.Start();

                thread1.Join();
                thread2.Join();

                
                rtxTo.Text = TranslationOp.str1;
                rtxTo2.Text = TranslationOp.str2;
            }
            else
            {
                rtxFrom.Clear();
                MessageBox.Show("请输入汉字！");
            }


        }

        //清除按钮双击事件
        private void btnClear_Click(object sender, EventArgs e)
        {

            rtxFrom.Clear();
            rtxTo.Clear();
            rtxTo2.Clear();
            TranslationOp.str1 = "";
            TranslationOp.str2 = "";

        }


    }

    //类所为多线程对象
    public class Test
    {
        public string from;
        public string str;
        public void fun()
        {

            str = TranslationOp.translation(from, Language.zh, Language.en);

            TranslationOp.str1 = str;
        }
        public void fun2()
        {
            str = TranslationOp.translation(from, Language.zh, Language.cht);
            TranslationOp.str2 = str;
        }

    }
}
