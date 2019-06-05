using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review1
{
    class Program
    {
        static void Main(string[] args)
        {
            //initiate a string to display result
            string result="";
            //get number of input
            int numOfWord = int.Parse(Console.In.ReadLine());
            //create an array to store all the strings
            string[] stringArray = new string[numOfWord];
            //input string
            for (int i = 0; i < numOfWord; i++)
            {
                stringArray[i] = Console.ReadLine();
            }
            //convert string to array of characters
            //use loop to do it i times
            for ( int i = 0; i < numOfWord;i++)
            {
                char[] chars = stringArray[i].ToCharArray();
                //get length of the array of the characters
                int length = chars.Length;
                //Add even characters -> string
                for (int j = 0;j<length;j+=2)
                {
                    result = result + chars[j];
                }
                //Add space
                result = result + " ";
                for (int j = 1; j < length; j += 2)
                {
                    result = result + chars[j];
                }
                Console.WriteLine(result);
                //Set result to "" again for next line
                result = "";
            }//end loop
            Console.ReadLine();
           
        }
    }
}
