using System;

namespace homework
{
    class Program
    {
        static void Numbers()
        {
            Console.WriteLine("Enter 10 numbers. Numbers must be within 0 - 100");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());
            int num4 = Convert.ToInt32(Console.ReadLine());
            int num5 = Convert.ToInt32(Console.ReadLine());
            int num6 = Convert.ToInt32(Console.ReadLine());
            int num7 = Convert.ToInt32(Console.ReadLine());
            int num8 = Convert.ToInt32(Console.ReadLine());
            int num9 = Convert.ToInt32(Console.ReadLine());
            int num10 = Convert.ToInt32(Console.ReadLine());

            int sum = (num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9 + num10);
            int average = (num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9 + num10) / 10;

            Console.WriteLine($"The sum of the entered numbers is " + sum);
            Console.WriteLine($"The average of the entered numbers is " + average);
        }
        static void Main(string[] args)
        {
            Numbers();
        }
    }
}
