using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10_BinaryNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int n = Convert.ToInt32(Console.ReadLine());
            
            // Initialize result 
            int count = 0;

            // Count the number of iterations 
            // to reach x = 0. 
            while (n != 0)
            {

                // This operation reduces length 
                // of every sequence of 1s by one. 
                //the length of 1 equal count when the loop finish
                n = (n & (n << 1));

                count++;
            }

            Console.WriteLine(count);



        }
    }      
}
