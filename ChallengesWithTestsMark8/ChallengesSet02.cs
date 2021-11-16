using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        //    Finished and passed all tests for week 2
        public bool CharacterIsALetter(char c)
        {
            return Char.IsLetter(c); 
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            return (vals.Length % 2 == 0) ? true : false;
        }
        
        public bool IsNumberEven(int number)
        {
            return (number % 2 == 0) ? true : false;
        }

        public bool IsNumberOdd(int num)
        {
            return (num % 2 != 0) ? true : false;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            //return null if enumerable is empty
            return (numbers == null || numbers.Count() == 0) ? 0 : numbers.Max() + numbers.Min();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            return (str1.Length < str2.Length) ? str1.Length : str2.Length;
        }

        public int Sum(int[] numbers)
        {
            return (numbers == null) ? 0 : numbers.Sum();
        }
         
        public int SumEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            else
            {

                int sum = 0;
                foreach (var i in numbers)
                {
                    if (i % 2 == 0)
                    {
                        sum += i;
                    }
                }
                return sum;
            }
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            else if (numbers.Sum() % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            //long oddSum = 0;
            //for (int i = 0; i < number; i++)
            //{
            //    if (i % 2 != 0)
            //    {
            //        oddSum ++;
            //    }
            //}
            //return oddSum;
            if (number <= 0)
            {
                return 0;
            }
            else
            {
                return number / 2;    //returning (if number is positive) sum of number that is rounded to even divided by 2 that will return sum of evens
            }
        }
    }
}
