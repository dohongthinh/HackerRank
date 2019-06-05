using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //get the length of the array
            int n = Convert.ToInt32(Console.ReadLine());
            // new type to input an array 
            //if input more value, length = n
            // input less -> n is useless when can use arr.Length in the loop to reverse order
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
            ;
            
            // Reverse the order

            for (int i = n -1;i>=0;i--)
                //for (int i = arr.Length - 1; i >= 0; i--) : use this one when u want to input less value but does not affect the code
                //For example: n = 4 ; input 2 3 1
           {
                Console.Write(arr[i]+" ");
            }
            Console.ReadLine();
        }
    }
}
