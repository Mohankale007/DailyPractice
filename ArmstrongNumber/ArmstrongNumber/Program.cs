namespace ArmstrongNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number:");
            int num=int.Parse(Console.ReadLine());
            int remider, result = 0;
            int sum = num;
            while (num > 0)
            {

                remider = num%10;
                result = result+(remider*remider*remider);
                num = num/10;
            }
            if (result == sum)
            {
                Console.WriteLine("Number is Armstrong...!");
            }
            else
            {

                Console.WriteLine("Number is not Armstrong");
            }
        }
    }
}