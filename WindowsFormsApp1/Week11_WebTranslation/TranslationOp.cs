﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Script.Serialization;

using System.Security.Cryptography;

namespace WebTranslation
{
     static class TranslationOp
    {
        //静态变量存储输出结果
        public static string str1;
        public static string str2;
        /// <summary>
        /// 将中文翻译为英文和繁体
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string translation(string source,Language from,Language to)
        {
            TranslationResult result = GetTranslationFromBaiduFanyi(source, from, to);
            //判断是否出错
            if (result.Error_code == null)
            {
                return result.Trans_result[0].Dst;
            }
            else
            {
                //检查appid和密钥是否正确
                return "翻译出错，错误码：" + result.Error_code + "，错误信息：" + result.Error_msg;
            }
        }

        /// <summary>
        /// 调用百度翻译API进行翻译
        /// 详情可参考http://api.fanyi.baidu.com/api/trans/product/apidoc
        /// </summary>
        /// <param name="q">待翻译字符</param>
        /// <param name="from">源语言</param>
        /// <param name="to">目标语言</param>
        /// <returns></returns>
        private static TranslationResult GetTranslationFromBaiduFanyi(string q, Language from, Language to)
        {
            //可以直接到百度翻译API的官网申请,下面的临时码很快过期
            //一定要去申请，不然程序的翻译功能不能使用
            string appId = "20171021000089916";
            string password = "jPi64nLcjhK_aSFDNo5n";

            string jsonResult = String.Empty;
            //源语言
            string languageFrom = from.ToString().ToLower();
            //目标语言
            string languageTo = to.ToString().ToLower();
            //随机数
            string randomNum = System.DateTime.Now.Millisecond.ToString();
            //md5加密
            string md5Sign = GetMD5WithString(appId + q + randomNum + password);
            //url
            string url = String.Format("http://api.fanyi.baidu.com/api/trans/vip/translate?q={0}&from={1}&to={2}&appid={3}&salt={4}&sign={5}",
                HttpUtility.UrlEncode(q, Encoding.UTF8),
                languageFrom,
                languageTo,
                appId,
                randomNum,
                md5Sign
                );
            WebClient wc = new WebClient();
            try
            {
                jsonResult = wc.DownloadString(url);
            }
            catch
            {
                jsonResult = string.Empty;
            }
            //解析json
            JavaScriptSerializer jss = new JavaScriptSerializer();
            TranslationResult result = jss.Deserialize<TranslationResult>(jsonResult);
            return result;
        }

        //对字符串做md5加密
        private static string GetMD5WithString(string input)
        {
            if (input == null)
            {
                return null;
            }
            MD5 md5Hash = MD5.Create();
            //将输入字符串转换为字节数组并计算哈希数据  
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            //创建一个 Stringbuilder 来收集字节并创建字符串  
            StringBuilder sBuilder = new StringBuilder();
            //循环遍历哈希数据的每一个字节并格式化为十六进制字符串  
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            //返回十六进制字符串  
            return sBuilder.ToString();
        }

    }

    public class Translation
    {
        public string Src { get; set; }
        public string Dst { get; set; }
    }

    public class TranslationResult
    {
        //错误码，翻译结果无法正常返回
        public string Error_code { get; set; }
        public string Error_msg { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string Query { get; set; }
        //翻译正确，返回的结果
        //这里是数组的原因是百度翻译支持多个单词或多段文本的翻译，在发送的字段q中用换行符（\n）分隔
        public Translation[] Trans_result { get; set; }
    }

    public enum Language
    {
        //百度翻译API官网提供了多种语言，这里只列了几种
        auto = 0,
        zh = 1,
        en = 2,
        cht = 3,
    }
}
