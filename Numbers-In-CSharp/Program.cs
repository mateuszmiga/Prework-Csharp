using System;


namespace Numbers_In_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius = 2.50;

            double Area;

            Area = Math.PI * Math.Pow(radius, 2);
            
            
            Console.WriteLine($"Your area is: {Area}");
        }
    }
}
