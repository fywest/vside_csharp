using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace IDcardNo
{
    public partial class Form1 : Form
    {
        /// 中国公民身份证号码最大长度。
        private int CHINA_ID_MAX_LENGTH = 18;
        /// 每位加权因子
        private int[] power = new int[] { 7, 9, 10, 5, 8, 4, 2, 1, 6, 3, 7, 9, 10, 5, 8, 4, 2 };
        /// 第18位校检码
        private string[] verifyCode = new string[] { "1", "0", "X", "9", "8", "7", "6", "5", "4", "3", "2" };

        private string idCard;

        private string msg;

        private bool regexChecked = false;

        public Form1()
        {
            InitializeComponent();
        }



        /// <param name="val">要验证的字符串</param>
        private bool isNum(string str)
        {
            //正则表达式验证身份证号码
            regexChecked = Regex.IsMatch(str.ToString(), @"^[1-9]\d{5}(19|20)\d{2}((0[1-9])|(10|11|12))(([0-2][1-9])|10|20|30|31)\d{3}[0-9Xx]$");

            if (!regexChecked)
            {
                msg = msg + "  Regular Expression checking fails\n ";
                return false;
            }

                string birthday = string.Empty;
                birthday = String.Format("{0}-{1}-{2}", str.ToString().Substring(6, 4), str.ToString().Substring(10, 2), str.ToString().Substring(12, 2));

                if (DateTime.Parse(birthday) > DateTime.Now)
                {
                    msg = msg + "Birthday is newer than current time\n";
                    return false;
                }

            return true;

        }


        /// 将power和值与11取模获得余数进行校验码判断
        /// <returns>校验位</returns>
        private string getCheckCode18(int iSum)
        {
            string sCode = "";
            switch (iSum % 11)
            {
                case 10:
                    sCode = "2";
                    break;
                case 9:
                    sCode = "3";
                    break;
                case 8:
                    sCode = "4";
                    break;
                case 7:
                    sCode = "5";
                    break;
                case 6:
                    sCode = "6";
                    break;
                case 5:
                    sCode = "7";
                    break;
                case 4:
                    sCode = "8";
                    break;
                case 3:
                    sCode = "9";
                    break;
                case 2:
                    sCode = "x";
                    break;
                case 1:
                    sCode = "0";
                    break;
                case 0:
                    sCode = "1";
                    break;
            }
            return sCode;
        }

        /// 将身份证的每位和对应位的加权因子相乘之后，再得到和值
        /// <returns>身份证编码</returns>
        private int getPowerSum(string sArr)
        {
            int iSum = 0;
            int power_len = power.Length;
            int iarr_len = sArr.Length;
            if (power_len == iarr_len)
            {
                for (int i = 0; i < iarr_len; i++)
                {
                    for (int j = 0; j < power_len; j++)
                    {
                        if (i == j)
                        {
                            iSum = iSum + Convert.ToInt32(sArr.Substring(i, 1)) * power[j];
                            break;
                        }
                    }
                }
            }
            return iSum;
        }


        /// 验证18位身份编码是否合法
        /// <param name="idCard">身份编码</param>
        /// <returns>是否合法</returns>
        public bool ValidateIdCard18(string idCard)
        {
            bool bTrue = false;

            if (string.IsNullOrEmpty(idCard))
            {
                msg = msg + "Please input ID code\n";
                return false;
            }

            if (idCard.Length == CHINA_ID_MAX_LENGTH)
            {
                // 前17位
                string code17 = idCard.Substring(0,17);
                // 第18位
                string code18 = idCard.Substring(17, 1);
                //all
                string code = idCard.Substring(0, 18);
                if (isNum(code))
                {
                    string sArr = code17;
                    if (sArr.Length != 0)
                    {
                        int iSum17 = getPowerSum(sArr);
                        // 获取校验位
                        string val = getCheckCode18(iSum17);
                        if (!string.IsNullOrEmpty(val) && val == code18)
                        {
                            bTrue = true;
                        }
                        else
                        {
                            msg = msg + "checksum checking fails\n";
                        }
                    }
                }
                else
                {
                    msg = msg + " ID string checking fails\n ";
                }
            }
            else
            {
                msg = msg + "ID length checking fails ID\n";
            }


            return bTrue;
        }


        /// 验证身份证是否合法
        /// <param name="idCard">身份编码</param>
        /// <returns>是否合法</returns>
        public bool ValidateCard(string idCard)
        {
            string card = idCard.Trim();
            if (ValidateIdCard18(card))
            {
                return true;
            }


            return false;
        }

        private void txtidcard_TextChanged(object sender, EventArgs e)
        {
            lblidcardInfo.Text= txtidcard.Text.ToString();
        }

        private void btnidcard_Click(object sender, EventArgs e)
        {
            idCard = txtidcard.Text.ToString();
            if(ValidateCard(idCard))
            {
                msg ="有效号码 OK";
            }
            else
            {
                
                 msg=msg+ "号码有误 ，请检查 FAIL";

            }
            lblidcardInfo.Text = msg;
            msg = "";
        }
    }
}
