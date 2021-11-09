using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            bool result;
            result = CharacterIsALetter(c);
            if (result)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if (vals.Length % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            var max = numbers.Max();
            var min = numbers.Min();
            var sum = min + max;
            return sum;
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            throw new NotImplementedException();
        }

        public int Sum(int[] numbers)
        {
            return numbers.Sum();
        }
         
        public int SumEvens(int[] numbers)
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

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers.Sum() % 2 != 0)
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
            var oddSum = 0;
            for (int i = 0; i > number; i++)
            {
                if (i % 2 != 0)
                {
                    oddSum += i;
                }
            }
            return oddSum;
        }
    }
}
