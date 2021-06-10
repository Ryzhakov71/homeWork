using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите порядковый номер месяца.");
            int mounthNum = Convert.ToInt32(Console.ReadLine()); 
            string mounthTitle = "";
            switch (mounthNum)
            {
                case 1:
                    mounthTitle = "Январь";
                    break;
                case 2:
                    mounthTitle = "Февраль";
                    break;
                case 3:
                    mounthTitle = "Март";
                    break;
                case 4:
                    mounthTitle = "Апрель";
                    break;
                case 5:
                    mounthTitle = "Май";
                    break;
                case 6:
                    mounthTitle = "Июнь";
                    break;
                case 7:
                    mounthTitle = "Июль";
                    break;
                case 8:
                    mounthTitle = "Август";
                    break;
                case 9:
                    mounthTitle = "Сентябрь";
                    break;
                case 10:
                    mounthTitle = "Октябрь";
                    break;
                case 11:
                    mounthTitle = "Ноябрь";
                    break;
                case 12:
                    mounthTitle = "Декабрь";
                    break;
            }


            
            Console.WriteLine("Введите максимальную температуру за сутки.");
            double MaxTemp = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите минимальную температуру за сутки.");
            double MinTemp = Convert.ToDouble(Console.ReadLine());

            double SumTemp = MaxTemp + MinTemp;
            double MidTemp = (SumTemp / 2);


            if (mounthNum == 1)
            {
                if (MidTemp > 0)
                {
                    Console.WriteLine("Дождливая зима.");
                }
                
            }

            if (mounthNum == 2)
            {
                if (MidTemp > 0)
                {
                    Console.WriteLine("Дождливая зима.");
                }

            }

            if (mounthNum == 12)
            {
                if (MidTemp > 0)
                {
                    Console.WriteLine("Дождливая зима.");
                }

            }






            Console.ReadLine();
        }
    }
}
