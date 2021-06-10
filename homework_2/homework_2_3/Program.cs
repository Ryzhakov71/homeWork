using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число.");
            var x = Convert.ToDouble(Console.ReadLine());
            var y = 2;
            var res = x % y;

            if (res == 0)
            {
                
                Console.WriteLine("Число четное.");
            }
            else
            {
                Console.WriteLine("Число нечетное.");
            }

            Console.ReadKey();


        }
    }
}
