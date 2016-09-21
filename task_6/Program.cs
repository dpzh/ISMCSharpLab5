using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("+++ Task 6 +++");
            Console.Write("Введите год: ");
            int a = int.Parse(Console.ReadLine());
            bool year;
            if (a % 4 != 0) year = false;
            else if (a % 100 == 0 && a % 400 != 0) year = false;
            else year = true;
            if (year) Console.WriteLine("Високосный");
            else Console.WriteLine("Не високосный");
        }
    }
}
