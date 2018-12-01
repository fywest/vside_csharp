using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace CSharp_Smartrac
{
    class IniFile
    {
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

        public static string ReadValue(string strSection, string strSectionKey, string strFile)
        {
            StringBuilder temp = new StringBuilder(255);
            int i = GetPrivateProfileString(strSection, strSectionKey, "", temp, 255, strFile);
            return temp.ToString();
        }

        public static void WriteValue(string strSection, string strSectionKey, string strValue, string strFile)
        {
            WritePrivateProfileString(strSection, strSectionKey, strValue, strFile);
        }
    }
}
