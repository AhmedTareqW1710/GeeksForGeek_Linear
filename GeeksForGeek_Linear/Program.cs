using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeksForGeek_Linear
{
    class Program
    {

        /// <summary>
        /// Get The value K from Array A using Linear Search
        /// </summary>
        /// <param name="args"></param>
        private static int Find(int[] a, int k)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == k)
                    return i+1;
            }
            return -1;
        }

        static void Main(string[] args)
        {
            //Console.WriteLine("Please enter the number of test cases");
            
            int numberOfTestCases = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Please enter the input length");

            for (int i = 0; i < numberOfTestCases; i++)
            {
                string[] input = Console.ReadLine().Split(' ');

                int n = Convert.ToInt32(input[0]);

                int k = Convert.ToInt32(input[1]);

                //Console.WriteLine("Please enter the set of item you need to search in");

                string[] arrStr = Console.ReadLine().Split(' ');

                int[] A = new int[n];

                for (int j = 0; j < n; j++)
                {
                    A[j] = Convert.ToInt32(arrStr[j].ToString());
                }

                int indexOfK = Find(A, k);

                Console.WriteLine(indexOfK);
            }           
        }
    }
}
