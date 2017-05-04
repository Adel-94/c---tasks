using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
       
        static void Main(string[] args)
        {
            int number;
            Console.Write("Enter a Number : ");
            number = int.Parse(Console.ReadLine());
            if (number % 2 ==0)
            {
                Console.WriteLine(number * number);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(number * number * number);
                Console.ReadLine();
            }
    
        }
    }
}
