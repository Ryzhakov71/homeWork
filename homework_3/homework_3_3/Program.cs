using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework._3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст.");
            string input = Console.ReadLine();
            string output = new string(input.ToCharArray().Reverse().ToArray());
            Console.WriteLine(output);
            Console.ReadLine();
        }

        



    }
}
