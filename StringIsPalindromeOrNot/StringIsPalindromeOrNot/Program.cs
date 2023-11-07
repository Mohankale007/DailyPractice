namespace StringIsPalindromeOrNot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String:");
            string s1=Console.ReadLine().ToLower();
            string s2 = "";
            char[] arr = s1.ToCharArray();

            for(int i=arr.Length-1; i>=0; i--)
            {
                s2=s2 + arr[i];

            }
            if(s2 == s1)
            {
                Console.WriteLine("String is Palindrome..!");
            }
            else
            {
                Console.WriteLine("String is not Palidrome..!");
            }
            Console.ReadLine();


        }
    }
}