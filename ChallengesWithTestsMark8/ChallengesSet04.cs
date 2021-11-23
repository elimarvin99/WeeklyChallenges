using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int even = 0;
            int odd = 0;
            foreach (var item in numbers)
            {
                if (item % 2 == 0)
                {
                    even += item;
                }
                else
                {
                    even -= item;
                }
            }
            return even;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            int shortest = 1000000;
            if (str1.Length < shortest)
            {
                shortest = str1.Length;
            }
            if (str2.Length < shortest)
            {
                shortest = str2.Length;
            }
            if (str3.Length < shortest)
            {
                shortest = str3.Length;
            }
            if (str4.Length < shortest)
            {
                shortest = str4.Length;
            }
            return shortest;

        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var arr = new int[] { number1, number2, number3, number4 };
            return arr.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if (sideLength1 + sideLength2 > sideLength3 && sideLength1 + sideLength3 > sideLength2 && sideLength2 + sideLength3 > sideLength1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsStringANumber(string input)
        {
            float n;     //need to use float because we are testing for decimal points also, not just ints
            return float.TryParse(input, out n);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int result = objs.Count(x => x == null);
            if (result > objs.Count() / 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            double sum = 0;
            double count = 0;
            foreach (var item in numbers)
            {
                if (item % 2 == 0)
                {
                    sum += item;
                    count++;
                }
            }
            if (count > 0)
            {
                return sum / count; ;
            }
            else
            {
                return 0;
            }
            
        }

        public int Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (number == 0)
            {
                return 1;
            }

            int result = 1;
            while (number != 1)
            {
                result = result * number;
                number = number - 1;
            }
            return result;
        }
    }
}
