namespace FactorialResult
{
    //internal class Program
    //{
    //    int factResult = 1;
    //    static void Main(string[] args)
    //    {

    //        Console.WriteLine("Enter Factorial Number:");
    //        int factNumber=int.Parse(Console.ReadLine());

    //        //for(int i = 1; i <= factNumber; i++)
    //        //{
    //        //    factResult=factResult * i;
    //        //}
    //        //Console.WriteLine("Result of Factorial of {0} is {1}",factNumber, factResult);
    //        //Console.ReadLine();

    //       long fact=Factorial(factNumber);

    //        Console.WriteLine("Result of Factorial of {0} is {1}", factNumber, fact);
    //        Console.ReadLine();
    //    }

    //    public static long Factorial(int factNumber)
    //    {
    //        if(factNumber == 0)
    //        {
    //            return 1;
    //        }
    //        return factNumber * Factorial(factNumber - 1);
    //    }


    //}


    internal class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("enter fact number:");
            int upperbound=int.Parse(Console.ReadLine());
            //for(int i = 1; i <= upperbound; i++)
            //{
            //    int fact = 1;
            //    for(int j = 1; j <=i; j++)
            //    {
            //        fact = fact * j;
            //    }
            //    Console.WriteLine("{0}! is {1}",i,fact);
            //}
            long result=Factorial(upperbound);
            Console.WriteLine("factorials are:"+result);
            Console.ReadLine();
        }
        static long factResult = 1;
        public static long Factorial(long upperbound)
        {
            if (upperbound == 0)
            {
                return 1;
            }
            return upperbound = upperbound * Factorial(upperbound-1);
        }


    }
}