using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("+++ Task 9 +++");
            double s = 0, v = 0;
            for (byte i = 1; i <= 100; i++)
            {
                s += 1.0 / i;
                v += Math.Pow(-1, i - 1) / i;
            }
            Console.WriteLine("Расстояние от дома = " + v.ToString());
            Console.WriteLine("Общий путь = " + s.ToString());

        }
    }
}
