using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", n, i, n * i);
            }
        }
    }
}
