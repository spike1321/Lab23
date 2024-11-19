using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Lab23
{
    class Program
    {
      
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int f = int.Parse(Console.ReadLine());
            FactorialAsync(f);
            Console.ReadKey();
         
        }

        static void Factorial(int a)
        {
            int count = 1;
            for (int i = 1; i <= a; i++)
            {
                if (a == 0)
                {
                    count = 1;
                }
                else
                count = count * i;
                Thread.Sleep(100);
            }
            Console.WriteLine("Факториал равен: {0}", count);
        }


        static async void FactorialAsync(int a)
        {
            await Task.Run(()=>Factorial(a));
        }
    }
}
