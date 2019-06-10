using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14_Scope
{
    class Difference
    {
        private int[] elements;
        public int maximumDifference;

        //Constructor
        public Difference() { }
        public Difference(int[] elements)
        {
            this.elements = elements;
        }

        // Add your code here
        public void computeDifference()
        {
            for (int i = 0; i < elements.Length; i++)
            {
                for (int j = i; j < elements.Length; j++)
                {
                    int subtract = Math.Abs(elements[j] - elements[i]);
                    if (subtract > maximumDifference)
                    {
                        maximumDifference = subtract;
                    }
                }
            }
        }
    } // End of Difference Class
    class Program
    {
        static void Main(string[] args)
        {
            Convert.ToInt32(Console.ReadLine());

            int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

            Difference d = new Difference(a);

            d.computeDifference();

            Console.Write(d.maximumDifference);
            Console.ReadLine();
        }
    }
}
