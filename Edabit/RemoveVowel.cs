using System;
using System.Text.RegularExpressions;

namespace Edabit
{
    class RemoveVowel
    {
        public static void Vowel()
        {
            Console.WriteLine("Write a sentence: ");
            string args = Console.ReadLine();
            Console.WriteLine(SilenceTrump(args));
        }

        public static string SilenceTrump(string str)
        {
            return Regex.Replace(str, "[aeiouAEIOU]", "");
        }
    }
}
