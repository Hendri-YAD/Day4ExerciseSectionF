using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4ExerciseSectionF
{
    class Program4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a phrase: ");
            string input = Console.ReadLine();
            string[] s = input.Split(new Char[] { ' ', ',', '.', ':', '\t' });
            string comb = "";

            for(int i=0; i<s.Length;i++)
            {            
                comb = comb + s[i].Substring(0, 1).ToUpper();
                comb = comb + s[i].Substring(1);

                if (i != s.Length-1)
                    comb = comb + " ";
            }

            Console.WriteLine(comb);


        }
    }
}
