﻿namespace ASSIGNMENT_3_2_4
{
    internal class Program
    {
        static void CalculateTotalAndAverage(out double total, out double average, params double[] numbers)
        {
            total = 0;
            foreach (double num in numbers)
            {
                total += num;
            }

            average = numbers.Length > 0 ? total / numbers.Length : 0;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the First number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the Second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the Third number: ");
            double num3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the Fourth number: ");
            double num4 = Convert.ToDouble(Console.ReadLine());


            double total, average;
            CalculateTotalAndAverage(out total, out average, num1, num2, num3, num4);


            Console.WriteLine($"The average of {num1}, {num2}, {num3}, {num4} is: {average}");
            Console.WriteLine($"The total is: {total}");
        }
    }
}
