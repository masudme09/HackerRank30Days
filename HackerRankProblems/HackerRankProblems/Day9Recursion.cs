using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankProblems
{
    public static class Day9Recursion
    {
        public static void input()
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            long result = factorial(n);

            Console.WriteLine(result);

            Console.ReadLine();
       
        }

        private static long factorial(int n)
        {
            if(n==0)
            {
                return 1;
            }

            return n * factorial(n - 1);
        }
    }
    }

