using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[6][];
            // input array 6x6
            for (int i = 0; i < 6; i++)
            {
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }
            int sum;
            int largest = arr[0][0] + arr[0][1] + arr[0][2] + arr[1][1] + arr[2][0] + arr[2][1] + arr[2][2]; 
            //in order to get the length of the array -> arr.getLength()
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0 ;j < 4;j++)
                {
                    sum = arr[i][j] + arr[i][j + 1] + arr[i][j + 2] + arr[i + 1][j + 1] + arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2];
                    if (sum > largest)
                    {
                        largest = sum;// get largest sum
                    }
                }
            }
            Console.WriteLine(largest);
        }
    }
}
