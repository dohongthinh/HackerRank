using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Solution
{
    class Program
    {
        // Day 2: operation
        static void Main(string[] args)
        {
            //input from the user
            double meal_cost = Convert.ToDouble(Console.ReadLine());

            int tip_percent = Convert.ToInt32(Console.ReadLine());

            int tax_percent = Convert.ToInt32(Console.ReadLine());
            //call method
            solve(meal_cost, tip_percent, tax_percent);

            Console.ReadLine();
        }
        //method to calculate totalCost
        static void solve(double meal_cost, int tip_percent, int tax_percent)
        {
            double tip = meal_cost * tip_percent / 100;
            double tax = meal_cost * tax_percent / 100;
            double totalCost = meal_cost + tip + tax;
            Console.WriteLine(Math.Round(totalCost));

        }
    }
}
