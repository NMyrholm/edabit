using System;
using System.Text.RegularExpressions;

namespace Edabit
{
    class RemoveVowel
    {
        public static void Vowel(string args)
        {
            Console.WriteLine(SilenceTrump(args));
        }

        public static string SilenceTrump(string str)
        {
            return Regex.Replace(str, "[aeiouAEIOU]", "");
        }
    }
}
