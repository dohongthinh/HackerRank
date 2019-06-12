using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day17_More_Exceptions
{
    class Calculator
    {
        int n, p;
        //Constructor
        public Calculator() { }
        public Calculator(int n, int p)
        {
            this.n = n;
            this.p = p;
        }
        //method
        public int power(int n, int p)
        {
            int pow;
            if (n<0||p<0)// if n and p <0, throw exception
            {
                throw new ArgumentException("n and p should be non-negative");
            }
            return pow = (int)Math.Pow(n, p);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculator myCalculator = new Calculator();
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                string[] num = Console.ReadLine().Split();
                int n = int.Parse(num[0]);
                int p = int.Parse(num[1]);
                try
                {
                    int ans = myCalculator.power(n, p);
                    Console.WriteLine(ans);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);

                }
            }
        }
    }
}
