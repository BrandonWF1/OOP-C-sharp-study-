using System;

namespace ConvertationDZNesterov402Console
{


    public static class Convertation
    {
        public static int to_10(string s1, int n1)
        {
            if (n1 < 2) n1 = 2;
            if (n1 > 36) n1 = 36;


            try
            {
                int step = s1.Length - 1;

                int result = 0;
                foreach (var x in s1.ToUpper())
                {
                    if (x <= '9' && x >= '0')
                        result += (int)((int)(x - '0') * Math.Pow(n1, step--));
                    if (x <= 'Z' && x >= 'A')
                        result += (int)((int)(x - 'A' + 10) * Math.Pow(n1, step--));
                }
                return result;
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
                return 0;
            }
        }
        public static string from_10(int N, int n1)
        {
            if (n1 < 2) n1 = 2;
            if (n1 > 36) n1 = 36;

            try
            {
                string result = "";
                while (N > 0)
                {
                    int rem = N % n1;
                    N = N / n1;
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
        class Program
        {
            static void Main(string[] args)
            {
                string a = "fA";
                /*Console.WriteLine($"\n{a} из 16 в 10: {Convertation.to_10(a, 16)} и обратно: {Convertation.from_10(Convertation.to_10(a, 16), 16)}");*/
                a = "100";
                Console.WriteLine($"\n{a} из 2 в 8: {Convertation.number_sys(a,2,8)} и из 10 в 36: {Convertation.number_sys(a, 10, 36)}");
                Console.ReadKey();
            }
        }
    
}
