using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace angel_215_zadacha_2
{
    class Program
    {
        /// <summary>
        /// Задача 2. Найти минимальную величину их трех целых переменных a, b, c с 
        /// использованием вспомогательных методов (ввода аргументов, нахождения минимальной величины, вывода результата).
        /// </summary>
        /// <param name="args"></param>

        static int Input(string mesage)
        {
            Console.Write(mesage);
            return int.Parse(Console.ReadLine());
        }
        static int Min(int x, int y)
        {
            return x < y ? x : y;
        }
        static void Main(string[] args)
        {
            int x = Input("x =");
            int y = Input("y =");
            int z = Input("z =");
            int min = Min(Min(x, y), z);

            Console.WriteLine($"min={min}");

        }
    }
}
