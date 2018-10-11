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
using System.Threading;
using System.IO;
using System.Net;
using System.Collections;

namespace Simplewebcrawler
{
    public partial class Form1 : Form
    {
        private WebClient webClient = new WebClient();
        private Hashtable urls = new Hashtable();
        private int count = 0;
        private string info=" ";
        private string startUrl = "http://hao.360.cn";
        private string str_input= "http://hao.360.cn";
        private int index = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Crawl()
        {

            while (true)
            {
                string current = null;
                foreach (string url in urls.Keys)
                {
                    if ((bool)urls[url]) continue;
                    current = url;
                }
                if (current == null || count >50) break;

                string html = DownLoad(current);

                urls[current] = true;
                count++;

                Parse(html);
            }
                     
        }

        public string DownLoad(string url)
        {
            try
            {
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
                req.Timeout = 30000;
                HttpWebResponse response = (HttpWebResponse)req.GetResponse();
                byte[] buffer = ReadInstreamIntoMemory(response.GetResponseStream());
                string html = Encoding.UTF8.GetString(buffer);
                index++;
                richTextBox1.AppendText("爬第" + index + "个页面" + "网址: " + url + "\r\n");
                richTextBox1.Update();
                return html;
            }
            catch
            {
            }
            return "";
        }

        public void Parse(string html)
        {
            string strRef = @"(href|HREF|src|SRC)[ ]*=[ ]*[""'][^""'#>]+[""']";
            MatchCollection matches = new Regex(strRef).Matches(html);
            foreach (Match match in matches)
            {
                strRef = match.Value.Substring(match.Value.IndexOf('=') + 1).Trim('"', '\'', '#', ' ', '>');
                if (strRef.Length == 0) continue;

                if (urls[strRef] == null) urls[strRef] = false;
            }
        }

        private static byte[] ReadInstreamIntoMemory(Stream stream)
        {
            int bufferSize = 16384;
            byte[] buffer = new byte[bufferSize];
            MemoryStream ms = new MemoryStream();
            while (true)
            {
                int numBytesRead = stream.Read(buffer, 0, bufferSize);
                if (numBytesRead <= 0) break;
                ms.Write(buffer, 0, numBytesRead);
            }
            return ms.ToArray();
        }

        private void button1_Click(object sender, EventArgs e)
        {      
            clear();
            info = "开始爬行了....start from " + startUrl + "\n";
            richTextBox1.Text = info;
            richTextBox1.Update();

            urls.Add(startUrl, false);
            Crawl();
            richTextBox1.AppendText("爬行结束");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            str_input = textBox1.Text;

        }

        private void clear()
        {
            info.Remove(0);
            urls.Clear();
            richTextBox1.Clear();
            count = 0;
            index = 0;
          
        }

        private void textBox1_Validated(object sender, EventArgs e)
        {
            string Pattern = @"^(http|https|ftp)\://[a-zA-Z0-9\-\.]+\.[a-zA-Z]{2,3}(:[a-zA-Z0-9]*)?/?([a-zA-Z0-9\-\._\?\,\'/\\\+&$%\$#\=~])*$";
            Regex r = new Regex(Pattern);
            Match m = r.Match(str_input);
            if (m.Success)
            {
                startUrl = str_input;
            }
            else
            {
                MessageBox.Show("invalid URL");
            }
        }
    }
}
