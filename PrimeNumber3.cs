using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms6thAssignment
{
    internal class PrimeNumber3
    {
        public static void PrimeNumber()
        {
            Console.WriteLine("Enter a number to check and confirm if its a prime number or not ");
            int num = Convert.ToInt32(Console.ReadLine());
            int  count = 0;
            for (int i = 2; i < num / 2; i++)
            {
                if (num % i == 0)
                {
                    count++;
                }
            }
            if (count == 0)
            {
                Console.WriteLine($"{num} is a Prime number");
            }
            else
            {
                Console.WriteLine($"{num} is a Non-Prime number");
            }
        }
    }
}
