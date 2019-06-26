using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day27_Testing
{
    //had to convert from java (maybe having some errors)
    class Program
    {
        static void Main(string[] args)
        {
            TestWithEmptyArray();
            TestWithUniqueValues();
            TestWithExactlyTwoDifferentMinimums();
            Console.WriteLine("OK");
            Console.ReadLine();
        }


        public static int minimum_index(int[] seq)
        {
            if (seq.Length == 0)
            {
                throw new ArgumentException("Cannot get the minimum value index from an empty sequence");
            }
            int min_idx = 0;
            for (int i = 1; i < seq.Length; ++i)
            {
                if (seq[i] < seq[min_idx])
                {
                    min_idx = i;
                }
            }
            return min_idx;
        }

        static class TestDataEmptyArray
        {
            public static int[] get_array()
            {
                // complete this function
                return new int[] { };//return an empty array
            }
        }

        static class TestDataUniqueValues
        {
            public static int[] get_array()
            {
                // complete this function
                return new int[] { 1, 2, 3, 4, 5 }; //return an array with 5 elements
            }

            public static int get_expected_result()
            {
                // complete this function
                return minimum_index(get_array());// pass array to get exception
            }
        }

        static class TestDataExactlyTwoDifferentMinimums
        {
            public static int[] get_array()
            {
                // complete this function
                return new int[] { 1, 2, 3, 4, 3, 2, 1 };
            }

            public static int get_expected_result()
            {
                // complete this function
                return minimum_index(get_array());
            }
        }

        public static void TestWithEmptyArray()
        {
            try
            {
                int[] seq = TestDataEmptyArray.get_array();
                int result = minimum_index(seq);
            }
            catch (ArgumentException e)
            {
                return;
            }
            throw new ArgumentOutOfRangeException("Exception wasn't thrown as expected");
        }

        public static void TestWithUniqueValues()
        {
            int[] seq = TestDataUniqueValues.get_array();
            if (seq.Length < 2)
            {
                throw new ArgumentOutOfRangeException("less than 2 elements in the array");
            }

            int[] tmp = new int[seq.Length];
            for (int i = 0; i < seq.Length; ++i)
            {
                tmp[i] = seq[i];
            }
            if (!(new SortedSet<int>(tmp.ToList()).Count() == seq.Length))
            {
                throw new ArgumentOutOfRangeException("not all values are unique");
            }

            int expected_result = TestDataUniqueValues.get_expected_result();
            int result = minimum_index(seq);
            if (result != expected_result)
            {
                throw new ArgumentOutOfRangeException("result is different than the expected result");
            }
        }

        public static void TestWithExactlyTwoDifferentMinimums()
        {
            int[] seq = TestDataExactlyTwoDifferentMinimums.get_array();
            if (seq.Length < 2)
            {
                throw new ArgumentOutOfRangeException("less than 2 elements in the array");
            }

            int[] tmp = seq;
            Array.Sort(tmp);
            if (!(tmp[0] == tmp[1] && (tmp.Length == 2 || tmp[1] < tmp[2])))
            {
                throw new ArgumentOutOfRangeException("there are not exactly two minimums in the array");
            }

            int expected_result = TestDataExactlyTwoDifferentMinimums.get_expected_result();
            int result = minimum_index(seq);
            if (result != expected_result)
            {
                throw new ArgumentOutOfRangeException("result is different than the expected result");
            }
        }
    }
}
