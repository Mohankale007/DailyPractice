namespace ReverseNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 123;
            int reminder,reverse=0;
            while(n>0)
            {
                reminder = n % 10;
                reverse = reverse * 10 + reminder;
                n = n / 10;
            }
            Console.WriteLine(reverse);
            Console.ReadLine();

            


        }
    }
}