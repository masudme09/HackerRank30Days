using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankProblems
{
    public static class Day8PhoneMap
    {
        public static Dictionary<string, int> namePhoneInput()
        {
            Dictionary<string,int> namePhoneList = new Dictionary<string, int>();
            int iter = Convert.ToInt32(Console.ReadLine().Trim());
            for (int i = 0; i < iter; i++)
            {
                string input = Console.ReadLine();
                namePhoneList.Add(input.Split(' ')[0], Convert.ToInt32(input.Split(' ')[1]));

            }
            return namePhoneList;
        }

        public static void output(Dictionary<string, int> namePhoneList)
        {
            string input = "";
            while ((input = Console.ReadLine()) != null)
            {
                if(namePhoneList.ContainsKey(input))
                {
                    Console.WriteLine(input + "=" + namePhoneList[input]);

                }
                else
                {
                    Console.WriteLine("Not found ");
                }        
            }
        }
        
    }
}
