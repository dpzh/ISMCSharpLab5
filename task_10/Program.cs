using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("+++ Task 10 +++");
            double s = 0;
            for (byte i=3; i>=1; i--)
            {
                s = Math.Sqrt(i + s);
            }
            Console.WriteLine("Сумма = " + s.ToString());
        }
    }
}
