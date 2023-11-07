namespace YearIsLeapYearOrNot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter Year to check Wheather it is leap or Not? :");
            //int input=int.Parse(Console.ReadLine());

            //if((input%4==0 && input%100 !=0) || input %400 == 0)
            //{
            //    Console.WriteLine("Year {0} Is Leap Year",input);
            //}
            //else
            //{
            //    Console.WriteLine("Year {0} is not Leap Year..!",input);
            //}


            // Leap Year in Given Rage?

            Console.WriteLine("Enter Minimum Year:");
            int minYear = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Maximum year:");
            int maxYear=int.Parse(Console.ReadLine());

            for(int year = minYear; year <= maxYear; year++)
            {
                if((year%4==0 && year%100!=0) || year % 400 == 0)
                {
                    Console.WriteLine("{0} is Leap year",year);
                }
            }

            Console.ReadLine();
        }
    }
}