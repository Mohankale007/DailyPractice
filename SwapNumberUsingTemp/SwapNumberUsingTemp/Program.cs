namespace SwapNumberUsingTemp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num1 = 10;
            int num2 = 20;

            int temp;

            //temp=num1;
            //num1 = num2;
            //num2=temp;

            num1 =num1+ num2;
            num2=num1-num2;
            num1=num1-num2;


            Console.WriteLine("swap numbes:"+num1+" "+num2);

        }
    }
}