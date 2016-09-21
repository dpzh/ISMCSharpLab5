using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("+++ Task 1 +++");
            Console.Write("Введите х та y (через пробел): ");
            string[] st = Console.ReadLine().Split(' ');
            double x = double.Parse(st[0]); double y = double.Parse(st[0]);
            double d = 1.0 / (Math.Sqrt(x * x + 10));
            if (y!=-d)
            {
                double z = (x + (2 + y) / (x * x)) / (y + d);
                Console.WriteLine("z = " + z.ToString());
            }
            else
            {
                Console.WriteLine("Ошибка. Деление на ноль");
            }
            double q = 2.8 * Math.Sin(x) + Math.Abs(y);
            Console.WriteLine("q = " + q.ToString());
        }
    }
}
