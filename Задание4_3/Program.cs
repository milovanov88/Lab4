using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задайте числа A, B и С");
            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());
            int C = Convert.ToInt32(Console.ReadLine());
            int n = 0;
            int a = C;
            while (a <= A)
            {
                int b = 0;
                while (b <= B-C)
                {
                    n++;
                    b += C;
                }
                a += C;            
            }
            Console.WriteLine(n);
            Console.ReadKey();
        }
    }
}
