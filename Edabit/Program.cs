using System;
namespace Edabit
{
    public class Edabit
    {
        public static void Main(string[] args)
        {
            var menuchoice = -1;
            while (menuchoice != 0)
            {
                Console.WriteLine("MENU");
                Console.WriteLine("Please enter the number that you want to do:");
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. Remove Vowel task");
                Console.WriteLine("2. Check if a sentence is an isogram");

                menuchoice = int.Parse(Console.ReadLine());

                switch (menuchoice)
                {
                    case 0:
                        break;
                    case 1:
                        RemoveVowel.Vowel();
                        break;
                    case 2:
                        Isogram.IsIsogram();
                        break;
                    default:
                        Console.WriteLine("Sorry, invalid selection");
                        break;
                }

            }
        }
    }
}
