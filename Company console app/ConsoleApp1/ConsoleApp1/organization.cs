using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Organization
    {
        //поля
        string name = "VALVE";
        string[] spisok = null;
        double[] nalogs = null;
        //свойства
        //свойства поля name
        public string Name
        {
            set { if (value.Length > 2) name = value; }
            get { return name[0].ToString().ToUpper() + name.Substring(1, name.Length - 1).ToLower(); }
        }
        //свойства поля spisok
        public string Spisok
        {
            get
            {
                if (spisok != null && spisok.Length > 0)
                {
                    string s = "\nCписок вакантных должностей";
                    foreach (var x in spisok) s += $"\n {x,1}";
                    return s;
                }
                else return "\nСвободных вакансий нет";
            }
        }
        public string Nalogs
        {
            get
            {
                if (nalogs != null && nalogs.Length > 0)
                {
                    string s = "\nСписок всех выплат по налогам";
                    foreach (var x in nalogs) s += $"\n {x,1}";
                    return s;
                }
                else return "\nВыплаты отсутствуют";

            }
        }
        public double Sum
        {
            get
            {
                double sum = 0.0;
                if (nalogs != null && nalogs.Length > 0)
                {
                    
                    foreach (var x in nalogs) sum += x;
                    return sum;
                }
                else return 0.0;
            }
        }
        public Organization(string A = "org1")
        {
            Name = A;
        }
        public Organization(string[] B = null, double[] C = null)
        {
            spisok = B;
            nalogs = C;
        }
        public void Set(params string[] a)
        {
            if (a != null && a.Length > 0)
            {
                spisok = new string[a.Length];
                a.CopyTo(spisok, 0);
            }

        }
        public void Set(double[] a)
        {
            if (a != null && a.Length > 0)
            {
                nalogs = new double[a.Length];
                a.CopyTo(nalogs, 0);
            }
        }
        public void Print()
        {
            Console.Write($"\nНазвание:{Name}\n{Spisok}\n{Nalogs}");
            Console.Write($"\nОбщая сумма всех выплат:\n{Sum}");
        }
        public void Set()
        {
            Console.Write("\nНазвание организации:");
                Name = Console.ReadLine();
            Console.Write("\nCписок вакансий:\n");
            string v = Console.ReadLine();
            string[] v1 = v.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            spisok = new string[v1.Length];
            int l = 0;
            foreach (var y in v1)
                spisok[l++] = Convert.ToString(y);



            Console.Write("\nВыплаты по налогам:\n");
            string s = Console.ReadLine();
            string[] s1 = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            nalogs = new double[s1.Length];
            int j = 0;
            foreach (var x in s1)
                nalogs[j++] = Convert.ToDouble(x);
        }  
    }
}
