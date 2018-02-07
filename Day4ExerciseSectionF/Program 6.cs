using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4ExerciseSectionF
{
    class Program6
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a matriculation number: ");
            string input = Console.ReadLine();

            if (input.Length != 7)
            {
                Console.WriteLine("Invalid");
                return;
            }

            input = input.ToUpper();
            string numStr;
            int num, sum=0;

            for (int i=1; i <= 5; i++)
            {
                numStr = input.Substring(i, 1);
                num = Convert.ToInt32(numStr);
                sum = sum + num * (7 - i);
            }

            int rem = sum % 5;
            string checkSum = "";

            switch (rem)
            {
                case 0:
                    checkSum = "O";
                    break;
                case 1:
                    checkSum = "P";
                    break;
                case 2:
                    checkSum = "Q";
                    break;
                case 3:
                    checkSum = "R";
                    break;
                case 4:
                    checkSum = "S";
                    break;
            }

            if (checkSum == input.Substring(6))
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }            
        }
    }
}
