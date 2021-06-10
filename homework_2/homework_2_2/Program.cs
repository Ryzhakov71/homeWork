using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2._2
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

            Console.WriteLine($"Под номером {mounthNum} стоит месяц {mounthTitle}.") ;

            Console.ReadLine();


        }
    }
}
