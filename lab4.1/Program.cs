using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите N");
            int N = Convert.ToInt32(Console.ReadLine());
            int r = 0;
            if (N <= 0)
            {
                Console.WriteLine("Ошибка");
            }
                
            for (int i = 1; i <= N; i++)
            {
                r = r + 2*i-1;
                Console.WriteLine(r);
            }
            Console.ReadKey();

        }
    }
}
