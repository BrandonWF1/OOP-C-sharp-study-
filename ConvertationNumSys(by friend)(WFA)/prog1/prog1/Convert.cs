﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog1
{
    public static class baseConvert
    {
        public static int to_10(string snum, int nbase)
        {
            if (nbase < 2) nbase = 2;
            if (nbase > 36) nbase = 36;
            try
            {
                int ndigit = snum.Length - 1;
                int result = 0;
                foreach (int x in snum.ToUpper())
                {
                    if (x <= '9' && x >= '0')
                        result += (int)((int)(x - '0') * Math.Pow(nbase, ndigit--));
                    if (x <= 'Z' && x >= 'A')
                        result += (int)((x - 'A' + 10) * Math.Pow(nbase, ndigit--));
                }
                return result;
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
                return 0;
            }
        }
        public static string from_10(int N, int nbase)
        {
            if (nbase < 2) nbase = 2;
            if (nbase > 36) nbase = 36;
            try
            {
                string result = "";
                while (N > 0)
                {
                    int rem = N % nbase;
                    N = N / nbase;
                    if (rem <= 9 && rem >= 0)
                        result = rem.ToString() + result;
                    if (rem < 36 && rem > 9)
                        result = ((char)(rem - 10 + 'A')).ToString() + result;
                }
                return result;
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
                return "0";
            }
        }
        public static string number_sys(string s1, int n1, int n2)
        {
            return from_10(to_10(s1, n1), n2);
        }
    }
}
