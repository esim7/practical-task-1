using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicalTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            //задание 1
            Console.WriteLine("Essimzhan");
            Console.ReadKey();

            //задание 2
            int number1, number2;
            Console.WriteLine("введите первое число: ");
            number1 =  int.Parse(Console.ReadLine());
            Console.WriteLine("введите второе число: ");
            number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Сумма двух чисел равна: {0}",  number1 + number2);
            Console.ReadKey();
        }
    }
}
