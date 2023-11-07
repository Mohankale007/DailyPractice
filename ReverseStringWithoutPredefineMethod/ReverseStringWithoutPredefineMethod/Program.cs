namespace ReverseStringWithoutPredefineMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string");
            string s1=Console.ReadLine();

            string s2 = "";

            char[] arr = s1.ToCharArray();

            for(int i = arr.Length-1; i >=0; i--)
            {
                s2=s2+ arr[i];
            }
            Console.WriteLine("Reversed String:"+s2);

            Console.ReadLine();
        }
    }
}