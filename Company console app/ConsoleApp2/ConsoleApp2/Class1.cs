using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Class1
    {
        //поля
        string name = "Техническое задание";
        string[] surnames = null;
        double[] pays = null;
        //свойства
        //свойства поля name
        public string Name
        {
            set { if (value.Length > 2) name = value; }
            get { return name[0].ToString().ToUpper() + name.Substring(1, name.Length - 1).ToLower(); }
        }
        //свойства поля spisok
        public string Surnames
        {
            get
            {
                if (surnames != null && surnames.Length > 0)
                {
                    string s = "\nCписок фамилий исполнителей";
                    foreach (var x in surnames) s += $"\n {x,1}";
                    return s;
                }
                else return "\nИсполнителей нет";
            }
        }
        public string Pays
        {
            get
            {
                if (pays != null && pays.Length > 0)
                {
                    string s = "\nСписок всех затрат";
                    foreach (var x in pays) s += $"\n {x,1}";
                    return s;
                }
                else return "\nЗатраты отсутствуют";
            }
        }
        public double Sum
        {
            get
            {
                double sum = 0.0;
                if (pays != null && pays.Length > 0)
                {

                    foreach (var x in pays) sum += x;
                    return sum;
                }
                else return 0.0;
            }
        }
        public Class1(string A = "org1")
        {
            Name = A;
        }
        public void Set(params string[] a)
        {
            if (a != null && a.Length > 0)
            {
                surnames = new string[a.Length];
                a.CopyTo(surnames, 0);
            }
        }
        public void Set(double[] a)
        {
            if (a != null && a.Length > 0)
            {
                pays = new double[a.Length];
                a.CopyTo(pays, 0);
            }
        }
        public void Print()
        {
            Console.Write($"\nНазвание:{Name}\n{Surnames}\n{Pays}");
            Console.Write($"\nОбщая сумма всех затрат:\n{Sum}");
        }
        public void Set()
        {
            Console.Write("\nНазвание задания:");
            Name = Console.ReadLine();
            Console.Write("\nCписок фамилий:\n");
            string v = Console.ReadLine();
            string[] v1 = v.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            surnames = new string[v1.Length];
            int l = 0;
            foreach (var y in v1)
                surnames[l++] = Convert.ToString(y);
        }
    }
}


