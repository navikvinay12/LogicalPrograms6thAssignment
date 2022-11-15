using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms6thAssignment
{
    internal class FibonacciSeries1
    {
        public static void FibonacciSeries()
        {
            Console.WriteLine("How many elements of fabonacci numbers you wish to see");
            int lastNum = Convert.ToInt32(Console.ReadLine());
            int previous = 0, next = 1;
            Console.Write("Fabonacci Series : " +previous + " " + next);
            for (int i = 3; i <= lastNum; i++)
            {
                int sum = previous + next;
                Console.Write(" " + sum);
                previous = next;
                next = sum;
            }
        }
    }
}
