using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day26_Nested_Logic
{
    class Program
    {
        static void Main(string[] args)
        {
            double fine;
            //create an array to store 2 dates
            DateTime[] dateTimes = new DateTime[2];
            for (int i = 0; i < 2; i++)
            {
                //get two input on the same line
                string[] dates = Console.ReadLine().Split(' ');
                int day = int.Parse(dates[0]);
                int month = int.Parse(dates[1]);
                int year = int.Parse(dates[2]);
                dateTimes[i] = new DateTime(year, month, day);
            }

            if ((dateTimes[0].Year - dateTimes[1].Year) > 0)
            {
                fine = 10000;
            }
            else if ((dateTimes[0]-dateTimes[1]).TotalDays > 0 && (dateTimes[0] - dateTimes[1]).TotalDays <32)
            {
                fine = 15 * (dateTimes[0] - dateTimes[1]).TotalDays;
            }
            else if ((dateTimes[0] - dateTimes[1]).TotalDays > 31 && (dateTimes[0] - dateTimes[1]).TotalDays < 365)
            {
                fine = 500 * Math.Floor((dateTimes[0] - dateTimes[1]).TotalDays / 30);
            }
           
            else
            {
                fine = 0;
            }
            Console.WriteLine(fine);
            Console.ReadLine();
        }
    }
}
