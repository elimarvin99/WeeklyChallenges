using System;

namespace ChallengesWithTestsMark8
{
    class Program
    {
        static int closestNumber(int n, int m)
        {
            // find the quotient
            int q = n / m;

            // 1st possible closest number
            int n1 = m * q;

            // 2nd possible closest number
            int n2 = (n * m) > 0 ? (m * (q + 1)) : (m * (q - 1));

            // if true, then n1 is the required closest number
            if (Math.Abs(n - n1) < Math.Abs(n - n2))
                return n1;

            // else n2 is the required closest number
            return n2;
        }

        // Driver program to test above
        public static void Main()
        {
            int n = 13, m = 4;
            Console.WriteLine(closestNumber(n, m));

            n = -15;
            m = 6;
            Console.WriteLine(closestNumber(n, m));

            n = 0;
            m = 8;
            Console.WriteLine(closestNumber(n, m));

            n = 18;
            m = -7;
            Console.WriteLine(closestNumber(n, m));
        }
    }
}
