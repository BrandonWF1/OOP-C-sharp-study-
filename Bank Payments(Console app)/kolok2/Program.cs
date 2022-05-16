using System;

namespace kolok2
{
    public class Payment
    {

        public DateTime date;
        double sum = 0.0;
        double[] otchislenia = null;

        //свойства
        public double Sum
        {
            get { return sum; }
            set { sum = (value > 0.0) ? value : 0.0; }
        }
        public string Otchislenia
        {
            get
            {
                if (otchislenia != null)
                {
                    try
                    {
                        string s = "";
                        foreach (var x in otchislenia)
                            s += " " + Convert.ToString(x);
                        return s;

                    }
                    catch (Exception ex)
                    {
                        Console.Write(ex.Message);
                    }
                }
                return "";
            }
            set
            {
                try
                {
                    string[] s = value.Split(new char[] { ' ', ':' }, StringSplitOptions.RemoveEmptyEntries);
                    otchislenia = new double[s.Length];
                    for (int i = 0; i < s.Length; i++)
                    {
                        otchislenia[i] = Convert.ToDouble(s[i]);
                    }
                }
                catch (Exception ex)
                {
                    Console.Write(ex.Message);
                    otchislenia = null;
                }
            }
        }

        public Payment(double sum = 0.0)
        {
            date = DateTime.Now;
            this.sum = Sum;
        }

        public void print()
        {
            Console.Write($"\nDate: {date}\nSum: {Sum}\nOtchislenia: {Otchislenia}");
        }
        public void set()
        {
            Console.Write("\nSet sum: ");
            double d;
            if (double.TryParse(Console.ReadLine(), out d))
            {
                Console.Write("\nsum changed");
            }
            else { sum = 0.0; }
            Console.Write("\nSet otchislenia using space: ");
            Otchislenia = Console.ReadLine();
        }
    }


    public enum Aim { none = 0, перевод = 1, возврат = 2}
    public class PhizPayment : Payment
    {
        public string name2 = "none";
        public double[] previous_payments;
        public Aim aim = Aim.none;

        public PhizPayment(double sum = 0.0, string name = "", Aim aim = Aim.none) : base(sum)
        {
            this.name2 = name;
            this.aim = aim;
        }

        public string Previous_payments
        {
            set
            {
                try
                {
                    string[] s = value.Split(new char[] { ' ', ':' }, StringSplitOptions.RemoveEmptyEntries);
                    previous_payments = new double[s.Length];
                    for (int i = 0; i < s.Length; i++)
                    {
                        previous_payments[i] = Convert.ToDouble(s[i]);
                    }
                }
                catch (Exception ex)
                {
                    Console.Write(ex.Message);
                    previous_payments = null;
                }
            }
            get
            {
                if (previous_payments != null)
                {
                    try
                    {
                        string s = "";
                        foreach (var x in previous_payments)
                            s += " " + Convert.ToString(x);
                        return s;

                    }
                    catch (Exception ex)
                    {
                        Console.Write(ex.Message);
                    }
                }
                return "";
            }
        }

        new public void print()
        {
            Console.Write($"\nDate: {date}\nSum: {Sum}\nOtchislenia: {Otchislenia}\n2nd name: {name2}\nPrevious payments: {Previous_payments}\nAim: {aim}\n");
        }
        new public void set()
        {
            base.set();
            Console.Write("\nSet 2nd name: ");
            name2 = Console.ReadLine();
            Console.Write("\nSet previous payments: ");
            Previous_payments = Console.ReadLine();
            Console.Write("\nSet aim of payments: ");
            int a;
            if (int.TryParse(Console.ReadLine(), out a))
            {
                aim = (Aim)a;
            }
        }

    }

    public class YuriPayment : Payment
    {
        string bank_name = "none";

        public string Bank_name { get; set; }

        public YuriPayment(double sum = 0.0, string Bank_name = "") : base(sum)
        {
            bank_name = Bank_name;
        }

        new public void print()
        {
            Console.Write($"\nDate: {date}\nSum: {Sum}\nOtchislenia: {Otchislenia}\nBank name: {Bank_name}\n");
        }
        new public void set()
        {
            base.set();
            Console.Write("\nSet bank name: ");
            Bank_name = Console.ReadLine();
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            PhizPayment A = new PhizPayment() { Sum = 100, Otchislenia = "15 20 25", name2 = "Ivanov", Previous_payments = "15 200 205", aim = Aim.перевод};
            A.print();
            A.set();
            A.print();
            YuriPayment B = new YuriPayment() { Sum = 256, Otchislenia = "1 2 554", Bank_name = "Tinkoff"};
            Console.Write("\n\n");
            B.print();
            B.set();
            B.print();
        }
    }
}
