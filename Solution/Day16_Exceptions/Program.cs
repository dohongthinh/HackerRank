using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16_Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            string S = Console.ReadLine();
            try
            {
                int x = Int32.Parse(S);
                Console.WriteLine(x);
            }
            catch (Exception e)
            {
                Console.WriteLine("Bad String");
            }
            Console.ReadLine();
        }
    }
}
