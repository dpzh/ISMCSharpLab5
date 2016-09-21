using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("+++ Task 2 +++");
            // a^4 
            Console.Write("Введите a: ");
            double a = double.Parse(Console.ReadLine());
            double z1 = a * a; z1 = z1 * z1;
            Console.WriteLine("a^4 = " + z1.ToString());

            // a^6 
            double z2 = a * a; z2 =z2*a; z2 = z2*z2;
            Console.WriteLine("a^6 = " + z2.ToString());

            // a^7
            double z3 = a * a; double z4 = z3 * z3; z4 = z4 * z3; z4 = z4 * a;
            Console.WriteLine("a^7 = " + z4.ToString());

            // a^8
            double z5 = a*a; z5 *= z5; z5 *= z5;
            Console.WriteLine("a^8 = " + z5.ToString());

            // a^9
            double z6 = a * a; z6 *= z6; z6 *= z6; z6 *= a;
            Console.WriteLine("a^9 = " + z6.ToString());

            // a^10
            double z7 = a * a; double z8 = z7 * z7; z8 *= z8; z8 *= z7;
            Console.WriteLine("a^10 = " + z8.ToString());

            // a^13
            double z9 = a * a; double z10 = z9 * z9; double z11 = z10 * z10; z11 *= z10; z11 *= a;
            Console.WriteLine("a^13 = " + z11.ToString());

            // a^21
            double z12 = a * a; z12 *= z12; double z13 = z12 * z12; z13 *= z13; z13 *= z12; z13 *= a; 
            Console.WriteLine("a^21 = " + z13.ToString());
            
            // a^28
            double z14 = a * a; z14 *= z14; double z15 = z14 * z14; double z16 = z15 * z15;
            z16 *= z15; z16 *= z14;
            Console.WriteLine("a^28 = " + z16.ToString());

            // a^64
            double z17 = a * a; z17 *= z17; z17 *= z17; z17 *= z17; z17 *= z17; z17 *= z17;
            Console.WriteLine("a^64 = " + z17.ToString());
        }
    }
}
