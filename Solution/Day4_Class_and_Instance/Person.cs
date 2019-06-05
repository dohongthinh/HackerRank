using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Class_and_Instance
{
    class Person
    {
        public int age;
        public Person(int initialAge)
        {
            // Add some more code to run some checks on initialAge
            //set age
            if (initialAge < 0)
            {
                age = 0;
                Console.WriteLine("Age is not valid, setting age to 0.");
            }
            else
            {
                age = initialAge;
            }
        }
        //check the condition
        public void amIOld()
        {
            // Do some computations in here and print out the correct statement to the console 
            if (age > -1 && age < 13)
            {
                Console.WriteLine("You are young.");
            }
            else if (age > 12 && age < 18)
            {
                Console.WriteLine("You are a teenager.");
            }
            else
            {
                Console.WriteLine("You are old.");
            }
        }
        //increase the age
        public void yearPasses()
        {
            // Increment the age of the person in here
            age += 1;
        }
    }
}
