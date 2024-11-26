using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        /// <summary>
        /// Задача 1. Найти минимальную величину из двух целых переменных a, b, 
        /// используя вспомогательные методы (ввода аргументов, нахождения минимальной величины, вывода результата).
        /// </summary>
        /// <param name=""></param>
        /// <param name=""></param>
        /// <returns></returns>

        static int Input (string mesage)
        {
            Console.Write(mesage);
            return int.Parse(Console.ReadLine());
        }

        static int Min(int x,int y)
        {
            return x < y ? x : y;
        }

        public static void Qutput(int result)
        {
            Console.WriteLine(result);
        }
        
        static void Main(string[] args)
        {
            int x = Input("x =");
            int y = Input("y =");
            int result = Min(x, y);
            Qutput(result);
            Console.Read();
        }
    }
}
