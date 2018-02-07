using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4ExerciseSectionF
{
    class Program5
    {
        static void Main(string[] args)
        {
            string[] Name = new string[] { "John", "Venkat", "Mary", "Victor", "Betty"};
            int[] Marks = new int[] { 63, 29, 75, 82, 55 };

            for(int i=0; i < 4; i++)
            {
                for(int j = i; j < 4; j++)
                {
                    if(Marks[i] < Marks[j + 1])
                    {
                        int temp = Marks[i];
                        Marks[i] = Marks[j + 1];
                        Marks[j + 1] = temp;

                        string tempStr = Name[i];
                        Name[i] = Name[j + 1];
                        Name[j + 1] = tempStr;
                    }
                }
            }

            for(int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Rank {0} is {1}", i, Name[i-1]);
            }

            for (int i = 0; i < 4; i++)
            {
                for (int j = i; j < 4; j++)
                {
                    if (Name[i].CompareTo(Name[j+1]) == 1)
                    {
                        string tempStr = Name[i];
                        Name[i] = Name[j + 1];
                        Name[j + 1] = tempStr;
                    }
                }
            }

            Console.WriteLine("\nAlphabetical order: ");
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("{0}", Name[i - 1]);
            }

        }
    }
}
