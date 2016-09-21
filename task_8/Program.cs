using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("+++ Task 8 +++");
            const int x= 2;
            double s = 1;
            for (double i=2; i<=3; i++)
            {
                s += (i / (i + 1) * Math.Pow(-x, i - 1));
            }
            Console.WriteLine("Сумма = " + s.ToString());
        }
    }
}
