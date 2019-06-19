using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day20_Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);
            // Write Your Code Here
            int totalSwaps = 0;
            for (int i = n - 1; i > 0; i--)
            {
                int numberOfSwaps = 0;
                //start the loop for swapping
                for (int j = 0; j < i; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        //swap elements
                        int temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                        //count the swaps
                        numberOfSwaps++;
                        totalSwaps++;
                    }
                }
                if (numberOfSwaps == 0)
                {
                    break;// break the loop without swapping
                }
            }
            Console.WriteLine("Array is sorted in " + totalSwaps + " swaps.");
            Console.WriteLine("First Element: " + a[0]);
            Console.WriteLine("Last Element: " + a[n - 1]);
            Console.ReadLine();
        }
    }
}
