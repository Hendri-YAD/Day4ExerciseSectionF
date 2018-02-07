using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4ExerciseSectionF
{
    class Program3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a phrase: ");
            string input = Console.ReadLine();
            string[] s = input.Split(new Char[] { ' ', ',', '.', ':', '\t' });
            string comb = "";
            bool isPalindrome = true;

            for(int i = 0; i < s.Length; i++)
            {
                comb = comb + s[i];
            }

            comb = comb.ToUpper();

            for (int i = 0; i < comb.Length / 2; i++)
            {
                if (comb.Substring(i,1) != comb.Substring(comb.Length-1-i, 1))
                {
                    isPalindrome = false;
                }
            }

            if (isPalindrome)
            {
                Console.WriteLine("{0} is a Palindrome.", input);
            }
            else
            {
                Console.WriteLine("{0} is not a Palindrome.", input);
            }
        }
    }
}
