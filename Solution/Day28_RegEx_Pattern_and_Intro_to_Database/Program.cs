using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day28_RegEx_Pattern_and_Intro_to_Database
{
    class Program
    {
        static void Main(string[] args)
        {
            //dont need regEx with EndsWith method 
            int N = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            string[] names = new string[N];
            for (int NItr = 0; NItr < N; NItr++)
            {
                string[] firstNameEmailID = Console.ReadLine().Split(' ');

                string firstName = firstNameEmailID[0];

                string emailID = firstNameEmailID[1];

                if (emailID.EndsWith("@gmail.com"))
                {
                    names[count] = firstName;
                    count++;
                }
            }
            Array.Sort(names);
            for (int k = 0; k < names.Length; k++)
            {
                if (names[k] != null)
                {
                    Console.WriteLine(names[k]);
                }
            }
            Console.ReadLine();
        }
    }
}
