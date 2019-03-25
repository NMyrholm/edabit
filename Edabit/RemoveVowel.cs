using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Edabit
{
    class RemoveVowel
    {
        public static void Vowel(string args)
        {
            //string str = "Hej jag heter Nils";
            Console.WriteLine(SilenceTrump(args));
        }

        public static string SilenceTrump(string str)
        {
            return Regex.Replace(str, "[aeiouAEIOU]", "");
        }
    }
}
