using System;

namespace Branches_and_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            for (int i = 0; i <=20; i++)
            {
                if (i % 3 == 0)
                    sum += i;
            }
            
            Console.WriteLine($"Your sum is: {sum}");
        }
    }
}
