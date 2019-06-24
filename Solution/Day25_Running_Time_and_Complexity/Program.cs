using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day25_Running_Time_and_Complexity
{
    class Program
    {
        static void Main(string[] args)
        {
            //get number of index
            int index = Convert.ToInt32(Console.ReadLine());
            //initialize an array to store all the value
            int[] arrNum = new int[index];
            //get values
            for (int i=0;i<index;i++)
            {
                arrNum[i] = Convert.ToInt32(Console.ReadLine());
            }
            //consider that the number is prime or not
            foreach(int e in arrNum)
            {
                int num = 0;//get the number of divisors
                //start the loop from 2. 
                for (int i = 2; i * i <= e; i++)// i must be <= e because if e = 4 => prime number
                {
                    if (e % i == 0)
                        num++;
                }
                if (num > 0 || e == 1)
                {
                    Console.WriteLine("Not prime");
                }
                else if (num == 0)
                {
                    Console.WriteLine("Prime");
                }
            }
            Console.ReadLine();

        }
    }
}
