using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("+++ Task 4 +++");
            Console.Write("Введите трехзначное число: ");
            int a = int.Parse(Console.ReadLine());
            int k1 = a % 10;
            int k2 = (a / 10) % 10;
            int k3 = a / 100;
            int x = k3 * 100 + k1 * 10 + k2;

            Console.WriteLine("Новое число = " + x.ToString());
        }
    }
}
