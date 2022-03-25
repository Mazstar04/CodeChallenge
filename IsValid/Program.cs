using System;
using System.Collections.Generic;
using System.Linq;

namespace IsValid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckStringIsValid("aaabbbcccdd"));

        }
        public static string CheckStringIsValid(string givenWord)
        {

            List<char> distinct = givenWord.ToList().Distinct().ToList();
            List<int> Occurence = new List<int>();

            for (int i = 0; i < distinct.Count(); i++)
            {
                int length = 0;
                for (int j = 0; j < givenWord.Length; j++)
                {
                    if (distinct[i] == givenWord[j])
                    {
                        length++;
                    }
                }
                Occurence.Add(length);
            }
            if (Occurence.Distinct().Count() == 1)
            {
                return "YES";
            }
            else if (Occurence.Distinct().Count() > 2)
            {

                return "NO";
            }
            else
            {
                List<int> Test = Occurence.Distinct().ToList();
                int first = Occurence.Where(o => o == Test[0]).Count();
                int second = Occurence.Where(o => o == Test[1]).Count();
                if (first > 1 && second > 1)
                {
                    return "NO";
                }
                else if((first == 1 && Test[0]-1 == 0)||(second == 1 && Test[1]-1 == 0))
                {
                    return "YES";
                }
                else if ((Test[0]-Test[1] == 1 && first == 1)|| (Test[1]-Test[0] == 1 && second == 1))
                {
                    return "YES";
                }
                else
                {
                    return "NO";
                }
            }
        }
    }
}
