using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задайте число");
            int N = Convert.ToInt32(Console.ReadLine());
            int j = 0;
            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine(j += i * 2 - 1);
            }
            Console.ReadKey();
        }
    }
}