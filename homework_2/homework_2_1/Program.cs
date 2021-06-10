using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите максимальную температуру за сутки.");
            double MaxTemp = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите минимальную температуру за сутки.");
            double MinTemp = Convert.ToDouble(Console.ReadLine());

            double SumTemp = MaxTemp + MinTemp;
            double MidTemp = (SumTemp / 2);

            Console.WriteLine($"Средняя температура за сутки равна {MidTemp}");

            Console.ReadLine();
        }
    }
}
