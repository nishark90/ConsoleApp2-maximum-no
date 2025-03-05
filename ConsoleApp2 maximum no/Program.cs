using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2_maximum_no
{
    internal class Program
    {
        static void Main(string[] args)
        { // Find the maximum number between two numbers//
            Console.WriteLine("Enter the two number");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {

                Console.WriteLine("a is maximum no :" + a);
            }
            else
                Console.WriteLine("b is maximum no :" + b);
            Console.ReadLine();
        }
    }
}
