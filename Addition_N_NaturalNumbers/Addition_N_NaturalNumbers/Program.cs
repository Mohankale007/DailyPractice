namespace Addition_N_NaturalNumbers
{
    internal class Program
    {
        public static void Addition(int n)
        {
            int count = 0;
            for (int i = 1; i <= n; i++)
            {
                count += i;
            }
            System.Console.WriteLine("Addition of N natural number:" + count);

        }
        static void Main(string[] args)
        {
            Program.Addition(3);
            Console.ReadLine();
        }
    }
}