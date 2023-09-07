using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_7_02._09._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*задача 7. Составить программу вывода на экран «столбиком» четырех случайных чисел.*/
            Random rnd = new Random();
            int x1 = rnd.Next();  
            int x2 = rnd.Next();   
            int x3 = rnd.Next();
            int x4 = rnd.Next();
            Console.WriteLine(x1);
            Console.WriteLine(x2);
            Console.WriteLine(x3);
            Console.WriteLine(x4);
        }
    }
}
