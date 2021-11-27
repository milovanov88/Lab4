using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("задайте ряд чисел");
            int count = 0;
            int number;
            do
            {
                number = Convert.ToInt32(Console.ReadLine());
                count = (number > 0) ? count + 1 : count - 1;

            }
            while (number != 0);
            if (count > 0)
            {
                Console.WriteLine("больше положительных чисел");
            }
            if (count < 0)
            {
                Console.WriteLine("больше отрицательных чисел");
            }
            if (count == 0)
            {
                Console.WriteLine(" отрицательных и положительныых чисел одинаковое колличество");
            }
            Console.ReadKey();
        }
    }
}
