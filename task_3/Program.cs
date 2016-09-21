using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("+++ Task 3 +++");
            Console.Write("Введите трехзначное число: ");
            int a = int.Parse(Console.ReadLine());
            int k1 = a % 10;
            int k2 = (a / 10) % 10;
            int k3 = a / 100;
            Console.WriteLine("{0} {1} {2}",k1,k2,k3);

            int z1 = 0;
            if (k1 == 1) z1++; if (k2 == 1) z1++; if (k3 == 1) z1++;
            Console.WriteLine("Количестио единиц = "+ z1.ToString());
            Console.WriteLine("Количестио десятков = "+ k2.ToString());
            int z2 = k1 + k2 + k3;
            Console.WriteLine("Сумма цифр = "+ z2.ToString());
            int z3 = k1 * k2 * k3;
            Console.WriteLine("Произведение цифр = "+ z3.ToString());
        }
    }
}
