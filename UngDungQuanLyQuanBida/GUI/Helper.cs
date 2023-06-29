using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    internal class Helper
    {
        public static string GetHashStringSHA512(string s)
        {
            string hashString = "";

            SHA512Managed sha512Managed = new SHA512Managed();
            byte[] hash = sha512Managed.ComputeHash(Encoding.UTF8.GetBytes(s));

            foreach (byte item in hash)
            {
                hashString += item.ToString("X2");
            }

            return hashString;
        }

        public static bool CheckAlphanumericString(string s)
        {
            foreach (char c in s)
            {
                if (c >= '0' && c <= '9')
                {
                    continue;
                }

                if (c >= 'a' && c <= 'z')
                {
                    continue;
                }

                if (c >= 'A' && c <= 'Z')
                {
                    continue;
                }

                return false;
            }

            return true;
        }

        //Kiểm tra chuỗi số dương
        public static bool CheckNumberString(string s)
        {
            foreach (char c in s)
            {
                if (c < '0' || c > '9')
                {
                    return false;
                }
            }

            return true;
        }

        //Kiểm tra chuỗi số có dấu
        public static bool CheckNumberString2(string s)
        {
            if (s[0] == '-')
            {
                for (int i = 1; i < s.Length - 1; i++)
                {
                    if (s[i] < '0' || s[i] > '9')
                    {
                        return false;
                    }
                }
            }
            else
            {
                for (int i = 0; i < s.Length - 1; i++)
                {
                    if (s[i] < '0' || s[i] > '9')
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
