using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework3._2
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Введите имя абонента.");
            string name1 = Console.ReadLine();
            Console.WriteLine("Введите телефон абонента.");
            string number1 = Console.ReadLine();
            Console.WriteLine("Введите e-mail абонента.");
            string email1 = Console.ReadLine();

            Console.WriteLine("Введите имя абонента.");
            string name2 = Console.ReadLine();
            Console.WriteLine("Введите телефон абонента.");
            string number2 = Console.ReadLine();
            Console.WriteLine("Введите e-mail абонента.");
            string email2 = Console.ReadLine();

            Console.WriteLine("Введите имя абонента.");
            string name3 = Console.ReadLine();
            Console.WriteLine("Введите телефон абонента.");
            string number3 = Console.ReadLine();
            Console.WriteLine("Введите e-mail абонента.");
            string email3 = Console.ReadLine();

            Console.WriteLine("Введите имя абонента.");
            string name4 = Console.ReadLine();
            Console.WriteLine("Введите телефон абонента.");
            string number4 = Console.ReadLine();
            Console.WriteLine("Введите e-mail абонента.");
            string email4 = Console.ReadLine();

            
            string[,] PhoneBook = new string[5, 2];
            PhoneBook[0, 0] = ("Имя");
            PhoneBook[0, 1] = ("       Телефон/e-mail");
            PhoneBook[1, 0] = name1;
            PhoneBook[2, 0] = name2;
            PhoneBook[3, 0] = name3;
            PhoneBook[4, 0] = name4;
            PhoneBook[1, 1] = number1 + "/" + email1;
            PhoneBook[2, 1] = number2 + "/" + email2;
            PhoneBook[3, 1] = number3 + "/" + email3;
            PhoneBook[4, 1] = number4 + "/" + email4;


            for (int y = 0; y < PhoneBook.GetLength(0); y++)
            {

                for (int x = 0; x < PhoneBook.GetLength(1); x++)
                {
                    Console.Write(PhoneBook[y, x] + "\t");
                }
                Console.WriteLine();

            }
            Console.ReadKey();




        }
    }
}
