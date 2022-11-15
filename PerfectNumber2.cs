using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms6thAssignment
{
    internal class PerfectNumber2
    {
        public static void PerfectNumber()
        {
            Console.WriteLine("Enter any number to check and confirm if its a perfect number or not");
            int num=Convert.ToInt32(Console.ReadLine());
            int temp = 0;
            for (int i=1; i<num; i++)
            {
                if (num%i==0)
                {
                    temp=temp + i;
                }
            }
            if (temp==num)
            {
                Console.WriteLine($"{num} is a perfect number");
            }
            else
            {
                Console.WriteLine($"{num} is not a perfect number");
            }
        }
    }
}
