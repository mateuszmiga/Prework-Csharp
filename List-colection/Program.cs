using System;
using System.Collections.Generic;

namespace List_colection
{
    class Program
    {
        public static int ReturnFiboNumber(int a) //return fibo number of index "a"
        {
            List<int> FiboNumber = new List<int> { 1, 1 };

            for (int i = 2; i < a; i++)
            {
                FiboNumber.Add(FiboNumber[i - 2] + FiboNumber[i - 1]);
            }
            



            return FiboNumber[a - 1];
        }
        static void Main(string[] args)
        {
            var howMany = 0;
            Console.WriteLine("witaj, podaj ile liczb fibonacciego chcesz wyswietlic:");
            howMany = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("=====================================");
            //Zabawa z listą 
            
            List<int> F = new List<int> { };

            for (int i = 1; i <= howMany; i++)
            {
                int x = ReturnFiboNumber(i);
                F.Add(x);
            }

            foreach (var item in F)
            {
                Console.WriteLine(item);
            }
            
            //Console.WriteLine($"Your Fibo number is: { ReturnFiboNumber(howMany)}");
        }
    }
}
