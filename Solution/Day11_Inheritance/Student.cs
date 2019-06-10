using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11_Inheritance
{
    //inherit class Person
    class Student :  Person
    {
        /*	
    *   Class Constructor
    *   
    *   Parameters: 
    *   firstName - A string denoting the Person's first name.
    *   lastName - A string denoting the Person's last name.
    *   id - An integer denoting the Person's ID number.
    *   scores - An array of integers denoting the Person's test scores.
    */
       
        protected int[] scores;
        char g;
        // Write your constructor here
        public Student() { }
        public Student(string firstName,string lastName, int identification, int[] scores) :base(firstName,lastName,identification)
        {          
            this.scores = scores;
        }
        /*	
        *   Method Name: Calculate
        *   Return: A character denoting the grade.
        */
        // Write your method here
        public char Calculate()
        {
            int sum = 0;
            int avg;
            for (int i =0; i < scores.Length;i++)
            {
                sum += scores[i];
            }
            avg = sum / scores.Length;
            if (avg >= 90 && avg <= 100)
                g = 'O';
            else if (avg >= 80 && avg <= 90)
                g = 'E';
            else if (avg >= 70 && avg <= 80)
                g = 'A';
            else if (avg >= 55 && avg <= 75)
                g = 'P';
            else if (avg >= 40 && avg <= 55)
                g = 'D';
            else if (avg < 40)
                g = 'T';
            
            return g;
        }
    }
}
