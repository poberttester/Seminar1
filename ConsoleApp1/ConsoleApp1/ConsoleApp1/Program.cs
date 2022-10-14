using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {             
            int second, first;
            string display_output;


            Console.WriteLine("Сравниваем два целых числа");

            Console.Write("Введите первое число: ");
            first = int.Parse(Console.ReadLine());
            Console.Write("");

            Console.Write("Введите второе число: ");
            second = int.Parse(Console.ReadLine());
            Console.Write("");


            if (first > second) display_output = "Первое число больше чем второе."; 
            else if (second > first) display_output = "Второе число больше чем первое.";
            else display_output = "Числа одинаковые";


            Console.Write(display_output);
        }
    }
}
