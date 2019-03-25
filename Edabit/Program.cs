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

                menuchoice = int.Parse(Console.ReadLine());

                switch (menuchoice)
                {
                    case 0:
                        break;
                    case 1:
                        RemoveVowel.Vowel();
                        break;
                    default:
                        Console.WriteLine("Sorry, invalid selection");
                        break;
                }

            }
        }
    }
}
