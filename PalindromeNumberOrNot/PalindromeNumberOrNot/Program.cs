namespace PalindromeNumberOrNot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number:");
            int num=int.Parse(Console.ReadLine());

            int reminder, result = 0;
            int con = num;
            while(num>0)
            {
                reminder = num % 10;
                result = result * 10 + reminder;
                num=num / 10;
            }

            
            if (result == con)
            {
                Console.WriteLine("Number is palindrome:" + result);
            }
            else
            {
                Console.WriteLine("number is not palindrome...!");
            }
        }
    }
}