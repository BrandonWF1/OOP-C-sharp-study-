using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 A = new Class1("Починка");
            A.Set("Петров","Сидоров","Иванов");
            double[] a = new double[] { 10.5, 7.1, 22.8, 32.2 };
            A.Set(a);
            A.Print();
            Class1 B = new Class1("");
            B.Set();
            B.Print();
            Console.ReadKey();
        }
    }
}
