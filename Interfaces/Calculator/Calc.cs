using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    /// <summary>
    /// Класс Calc, реализует интерфейс ICalc, на вход принимает объект типа Logger.
    /// </summary>
    internal class Calc : ICalc
    {
        ILogger Logger;
        public Calc(ILogger logger) 
        {
            Logger = logger;
        }

        /// <summary>
        /// Метод суммирования двух чисел, на входе - два числа, на выходе - их сумма.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public double Sum(double a, double b)
        {
            return a + b;
        }

        /// <summary>
        /// Метод чтения данных от пользователя с проверкой корректности. На выходе 2 числа типа double.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
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
                    Logger.Error("Введенено некорректное значение первого числа. Введите число:");
                }
            }
            a = InputNumber1;
            Logger.Event($"Введено первое число - {a}.");
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
                    Logger.Error("Введенено некорректное значение второго числа. Введите число:");
                }
            }
            b = InputNumber2;
            Logger.Event($"Ведено второе число - {b}.");
        }
    }
}
