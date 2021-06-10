using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2._4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите название магазина.");
            String shopName = Console.ReadLine();

            Console.WriteLine("Введите ИНН.");
            String INN = Console.ReadLine();

            Console.WriteLine("Введите название организации.");
            String shopOwner = Console.ReadLine();

            Console.WriteLine("Введите имя кассира.");
            String seller = Console.ReadLine();

            Console.WriteLine("Введите наименование товара.");
            String product1 = Console.ReadLine();
            Console.WriteLine("Введите цену товара.");
            double price1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите наименование товара.");
            String product2 = Console.ReadLine();
            Console.WriteLine("Введите цену товара.");
            double price2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите наименование товара.");
            String product3 = Console.ReadLine();
            Console.WriteLine("Введите цену товара.");
            double price3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите наименование товара.");
            String product4 = Console.ReadLine();
            Console.WriteLine("Введите цену товара.");
            double price4 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите процент скидки.");
            double sale = Convert.ToDouble(Console.ReadLine());
            double sum = price1 + price2 + price3 + price4;
            double sumSale = sum * (sale / 100);

            Console.WriteLine("Оплата производится наличными(0) или картой(1). Введите нужную цифру.");
            byte payment =  Convert.ToByte(Console.ReadLine());
            
            Console.WriteLine("Введите полученную сумму наличных.");
            double getMoney = Convert.ToDouble(Console.ReadLine());
           


            Console.WriteLine("             ЧЕК НА ПРОДАЖУ");
            Console.WriteLine($"{shopName}");
            Console.WriteLine($"Кассир : {seller}       {DateTime.Now}" );
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("К-ВО И СТОИМОСТЬ(РУБ)");

            
            Console.WriteLine($"{product1}            {price1} РУБ.");
            Console.WriteLine($"{product2}            {price2} РУБ.");
            Console.WriteLine($"{product3}            {price3} РУБ.");
            Console.WriteLine($"{product4}            {price4} РУБ.");

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine($"                       ИТОГО......{sum} РУБ");
            Console.WriteLine($"             Скидка {sale} %......{sumSale} РУБ");
            Console.WriteLine($"                    К ОПЛАТЕ......{sum-sumSale} РУБ");

            if (payment == 0)
            {
                Console.WriteLine($"ВНЕСЕНО............... {getMoney}");
                Console.WriteLine($"СДАЧА................. {(getMoney)- (sum - sumSale)}");
            }
            else
            {
                Console.WriteLine($"ОПЛАЧЕНО КАРТОЙ........{sum-sumSale}");
            }

            Console.WriteLine("         СПАСИБО ЗА ПОКУПКУ!");
            Console.WriteLine($"{shopOwner} ИНН {INN}    {DateTime.Now}");

            Console.ReadKey();


        }
    }
}
