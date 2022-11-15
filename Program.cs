namespace LogicalPrograms6thAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press 1 : Fibonacci Series\n");
            int switchOptions=Convert.ToInt32(Console.ReadLine());
            switch (switchOptions)
            {
                case 1:
                    FibonacciSeries1.FibonacciSeries();
                    break;
                default:
                    Console.WriteLine("Invalid Option entered!");
                    break;
            }
        }
    }
}