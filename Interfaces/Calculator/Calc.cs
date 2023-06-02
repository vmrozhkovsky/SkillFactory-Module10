using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Calc : ICalc
    {
        public double Sum(double a, double b)
        {
            return a + b;
        }
        public void ReadUserNumbers(out double a, out double b)
        {
            Console.WriteLine("Введите первое число:");
            double InputNumber1 = 0;
            bool IsCorrect = true;
            while (IsCorrect)
            {
                try
                {
                    InputNumber1 = Convert.ToDouble(Console.ReadLine());
                    IsCorrect = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Введенено некорректное значение. Введите число:");
                }
            }
            a = InputNumber1;
            Console.WriteLine("Введите второе число:");
            double InputNumber2 = 0;
            IsCorrect = true;
            while (IsCorrect)
            {
                try
                {
                    InputNumber2 = Convert.ToDouble(Console.ReadLine());
                    IsCorrect = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Введенено некорректное значение. Введите число:");
                }
            }
            b = InputNumber2;
        }
    }
}
