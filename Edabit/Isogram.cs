using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Edabit
{
    class Isogram
    {
        public static void IsIsogram()
        {
            Console.WriteLine("Write a sentence: ");
            string input = Console.ReadLine();
            Console.WriteLine(CheckIsogram(input));
        }

        public static bool CheckIsogram(string str)
        {
            string temp = "";
            char[] arr = str.ToLower().ToCharArray();

            for (int i = 0; i < arr.Length; i++)
            {
                temp = arr[i].ToString().ToLower();

                if (Regex.Matches(str.ToLower(), temp).Count == 2)
                {
                    return false;
                }
                else
                {
                    temp = arr[i].ToString();
                }
            }
            return true;
        }
    }
}
