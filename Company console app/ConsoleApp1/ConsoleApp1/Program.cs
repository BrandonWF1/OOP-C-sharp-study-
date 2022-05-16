using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Organization A = new Organization("Artem Klimax");
            A.Set("boss","zam","beginner","rookie");
            double[] a = new double[] { 10.5, 7.1, 22.8, 32.2 };
            A.Set(a);
            A.Print();

            Organization B = new Organization(new string[] { "down", "tex" }, new double[] { 1.0, 2.0 });
            B.Print();
            Console.ReadKey();
            Organization C = new Organization("");
            C.Set();
            C.Print();
            Console.ReadKey();

        }
    }
}
