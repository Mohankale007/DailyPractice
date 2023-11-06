using System.Collections.Generic;

namespace PerfectNumber
{
    //perfect number, a positive integer that is equal to the sum
    //of its proper divisors.The smallest perfect number is 6,
    //which is the sum of 1, 2, and 3. Other perfect numbers are 28, 496, and 8,128.
    //The discovery of such numbers is lost in prehistory.
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 28;
            int result = 0;
            int sum = n;

            for (int i = 1; i < n; i++)
            {
                if(n%i == 0)
                {
                    result =result+i;
                }
            }
            if(result==sum)
            {
                Console.WriteLine("number is perfect");
            }
            else
            {
                Console.WriteLine("number is not perfect number");
            }
            Console.WriteLine(result);

        }
    }
}