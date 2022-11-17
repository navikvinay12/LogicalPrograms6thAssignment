namespace LogicalPrograms6thAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome ! Please use the folowing options as per your choice\n" +
                "Press 1 : Fibonacci Series\n" +
                "Press 2 : Perfect Number\n" +
                "Press 3 : Prime Number\n" +
                "Press 4 : Reverse a Number\n" +
                "Press 5 : Coupon Numbers Generator\n" +
                "Press 6 : StopWatch Program");
            int switchOptions=Convert.ToInt32(Console.ReadLine());
            switch (switchOptions)
            {
                case 1:
                    FibonacciSeries1.FibonacciSeries();
                    break;
                case 2:
                    PerfectNumber2.PerfectNumber();
                    break;
                case 3:
                    PrimeNumber3.PrimeNumber();
                    break;
                case 4:
                    ReverseNumber4.ReverseNumber();
                    break;
                case 5:
                    CouponNoGenerator5.CouponNoGenerator();
                    break;
                case 6:
                    StopWatch6.StopWatch();
                    break;
                default:
                    Console.WriteLine("Invalid Option entered!");
                    break;
            }
        }
    }
}