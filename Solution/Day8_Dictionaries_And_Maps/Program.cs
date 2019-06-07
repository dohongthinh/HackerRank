using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8_Dictionaries_And_Maps
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create new dictionary of strings
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            //get the number of input
            int num = Convert.ToInt32(Console.ReadLine());
            //get key - value 
            for (int i =0;i<num;i++)
            {
                //get two input on the same line
                string[] token = Console.ReadLine().Split();
                string key = token[0];
                string value = token[1];
                dictionary.Add(key, value);
            }
            //put input value to an array
            string[] values = new string[num];
            for(int i = 0; i < num; i++)
            {
                 values[i]  = Console.ReadLine();               
            }
            // search every single key
            for (int i = 0; i < num; i++)
            {
                try
                {
                    // Search the key success
                    Console.WriteLine(values[i] + "=" + dictionary[values[i]]);
                }
                //fail to search
                catch (KeyNotFoundException)
                {
                    Console.WriteLine("Not found");
                }
            }
            Console.ReadLine();

        }
    }
}
