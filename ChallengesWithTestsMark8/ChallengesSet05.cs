using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            return ((startNumber / n) + 1) * n;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach (var item in businesses)
            {
                if (item.TotalRevenue == 0)
                {
                    item.Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return false;
            }

            for (int i = 1; i < numbers.Length; i++)
                {
                    if (numbers[i - 1] > numbers[i])
                    {
                        return false;
                    }
                }
                return true;
        }
        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            int sum = 0;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i-1] % 2 == 0) //if previous number is even ([i-1]) than the next number is added ([i])
                {
                    sum += numbers[i];
                }
            }
            return sum;    
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null || words.Length == 0)
            {
                return "";
            }
            string sentence = "";
            foreach (var item in words)
            {
                if (item.Trim().Length > 0) //get rid of all whitespaces or strings that are only whitespaces
                {
                    sentence += item.Trim() + " "; //add whitespace only at the end of the word. but we are left with a whitespace at the end of the sentence.
                }
            }
            //check to make sure that the string actaully has charachters
            if (sentence.Length == 0)
            {
                return "";
            }
            //sentence = sentence.Substring(0, sentence.Length - 1); //this removes the whitespace at the end of the sentence.
            sentence = sentence.TrimEnd();
            //now we add a period to the end of our sentence.
            sentence += ".";
            return sentence;
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            if (elements == null || elements.Count == 0)
            {
                return new double[0];
            }

            var everyFourth = new List<double>();
            for (int i = 3; i < elements.Count; i += 4) //start at index 3, 4th item in the list and increment by 4
            {
                everyFourth.Add(elements[i]); //add every fourth element 
            }
            return everyFourth.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            Dictionary<int, int> numsDictionary = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int num = nums[i];

                if (numsDictionary.TryGetValue(targetNumber - num, out int index))
                {
                    var number = new[] { index, i };
                    return true;
                }

                numsDictionary[num] = i;
            }
            return false;
            
            //throw new NotImplementedException();
        }
    }
}
