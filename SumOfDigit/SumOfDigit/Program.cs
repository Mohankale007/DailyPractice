namespace SumOfDigit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n= 1234;//1+2+3+4=10
            int reminder;
            int sum = 0;

            while (n > 0)
            {
            
                reminder = n % 10;
                sum = sum + reminder;
                n = n / 10;
            }
            Console.WriteLine(sum);

            
            Console.ReadLine();
        }
    }
}