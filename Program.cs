using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum;
            Console.WriteLine("Enter first Value: ");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second Value: ");
            int second = Convert.ToInt32(Console.ReadLine());
            if (first == second)
            {
                Console.WriteLine("As given numbers are same: ");
                Console.WriteLine(3 * (first + second));
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("As given numbers are not same: ");
                Console.WriteLine(first + second);
                Console.ReadLine();
            }


        }
    }
}
