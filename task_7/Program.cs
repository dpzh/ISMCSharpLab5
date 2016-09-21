using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("+++ Task 7 +++");
            Console.Write("Введите номер масти и достоинство карты (через пробел): ");
            string[] st = Console.ReadLine().Split(' ');
            short m = short.Parse(st[0]); short k = short.Parse(st[1]);
            string mast, numb;
            switch (m)
            {
                case 1: mast = "пик"; break;
                case 2: mast = "треф"; break;
                case 3: mast = "бубен"; break;
                case 4: mast = "черв"; break;
                default: mast = "error"; break;
            }
            switch (k)
            {
                case 6: numb = "Шестерка"; break;
                case 7: numb = "Семерка"; break;
                case 8: numb = "Восьмерка"; break;
                case 9: numb = "Девятка"; break;
                case 10: numb = "Десятка"; break;
                case 11: numb = "Валет"; break;
                case 12: numb = "Дама"; break;
                case 13: numb = "Король"; break;
                case 14: numb = "Туз"; break;
                default: numb = "error"; break;
            }
            if (mast == "error" || numb == "error")
                Console.WriteLine("Такой карты не существует");
            else Console.WriteLine(numb + " " + mast);
            

        }
    }
}
