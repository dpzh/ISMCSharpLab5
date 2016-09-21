using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("+++ Task 5 +++");
            Console.Write("Введите число n: ");
            int n = int.Parse(Console.ReadLine());
            int k1 = n % 10;
            int k2 = (n / 10) % 10;
            int k3 = n / 100;
            int x = k2 * 100 + k3 * 10 + k1;

            Console.WriteLine("Число x = " + x.ToString());
        }
    }
}
