using System.Security.Cryptography;

namespace FibonacciSeries
{
    internal class Program
    {
        static int p1 = 0, p2 = 1, p3;
        static void Main(string[] args)
        {
            //int p1 = 0, p2 = 1,p3;
            //Console.WriteLine("Enter Range:");
            //int count=int.Parse(Console.ReadLine());

            //Console.Write("Fibonacci Series up to "+count+" digit is:"+p1+" "+p2);
            //for (int i=2;i<count;i++)
            //{
            //    p3 = p1 + p2;
            //    Console.Write(" "+p3);
            //    p1 = p2;
            //    p2= p3;
            //}


            // Using recursion method
            
            Console.WriteLine("Enter Range:");
            int count = int.Parse(Console.ReadLine());

            Console.Write("Fibonacci Series up to " + count + " digit is:" + p1 + " " + p2);

            Fibonacci(count - 2);

          //  Console.ReadLine();
        }

        public static void Fibonacci(int count)
        {
            if (count > 0)
            {
                p3 = p1 + p2;
                Console.Write(" "+p3);
                p1 = p2;
                p2 = p3;
                Fibonacci(count - 1);

            }
        }
    }
}