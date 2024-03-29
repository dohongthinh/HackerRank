using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Day18_Queues_And_Stacks
{
    class Program
    {
        //Write your code here
        Stack<char> myStack = new Stack<char>();
        Queue<char> myQueue = new Queue<char>();
        //Method 
        void pushCharacter( char c)// add to the top of the stack
        {
            myStack.Push(c);
        }
        void enqueueCharacter(char c) //add to queue
        {
            myQueue.Enqueue(c);
        }
        char popCharacter()// remove and return 1st char
        {
            return myStack.Pop();
        }
        char dequeueCharacter()
        {
            return myQueue.Dequeue();
        }
        static void Main(string[] args)
        {
            // read the string s.
            string s = Console.ReadLine();

            // create the Solution class object p.
            Program obj = new Program();

            // push/enqueue all the characters of string s to stack.
            foreach (char c in s)
            {
                obj.pushCharacter(c);
                obj.enqueueCharacter(c);
            }

            bool isPalindrome = true;

            // pop the top character from stack.
            // dequeue the first character from queue.
            // compare both the characters.
            for (int i = 0; i < s.Length / 2; i++)
            {
                if (obj.popCharacter() != obj.dequeueCharacter())
                {
                    isPalindrome = false;

                    break;
                }
            }

            // finally print whether string s is palindrome or not.
            if (isPalindrome)
            {
                Console.Write("The word, {0}, is a palindrome.", s);
            }
            else
            {
                Console.Write("The word, {0}, is not a palindrome.", s);
            }
        }
    }
}
